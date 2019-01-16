using AVACore;
using AVACore.DataTypes;
using AVACore.UiControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AVALibrary.CompanyDb
{
    public partial class FormGewerk : AvaForm
    {
        private const string FileServicePath = @"Z:\AbisTest\Company\service.txt";
        private AvaError _ae;
        public FormGewerk(DataControl dc, Gewerk c) : base(dc)

        {
            InitializeComponent();
            _ae = new AvaError("Company Actions");

        }
        #region functions

        private void AddToListBox(int index)
        {
            listBoxServicesRequired.Items.Insert(index, new Gewerk(textBoxService.Text));
            textBoxService.Text = "";
        }

        private void RemoveFromListBox()
        {
            int index = listBoxServicesRequired.SelectedIndex;
            if (index >= 0)
                listBoxServicesRequired.Items.RemoveAt(index);
        }
        #endregion

        #region eventHandlers onclick
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxService.Text.Length == 0)
                return;
            AddToListBox(listBoxServicesRequired.Items.Count);

        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index = listBoxServicesRequired.SelectedIndex;
            if (index == -1)
                MessageBox.Show("Please Select an Entry frst");
            else if (index >= 0) 
            {
                RemoveFromListBox();
                AddToListBox(index);
            }

        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxServicesRequired.SelectedIndex == -1)
                MessageBox.Show("Please select an entry first");

            else
            {
                if (listBoxServicesRequired.SelectedIndex >= 0)
                {
                    DialogResult delete = new DialogResult();
                    delete = MessageBox.Show("Are you sure you want to delete?", "Delete",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning,
                             MessageBoxDefaultButton.Button2);
                    if (delete == DialogResult.Yes)
                    {
                        RemoveFromListBox();

                    }
                }
            }

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

            List<Gewerk> _addlist = new List<Gewerk>();

            foreach (Gewerk ca in listBoxServicesRequired.Items)
                _addlist.Add(ca);

            XmlServicesWriter servicesWriter = new XmlServicesWriter(_addlist, FileServicePath);
            servicesWriter.Run();
            this.Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        private void FormGewerk_Load(object sender, EventArgs e)
        {

            XmlServicesLoader sloader = new XmlServicesLoader(FileServicePath, _ae);
            List<Gewerk> _addlist = sloader.Run();

            foreach (Gewerk ca in _addlist)
                listBoxServicesRequired.Items.Add(ca);

            AvaError.ShowReportOnlyError(Dc, "Something is wrong", _ae);
        }

        private void FormGewerk_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

      
    }
}
