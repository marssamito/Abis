using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AVALibrary.CompanyDb
{

    public class Company : object
    {

        public string CpyName { get; set; }

        public Address CpyAdress { get; set; }

        public List<Person> ContactPersons { get; set; }

        public List<Gewerk> Servic { get; set; }

        public Company()
        {
            CpyName = "";
            Servic = new List<Gewerk>();
            ContactPersons = new List<Person>();
            CpyAdress = new Address();
        }
        public Company(string cpyName)
        {

            CpyName = cpyName;

        }

        public override string ToString()
        {
            return CpyName;

        }
        public bool IsEmpty()
        {
            //done

            if (!string.IsNullOrEmpty(CpyName)) return false;
            return true;
        }
    }


    public class Address : object
    {

        public string Street;
        public string City;
        public string Country; //ISO
        public string ZipCode;
        public string AdditionalInfo;


        public Address()
        {

            Street = "";
            City = "";
            Country = "";
            ZipCode = "";
            AdditionalInfo = "";
    
        }
        public Address(string street, string city, string country, string zipcode, string additionalinfo,string service)
        {
            Street = street;
            City = city;
            Country = country;
            ZipCode = zipcode;
            AdditionalInfo = additionalinfo;
        
        }
        public bool IsEmpty()
        {
            //done
            if (!string.IsNullOrEmpty(Street) || !string.IsNullOrEmpty(City) || !string.IsNullOrEmpty(Country) ||
                !string.IsNullOrEmpty(ZipCode) || !string.IsNullOrEmpty(AdditionalInfo)) return false;
            return true;
        }
       
    }

    public class Person
    {
        public string Position;
        public string PreName;
        public string Surname;
        public DateTime Birthday;
        public string PAdress;
        public string Phone;
        public string Email;
        public string Skype;
        public string ProfImage;
        public int Id;
        public string AdditionalInfo;

        public Person()
        {
            Birthday = DateTime.Now;
            Position = "";
            PreName = "";
            Surname = "";
            PAdress = "";
            Phone = "";
            Email = "";
            Skype = "";
            ProfImage = "";
            AdditionalInfo = "";

             

        }
        public string FullName
        {
            get
            {
                return (PreName + " " + Surname).Trim();
            }
        }


        public Person(string position, string prename, string phone, string email, string skype, string addres, string profImage, int id, string additionalInfo,DateTime date)
        {
            Position = position;
            PreName = prename;
            Phone = phone;
            Email = email;
            Skype = skype;
            PAdress = addres;
            ProfImage = profImage;
            Id = id;
            Birthday = date;
            AdditionalInfo = additionalInfo;
        }
        public static int SetNextFreeId(List<Person> personList)
        {
            List<int> idsWeHave = personList.Select(p => p.Id).ToList();
            for (int i = 0; i < 9999; i++)
            {
                if (idsWeHave.Contains(i)) continue;
                return i;
            }
            return -1;
        }
        public override string ToString()
        {
            return string.Format("{0} ({1})", FullName, Position);
        }
        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(FullName);
        }

    }
    public class Gewerk 
    {
        public string Services { get; set; }

        public Gewerk()
        {
            Services = "";

        }
        public Gewerk(string services)
        {
            Services = services;
        }
        public override string ToString()
        {
            return Services;
        }
        public bool IsEmpty()
        {
            if (!string.IsNullOrEmpty(Services)) return false;
                return true;
        }
    }
}

