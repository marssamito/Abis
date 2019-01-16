using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using AVACore.DataTypes;

namespace AVALibrary.CompanyDb
{
    class CpyImageHandler
    {
        public static string InsertImageToAbisfolder(string filePathSource, string folderPathTarget, Person p, AvaError ae)
        {
            try
            {

                string filePathTarget = Path.Combine(folderPathTarget, p.Id.ToString());
                
                CreateImageFolder(folderPathTarget, ae);
                if (!File.Exists(filePathSource))
                {
                    ae.OnError(ErrorType.Warning, "Bild ({0}) nicht gefunden, Pfad : {1}", p.FullName, filePathSource);
                }
                else
                    DownscaleImage(filePathSource, filePathTarget);
                return filePathTarget;
            }
            catch (Exception e)
            {
                ae.OnError(ErrorType.Error, "Fehler bei der Bildübertragung ({0})\r\n{1}", p.FullName, e.Message);
            }
            return "";
        }
        public static void CreateImageFolder(string imageFolderPath, AvaError ae)
        {
            try
            {
                if (!Directory.Exists(imageFolderPath)) Directory.CreateDirectory(imageFolderPath);
            }
            catch (Exception e)
            {
                ae.OnError(ErrorType.Fatal, e.Message);
            }
        }
        private static void DownscaleImage(string inputPath, string outputPath)
        {
            int maxheight = 1920;
            int maxWidth = 1920;
            if (File.Exists(outputPath))
            {
                using (Image image = Image.FromFile(inputPath))
                {
                    if (image.Width <= maxWidth && image.Height <= maxheight) return;
                }
            }

            EncoderParameters eps = new EncoderParameters(1);
            ImageCodecInfo ici = GetEncoderInfo("image/jpeg");

            string workPath = Path.GetTempFileName();


            File.Copy(inputPath, workPath, true);
            Image newResizeImage = null;
            using (Image image = Image.FromFile(workPath))
            {
                if (image.Height > maxheight || image.Width > maxWidth)
                {

                    var ratio = Math.Min((double)maxheight / image.Height, (double)maxWidth / image.Width);
                    var newWidth = (int)(image.Width * ratio);
                    var newHeight = (int)(image.Height * ratio);
                    newResizeImage = new Bitmap(newWidth, newHeight);
                    using (var g = Graphics.FromImage(newResizeImage))
                    {
                        g.DrawImage(image, 0, 0, newWidth, newHeight);
                    }
                }

            }

            if (newResizeImage != null)
            {
                newResizeImage.Save(workPath);
                newResizeImage.Dispose();
            }
            using (Image image = Image.FromFile(workPath))
            {
                //no temp clean up
                using (MemoryStream resizedPhotoStream = new MemoryStream())
                {
                    long resizedSize;
                    var quality = 93;
                    //long lastSizeDifference = 0;
             
                    resizedPhotoStream.SetLength(0);


                    eps.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);


                    image.Save(resizedPhotoStream, ici, eps);
                    resizedSize = resizedPhotoStream.Length;

                }

                image.Save(outputPath, ici, eps);
            }
        }
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
    }

}
