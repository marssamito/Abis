using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using AVACore;
using AVACore.DataTypes;

namespace AVALibrary.CompanyDb
{
    public class XmlCompanyDbWriter : AVACore.FileOperations.Internal.XmlSaver
    {
        private readonly List<Company> _cdcList;


        public XmlCompanyDbWriter(List<Company> cdcList, string filePath) : base(filePath, null)
        {
            _cdcList = cdcList;
            FilePath = filePath;

        }



        public void Run()
        {
            Writer = XmlWriter.Create(Fs, XmlSettings);
            Writer.WriteStartDocument();
            WriteCompanies();
            Writer.WriteEndDocument();
            Writer.Close();
            Fs.Close();
        }

        private void WriteCompanies()
        {
            Writer.WriteStartElement("ABIS-AVA-CPYDB");
            Writer.WriteAttributeString("Version", "1.0");
            foreach (Company c in _cdcList)
                WriteCompany(c);
            Writer.WriteEndElement();
        }
        private void WriteCompany(Company c)
        {
            if (c.IsEmpty()) return;
            Writer.WriteStartElement("Company");
            Writer.WriteElementString("CpyName", c.CpyName);
            if (!c.CpyAdress.IsEmpty())
                WriteAdress(c.CpyAdress);
            foreach (Gewerk g in c.Servic)
            {
                if (!g.IsEmpty())
                    writeservice(g);
            }
            foreach (Person p in c.ContactPersons)
            {
                if (!p.IsEmpty())
                    WritePerson(p);
            }
           


            Writer.WriteEndElement();
        }
        private void WriteAdress(Address a)
        {
            Writer.WriteStartElement("Address");
            Writer.WriteElementString("Street", a.Street);
            Writer.WriteElementString("City", a.City);
            Writer.WriteElementString("Country", a.Country);
            Writer.WriteElementString("Zipcode", a.ZipCode);
            Writer.WriteElementString("AdditionalInfo", a.AdditionalInfo);          
            Writer.WriteEndElement();
        }
        private void WritePerson(Person p)
        {
            Writer.WriteStartElement("Person");
            Writer.WriteElementString("Position", p.Position);
            Writer.WriteElementString("PreName", p.PreName);
            Writer.WriteElementString("SurName", p.Surname);
            Writer.WriteElementString("Birthday",p.Birthday.ToShortDateString());
            Writer.WriteElementString("PAdress", p.PAdress);
            Writer.WriteElementString("Phone", p.Phone);
            Writer.WriteElementString("Email", p.Email);
            Writer.WriteElementString("Skype", p.Skype);
            Writer.WriteElementString("ID", p.Id.ToString());
            Writer.WriteElementString("Profimage",p.ProfImage.ToString());
            Writer.WriteElementString("AdditionalInfo", p.AdditionalInfo);
            Writer.WriteEndElement();

        }
        private void writeservice(Gewerk g)
        {
            Writer.WriteStartElement("Gewerke");
            Writer.WriteElementString("Gewerk", g.Services);
            Writer.WriteEndElement();
        }

    }
    public class XmlCompanyDbLoader : AVACore.FileOperations.Internal.XmlLoader
    {
        private readonly DataControl dc;
        private readonly Person newp;
        private FormContactPersonDetails p; 

        public XmlCompanyDbLoader(string filePath, AvaError ae) : base(filePath, ae)
        {
            
            p = new FormContactPersonDetails(dc, newp);
        }
        public List<Company> Run()
        {
            List<Company> cpyList = new List<Company>();
            try
            {
                Doc = XDocument.Load(FilePath);
                if (Doc.Root != null)
                {
                    foreach (XElement el in Doc.Root.Elements())
                        switch (el.Name.ToString())
                        {
                            case "Company":
                                var cpy = ReadCompany(el);
                                if (cpy != null)
                                    cpyList.Add(cpy);
                                break;

                            default:
                                AddUnknowNodeError(el);
                                break;
                        }

                }
                else SendError(string.Format("Nicht lesbare Datei: {0}", FilePath));
            }    
            catch (Exception e)
            {
                SendError(string.Format("Kritischer Fehler: {0}", e.Message));
            }
            return cpyList;
        }

        private Company ReadCompany(XElement el)
        {
            Company cpyIn = new Company();
            foreach (XElement childEl in el.Elements())
            {
                switch (childEl.Name.ToString())
                {
                    case "CpyName":
                        cpyIn.CpyName = childEl.Value;

                        break;
                    case "Address":
                        var Address = ReadAddress(childEl);
                        if (!Address.IsEmpty())
                            cpyIn.CpyAdress = Address;
                        break;
                    case "Person":
                        var person = ReadPerson(childEl);
                        if (!person.IsEmpty())
                            cpyIn.ContactPersons.Add(person);
                        break;
                    case "Gewerke":
                        var Gewerk = Readgewerk(childEl);
                        if (!Gewerk.IsEmpty())
                            cpyIn.Servic.Add(Gewerk);
                        break;
                    default:
                        AddUnknowNodeError(childEl);
                        break;
                }
            }
            if (cpyIn.IsEmpty())
            {
                SendError(string.Format("Invalid Company"));
                return null;
            }
            return cpyIn;
        }
        private Address ReadAddress(XElement el)
        {
            Address adrIn = new Address();
            foreach (XElement childEl in el.Elements())
            {
                switch (childEl.Name.ToString())
                {
                    case "Street":
                        adrIn.Street = childEl.Value;
                        break;
                    case "City":
                        adrIn.City = childEl.Value;
                        break;
                    case "Country":
                        adrIn.Country = childEl.Value;
                        break;
                    case "Zipcode":
                        adrIn.ZipCode = childEl.Value;
                        break;
                    case "AdditionalInfo":
                        adrIn.AdditionalInfo = childEl.Value;
                        break;
                    

                    default:
                        AddUnknowNodeError(childEl);
                        break;
                }
            }
            return adrIn;
        }
        private Person ReadPerson(XElement el)
        {
            Person prin = new Person();
            foreach (XElement childEl in el.Elements())
            {
                switch (childEl.Name.ToString())
                {
                    case "Position":
                        prin.Position = childEl.Value;
                        break;
                    case "PreName":
                        prin.PreName = childEl.Value;
                        break;
                    case "SurName":
                        prin.Surname = childEl.Value;
                        break;
                    case "Birthday":
                        if (!DateTime.TryParse(childEl.Value, out prin.Birthday))
                            SendError(string.Format("Invalid Date"));
                        break;
                    case "PAdress":
                        prin.PAdress = childEl.Value;
                        break;
                    case "Phone":
                        prin.Phone = childEl.Value;
                        break;
                    case "Email":
                        prin.Email = childEl.Value;
                        break;
                    case "Skype":
                        prin.Skype = childEl.Value;
                        break;
                    case "ID":
                        prin.Id = int.Parse(childEl.Value);
                        break;
                    case "Profimage":
                        prin.ProfImage = childEl.Value;
                        break;
                    case "AdditionalInfo":
                        prin.AdditionalInfo = childEl.Value;
                       
                        break;


                    default:
                        AddUnknowNodeError(childEl);
                        break;
                }

            }
            return prin;
            
        }
        private Gewerk Readgewerk(XElement el)
        {
            Gewerk gin = new Gewerk();
            foreach(XElement childEl in el.Elements())
            {
                switch(childEl.Name.ToString())
                {
                    case "Gewerk":
                        gin.Services = childEl.Value;
                        break;

                    default:
                        AddUnknowNodeError(childEl);
                        break;
                }

            }
            return gin;
        }
    }
    public class XmlServicesWriter : AVACore.FileOperations.Internal.XmlSaver
    {
        private readonly List<Gewerk> _actions;

        public XmlServicesWriter(List<Gewerk> actions, string fileServicePath) : base(fileServicePath, null)
        {
            _actions = actions;
            FilePath = fileServicePath;
        }
        public void Run()
        {
            Writer = XmlWriter.Create(Fs, XmlSettings);
            Writer.WriteStartDocument();
            WriteServices();
            Writer.WriteEndDocument();
            Writer.Close();
            Fs.Close();
        }
        private void WriteServices()
        {
            Writer.WriteStartElement("ABIS-AVA-CPYDB");
            Writer.WriteAttributeString("Version", "1.0");
            Writer.WriteStartElement("Gewerke");
            foreach (Gewerk c in _actions)
                WriteCompanyActions(c);
            Writer.WriteEndElement();
            Writer.WriteEndElement();
        }
        private void WriteCompanyActions(Gewerk c)
        {
            if (c.IsEmpty()) return;
 
            Writer.WriteElementString("Gewerk", c.Services);
    
        }



    }

    public class XmlServicesLoader : AVACore.FileOperations.Internal.XmlLoader
    {
        private readonly DataControl dc;

        public XmlServicesLoader(string fileServicePath, AvaError ae) : base(fileServicePath, ae)
        {

        }
        public List<Gewerk> Run()
        {
            List<Gewerk> copy = new List<Gewerk>();
            try
            {
                Doc = XDocument.Load(FilePath);
                if (Doc.Root != null)
                {
                    foreach(XElement el in Doc.Root.Elements())
                        switch(el.Name.ToString())
                        {
                            case "Gewerke":
                                copy = ReadServices(el);
                                break;
                            default:
                                AddUnknowNodeError(el);
                                break;
                        }
                }
                else SendError(string.Format("Nicht lesbare Datei: {0}", FilePath));
            }
            catch (Exception e)
            {
                SendError(string.Format("Kritischer Fehler: {0}", e.Message));
            }
            return copy;
        }

        private List<Gewerk> ReadServices(XElement el)
        {
            List<Gewerk> copy = new List<Gewerk>();
            foreach (XElement childEl in el.Elements())
            {
                switch(childEl.Name.ToString())
                {
                    case "Gewerk":
                        Gewerk cpyitem = new Gewerk();
                        cpyitem.Services = childEl.Value;
                        if (cpyitem.IsEmpty())
                        {
                            SendError(string.Format("Invalid Services"));
                            break;
                        }
                        copy.Add(cpyitem);
                        break;
                    default:
                        AddUnknowNodeError(childEl);
                        break;
                }
            }
            return copy;
        }

    }



}
