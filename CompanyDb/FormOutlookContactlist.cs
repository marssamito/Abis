using Microsoft.Office.Interop.Outlook;
using System;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Data;
using AVACore;
using System.Collections;
using AVACore.UiControls.DataGrid;



namespace AVALibrary.CompanyDb
{
    public partial class FormOutlookContactlist : Form
    {
        Person _pEdit;
        Items OutlookItems;
        Outlook.Application outlookObj = new Outlook.Application();
        MAPIFolder Folder_Contacts;
       
        public FormOutlookContactlist(DataControl dc, Person p) 
        {
            InitializeComponent();
            _pEdit = p;
            
        }


        private void InitDataTable()
        {
            //Run only once
            //Creates the data table and sets properties for the DataGridView
            dataGridView1.InitDataTable();

            dataGridView1.DataTable.Columns.Add("FirstName");
            dataGridView1.DataTable.Columns.Add("LastName");
            dataGridView1.DataTable.Columns.Add("MobileNumber");
        }

        private void InitDataGridView()
        {
            // How much space the column takes
            dataGridView1.SetSingleSelect("FirstName");
            dataGridView1.SetColumn("FirstName", AvaDataType.Text, 30, false, true);
            dataGridView1.SetColumn("LastName", AvaDataType.Text, 30, true, true);
            dataGridView1.SetColumn("MobileNumber", AvaDataType.Text, 100, false, true);

           // dataGridView1.SetColumnHeaderText("OG", "OG DISPLAYED")

        }
        private void SetDataGridView()
        {
            dataGridView1.DataTable.Rows.Clear();
            dataGridView1.DataTable.BeginLoadData();

            for (int i = 0; i < OutlookItems.Count; i++)
            {
                ContactItem contact = (ContactItem)OutlookItems[i + 1];

                DataRow dr = dataGridView1.DataTable.NewRow();
                dr["FirstName"] = contact.FirstName;
                dr["LastName"] = contact.LastName;
                dr["MobileNumber"] = contact.MobileTelephoneNumber;
                dataGridView1.DataTable.Rows.Add(dr);

            }
            dataGridView1.DataTable.EndLoadData();
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
       


        public void ImportContactsFromOutlook()
        {
            Folder_Contacts = (MAPIFolder)outlookObj.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);
            OutlookItems = Folder_Contacts.Items;
            if (OutlookItems.Count == -1)
                MessageBox.Show("No Contact Found");
            else if (OutlookItems.Count >= 0)
            {
                DialogResult Add = new DialogResult();
                Add = MessageBox.Show("Add " + OutlookItems.Count.ToString() + " Contacts to The DataGrid", "Add Contacts",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (Add == DialogResult.Yes)
                {
                    SetDataGridView();
                }
            }

        }
        public void SaveForm()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int i = dataGridView1.SelectedCells[0].RowIndex;

                ContactItem contact = (ContactItem)OutlookItems[i+1];
                _pEdit.PreName = contact.FirstName;
                _pEdit.Surname = contact.LastName;
                _pEdit.Phone = contact.MobileTelephoneNumber;
                _pEdit.Email = contact.Email1Address;
            }
           
            
        }
        private void buttonOutlook_Click(object sender, EventArgs e)
        {

            ImportContactsFromOutlook();

        }
        private void FormOutlookContactlist_Load(object sender, EventArgs e)
        {
            InitDataTable();
            InitDataGridView();
        }
        private void FormOutlookContactlist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult==DialogResult.OK)
                
            SaveForm();
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count>0)
            {
                int i = dataGridView1.SelectedCells[0].RowIndex;
            }
        }

        private void buttonGoogle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!");
            //GoogleContacts.ContactHandler.RetrieveGoogleContactsToGrid(dataGridView1);
         
        }
    }
}
