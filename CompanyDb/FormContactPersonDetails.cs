using System;
using AVACore.UiControls;
using System.Windows.Forms;
using AVACore;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using AVACore.DataTypes;
using System.Collections.Generic;
using DevExpress.Utils.Menu;

namespace AVALibrary.CompanyDb
{

    public partial class FormContactPersonDetails : AvaForm
    {
  
        private readonly CpyDbValidator _validator;
        public DXPopupMenu menu;
        Person _pEdit;
        Company _cEdit;
        const string _imgFolderPath = @"Z:\AbisTest\Company\ProfilePicture\";
        private AvaError _ae;


        public FormContactPersonDetails(DataControl dc, Person p ) : base(dc)
        {
            _validator = new CpyDbValidator();
            InitializeComponent();
            _ae = new AvaError("Company DB");
            _pEdit = p;

        }
        #region functions
        private void SetForm()
        {

            textBoxPosition.Text = _pEdit.Position;
            textBoxFirstName.Text = _pEdit.PreName;
            textBoxSurname.Text = _pEdit.Surname;
            textBoxEmail.Text = _pEdit.Email;
            textBoxAdress.Text = _pEdit.PAdress;
            textBoxSkypeName.Text = _pEdit.Skype;
            textBoxPhoneNumber.Text = _pEdit.Phone;
            dateTimePickerBirthday.Value = _pEdit.Birthday;
            textBoxAdditionalInfo.Text = _pEdit.AdditionalInfo;

            SetImage();

        }
        private void SetImage()
        {
            if (File.Exists(_pEdit.ProfImage))
            {
                pictureBoxProfile.Image = Image.FromFile(_pEdit.ProfImage);
                textBoxProfilepath.Text = _pEdit.ProfImage;
            }
        }
        private void RefreshTextBoxes()
        {
            TextBox textBox = new TextBox();
            string temp = textBox.Text;
            textBox.Text = "";
            textBox.Text = temp;
            
          
        }
        private void SaveForm(Person p)
        {
            p.Position = textBoxPosition.Text;
            p.PreName = textBoxFirstName.Text;
            p.Surname = textBoxSurname.Text;
            p.Email = textBoxEmail.Text;
            p.PAdress = textBoxAdress.Text;
            p.Skype = textBoxSkypeName.Text;
            p.Phone = textBoxPhoneNumber.Text;
            p.Birthday = dateTimePickerBirthday.Value;
            p.ProfImage = textBoxProfilepath.Text;
            p.AdditionalInfo = textBoxAdditionalInfo.Text;
        }
        //public void AddItemTODropDownButton()
        //{

        //    menu = new DXPopupMenu();
        //    menu.Items.Add(new DXMenuItem("Import"));
        //    menu.Items.Add(new DXMenuItem("Export"));

        //    dropDownButtonContact.DropDownControl = menu;
        //    foreach (DXMenuItem item in menu.Items)
        //        item.Click += Item_Click;
        //    //  dropDownButtonContact.Text = menu.Items[0].Caption;
        //}
        //private void Item_Click(object sender, EventArgs e)
        //{
        //    dropDownButtonContact.Text = ((DXMenuItem)sender).Caption;

        //    {
        //        FormOutlookContactlist form = new FormOutlookContactlist(Dc,_pEdit);
        //        form.ShowDialog();
        //        Refresh();
        //    }

        //}
        public void ProfilePicture()
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.RestoreDirectory = true;
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                _pEdit.ProfImage = CpyImageHandler.InsertImageToAbisfolder(opnfd.FileName, _imgFolderPath, _pEdit, _ae);
                SetImage();
            }
        }
        public void ShowDialogView()
        {
            LockControlValues(this);
            ShowDialog();
        }

        public void LockControlValues(Control Container)
        {
    
            try
            {
                foreach (Control ctrl in Container.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ((TextBox)ctrl).ReadOnly = true;
                    if (ctrl.GetType() == typeof(ComboBox))
                        ((ComboBox)ctrl).Enabled = false;
                    if (ctrl.GetType() == typeof(CheckBox))
                        ((CheckBox)ctrl).Enabled = false;
                    if (ctrl.GetType() == typeof(Button))
                        ((Button)ctrl).Visible = false;
                    if (ctrl.GetType() == typeof(PictureBox))
                        ((PictureBox)ctrl).Enabled = false;
                    if (ctrl.GetType() == typeof(DateTimePicker))
                        ((DateTimePicker)ctrl).Enabled = false;

                    if (ctrl.Controls.Count > 0)
                        LockControlValues(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool ValidateForm()
        {
            Person _pValidate = new Person();
            SaveForm(_pValidate);
            var errors = _validator.CheckPerson(_pValidate);
            if (!errors.IsSuccessful)
            {
                AvaError ae = new AvaError("Person Validaiton");
                ae.ErrorList = errors;
                AvaError.ShowReportOnlyError(Dc, "Failed to Validate Person", ae);
                return false;
            }
            return true;
        }

        #endregion

        #region EventHandlers on click
        private void buttonRemoveProfile_Click(object sender, EventArgs e)
        {
            pictureBoxProfile.Image = null;
            textBoxProfilepath.Text = "";
            buttonRemoveProfile.Visible = true;
        }
        public void buttonUploadProfile_Click(object sender, EventArgs e)
        {
            ProfilePicture();
        }
        //private void dropDownButtonContact_Click(object sender, EventArgs e)
        //{
        //    AddItemTODropDownButton();
        //    Refresh();
        //}
        private void buttonImport_Click(object sender, EventArgs e)
        {
            FormOutlookContactlist form = new FormOutlookContactlist(Dc, _pEdit);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
                SetForm();

       
        }
        
        private void buttonok_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            DialogResult = DialogResult.OK;

            Close();
        }
       
        private void buttonCancel_Click(object sender, EventArgs e)
        {
           
          Close();
            
        
         
        }

        #endregion
        private void FormContactPersonDetails_Load(object sender, EventArgs e)
        {
            SetForm();
        }
        private void FormContactPersonDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                SaveForm(_pEdit);
        }

        
    }

}
  