using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AVACore;
using AVACore.DataTypes;
using AVACore.UiControls;
using DevExpress.Office.Utils;

namespace AVALibrary.CompanyDb
{
    public partial class FormCpyMain : AvaForm
    {

        private const string FilePath = @"Z:\AbisTest\Company\Company.txt"; 
        private const string FileServicePath = @"Z:\AbisTest\Company\service.txt";
        public List<Company> _cpyList;
    
        public List<Person> _allPersonList; 
        private AvaError _ae;
        private List<Gewerk> _glist;
        private Gewerk c;
     

        public  FormCpyMain( DataControl dc) : base (dc)
        {
            InitializeComponent();
          
            _cpyList = new List<Company>();
            _ae = new AvaError("Company DB");
            c = new Gewerk();
            _glist = new List<Gewerk>();
        }
         #region functions
        public void RemoveListItem(int index)
        {
            if (listBox1.SelectedIndex >= 0)
                _cpyList.RemoveAt(index);

        }
        public void RefreshListbox()
        {
            
            listBox1.Items.Clear();
            foreach (var cpy in _cpyList)
                listBox1.Items.Add(cpy);
        }
        public void FindGewerkInCompany()
        {
            listBox1.Items.Clear();
               
            Boolean found = false;
         
            string servicesearch = comboBox1.SelectedItem.ToString();
            foreach(Company comp in _cpyList)
            {
                found = false;
                foreach (var service in comp.Servic)
                {
                    if (service.Services == servicesearch) 
                    {
                 
                        found = true;
                    }                
                }
                if (found)
                    listBox1.Items.Add(comp);

            }
            foreach(var name in comboBox1.Items)
            {
                if (name == servicesearch) 
                {

                  foreach(Company comp in _cpyList)
                    {
                        if (comp.Servic.Contains(c))
                            found = true;
                        listBox1.Items.Add(comp);
                    }
          
                }
            }
             

            

        }
        #endregion

        #region Eventhandlers
        private void buttoninsert_Click(object sender, EventArgs e)

        {
            Company newCompany = new Company();
            FormCpyDetail form = new FormCpyDetail(Dc, newCompany, _allPersonList, _glist);
            form.ShowDialog();
            if (_cpyList == null) 
            {
                return;
            }
            else
            {
                _cpyList.Add(newCompany);
                RefreshListbox();
            }
        }
        private void buttonedit_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("please Select an entry first");

            if (listBox1.SelectedIndex >= 0)
            {
                int index = listBox1.SelectedIndex;
                var form = new FormCpyDetail(Dc, _cpyList[index], _allPersonList, _glist);
                form.ShowDialog();

                RefreshListbox();
            }
        }
        private void buttondelete_Click(object sender, EventArgs e)
        //to do
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Please select an entry first");

            else
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    DialogResult delete = new DialogResult();
                    delete = MessageBox.Show("Are you sure you want to delete?", "Delete",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning,
                             MessageBoxDefaultButton.Button2);
                    if (delete == DialogResult.Yes)
                    {

                        int index = listBox1.SelectedIndex;
                        RemoveListItem(index);
                        RefreshListbox();
                    }
                }
            }

        }

        private void buttonSubjects_Click(object sender, EventArgs e)
        {

            FormGewerk form = new FormGewerk(Dc,c);
            form.ShowDialog();
        }

        #endregion



        private void FormCompanyDbMain_Load(object sender, EventArgs e)
        {
            //loading file 
            {
                
                XmlCompanyDbLoader cdLoader = new XmlCompanyDbLoader(FilePath, _ae);

                _allPersonList = new List<Person>();
                _cpyList = cdLoader.Run(); 
                foreach (Company c in _cpyList)
                    _allPersonList.AddRange(c.ContactPersons);
               
                AvaError.ShowReportOnlyError(Dc, "Something is wrong", _ae);
                RefreshListbox();

            }
            {
                {
                    XmlServicesLoader sloader = new XmlServicesLoader(FileServicePath, _ae);
                    List<Gewerk> _addlist = sloader.Run();

                    foreach (Gewerk ca in _addlist)
                    {
                        comboBox1.Items.Add(ca);
      
                    }
                    AvaError.ShowReportOnlyError(Dc, "Something is wrong", _ae);
                }

            }
        }

        private void FormCompanyDbMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlCompanyDbWriter cdWriter = new XmlCompanyDbWriter(_cpyList, FilePath);
            cdWriter.Run();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindGewerkInCompany();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            FindGewerkInCompany();

        }

      
    }
}


    
   
