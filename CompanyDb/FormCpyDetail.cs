using AVACore;
using AVACore.DataTypes;
using AVACore.UiControls;
using DevExpress.Utils.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
namespace AVALibrary.CompanyDb
{
    public partial class FormCpyDetail : AvaForm

    {
        private AvaError _ae;
        private readonly CpyDbValidator _validator;
        Company _cEdit;
        List<Person> _allPersons;
        private const string FileServicePath = @"Z:\AbisTest\Company\service.txt";


        public FormCpyDetail(DataControl dc, Company c, List<Person> allPersons, List<Gewerk> _glist) : base(dc)
        {
            InitializeComponent();
           
            _cEdit = c;
            _allPersons = allPersons;
            _ae = new AvaError("Company DB");
            _validator = new CpyDbValidator();

        }
        #region functions
        public bool ValidateForm()
        {
            Company _Cvalidate = new Company();
            SaveForm(_Cvalidate);
            var errors = _validator.checkCompany(_Cvalidate);
            if (!errors.IsSuccessful)
            {
                _ae.ErrorList = errors;
                AvaError.ShowReportOnlyError(Dc, "Failed to validate Company", _ae);
                return false;
            }
            return true;
        }
        public void RefreshListboxservice()
        {
            listBoxServicesOffered.Items.Clear();
            foreach (var copy in _cEdit.Servic)
                listBoxServicesOffered.Items.Add(copy);
            //_cEdit.Servic.Clear();


        }
      
        public void RefreshListboxContact()
        {
            listBoxContactPersonNames.Items.Clear();
            foreach (var copy in _cEdit.ContactPersons)
                listBoxContactPersonNames.Items.Add(copy);
        }
        public void RemoveListItem(int index)
        {
            Person ptoRemove = _cEdit.ContactPersons[index];
            _cEdit.ContactPersons.Remove(ptoRemove);
            _allPersons.Remove(ptoRemove);

        }
        private void SetForm()
        {
            textBoxCompname.Text = _cEdit.CpyName;
            textBoxroad.Text = _cEdit.CpyAdress.Street;
            countrySelectorFirm.SelectItem(_cEdit.CpyAdress.Country);
            textBoxCity.Text = _cEdit.CpyAdress.City;
            textBoxpostcode.Text = _cEdit.CpyAdress.ZipCode;
            textBoxinfo.Text = _cEdit.CpyAdress.AdditionalInfo;

        }
        private void SaveForm(Company C)
        {
            C.CpyName = textBoxCompname.Text;
            C.CpyAdress.Street = textBoxroad.Text;
            C.CpyAdress.Country = countrySelectorFirm.GetLand();
            C.CpyAdress.City = textBoxCity.Text;
            C.CpyAdress.ZipCode = textBoxpostcode.Text;
            C.CpyAdress.AdditionalInfo = textBoxinfo.Text;

            C.Servic.Clear();
            foreach (Gewerk g in listBoxServicesOffered.Items)
            {
                C.Servic.Add(g);
            }
      
        }

        #endregion

        #region EventHandlers on click
        private void buttondelServices_Click(object sender, EventArgs e)
        {
            if (listBoxServicesOffered.SelectedIndex == -1)
            {
                MessageBox.Show("Choose an entry first");
            }
            else if (listBoxServicesOffered.SelectedIndex >= 0)
            {
                int index = listBoxServicesOffered.SelectedIndex;
                listBoxServicesOffered.Items.RemoveAt(index);


            }

        }
        
        private void buttonView_Click(object sender, EventArgs e)
        {


            if (listBoxContactPersonNames.SelectedIndex == -1)
                MessageBox.Show("please Select an entry first");

            else if (listBoxContactPersonNames.SelectedIndex >= 0)
            {
                int index = listBoxContactPersonNames.SelectedIndex;
                // var cont = new FormContactPersonDetails(Dc, _cEdit.ContactPersons[index]);

                new FormContactPersonDetails(Dc, _cEdit.ContactPersons[index]).ShowDialogView();
            }

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Person newP = new Person();
            newP.Id = Person.SetNextFreeId(_allPersons);

            int index = _cEdit.ContactPersons.Count - 1;
            var form = new FormContactPersonDetails(Dc, newP);
            form.ShowDialog();

            if (!newP.IsEmpty())
            {
                _cEdit.ContactPersons.Add(newP);
                _allPersons.Add(newP);
                RefreshListboxContact();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxContactPersonNames.SelectedIndex == -1)
                MessageBox.Show("please Select an entry first");

            else if (listBoxContactPersonNames.SelectedIndex >= 0)
            {
                int index = listBoxContactPersonNames.SelectedIndex;
                var form = new FormContactPersonDetails(Dc, _cEdit.ContactPersons[index]);
                    form.ShowDialog();

                RefreshListboxservice();
                RefreshListboxContact();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)

        {
            if (listBoxContactPersonNames.SelectedIndex == -1)
                MessageBox.Show("Please select an entry first");


            else if (listBoxContactPersonNames.SelectedIndex >= 0)
            {
                DialogResult delete = new DialogResult();
                delete = MessageBox.Show("Are you sure you want to delete?", "Delete",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Warning,
                         MessageBoxDefaultButton.Button2);
                if (delete == DialogResult.Yes)
                {

                    int index = listBoxContactPersonNames.SelectedIndex;
                    RemoveListItem(index);
                    RefreshListboxservice();
                    RefreshListboxContact();
                }
            }
        }
        private void buttonok_Click_1(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            else if (DialogResult == DialogResult.OK)
            {

                RefreshListboxservice();
                RefreshListboxContact();

            }
            Close();
        }
        private void buttonCancelcpy_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void FormCompanyDetail_Load(object sender, EventArgs e)
        {
            {
                contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.Opening += new CancelEventHandler(contextMenuStrip_Opening);
                listBoxServicesOffered.ContextMenuStrip = ContextMenuStrip;
            }
            {
                XmlServicesLoader sloader = new XmlServicesLoader(FileServicePath, _ae);
                List<Gewerk> _addlist = sloader.Run();

                foreach (Gewerk ca in _addlist)
                {
                    comboBoxServicesOffered.Items.Add(ca);
                }
                AvaError.ShowReportOnlyError(Dc, "Something is wrong", _ae);
            }

            {
                AvaError.ShowReportOnlyError(Dc, "Something is wrong", _ae);

            }

            RefreshListboxservice();
            RefreshListboxContact();
            SetForm();
        }
        private void FormCompanyDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((Form)sender).ActiveControl == buttonAdd) //hack
            {
                e.Cancel = true;
                return;
            }
            if (DialogResult == DialogResult.OK)
            {

                RefreshListboxservice();
                RefreshListboxContact();
            }
            if(_cEdit.IsEmpty())
            {
                return;
            }
            else
            {
                SaveForm(_cEdit);
            }
          
            

        }

        #region events
        private void comboBoxServicesOffered_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBoxServicesOffered.Items.Add(comboBoxServicesOffered.SelectedItem);
        }



        private void listBoxServicesOffered_MouseDown(object sender, MouseEventArgs e)
        {
            ContextMenuStrip = new ContextMenuStrip();
            if (e.Button == MouseButtons.Right)
            {
                listBoxServicesOffered.SelectedIndex = listBoxServicesOffered.IndexFromPoint(e.Location);
                if (listBoxServicesOffered.SelectedIndex != -1)
                {
                    ContextMenuStrip.Show();
                }
            }

        }
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip.Items.Clear();

        }



        #endregion

        private void tableLayoutPanelListBoxControls_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}