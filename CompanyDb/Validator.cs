using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AVACore.DataTypes;
using AVACore.Logics;


namespace AVALibrary.CompanyDb
{
    public class CpyDbValidator
    {
        public ValidationError CheckCpyName(string cpyName)
        {
            //todo should not be empty or duplicate
            
            ValidationError se = new ValidationError("");
            if (string.IsNullOrEmpty(cpyName))
                se.AppendErrorMessage("The Name of the company is empty");
          

            return se;
        }
        public ValidationError CheckAddress(Address adress)
        {
            //todo should not be empty or invalid
            ValidationError se = new ValidationError("");
            if(string.IsNullOrEmpty(adress.Street))
            {
                se.AppendErrorMessage("The Address of the Company is empty");
                
            }
            return se;
        }
        public ValidationError CheckCity(Address address)
        {
            ValidationError se = new ValidationError("");
            if(string.IsNullOrEmpty(address.City))
            {
                se.AppendErrorMessage("The Value City is Empty");
            }
            return se;
        }
        public ValidationError CheckCountry(Address address)
        {
            ValidationError se = new ValidationError("");
            if (string.IsNullOrEmpty(address.Country))
            {
                se.AppendErrorMessage("Select Your Country");
            }
            return se;
        }
        public ValidationError CheckZipcode(Address address)
        {
            ValidationError se = new ValidationError("");
                if(string.IsNullOrEmpty(address.ZipCode))
            {
                se.AppendErrorMessage("The Zipcode Is Empty");
            }
            return se;
        }
        public ErrorDataCollection checkCompany(Company company)
        {
            ErrorDataCollection se = new ErrorDataCollection();
            if (company == null)
            {
                se.AppendError(new ValidationError("Value Empty"));

            }
            else
            {
                se.AppendError(CheckCpyName(company.CpyName));
                se.AppendError(CheckAddress(company.CpyAdress));
                se.AppendError(CheckCity(company.CpyAdress));
                se.AppendError(CheckCountry(company.CpyAdress));
                se.AppendError(CheckZipcode(company.CpyAdress));

            }
            return se;
        }
        public ErrorDataCollection CheckPerson(Person person)
        {
            //todo should not be empty or invalid
            ErrorDataCollection ed = new ErrorDataCollection();
              
     
            if (person == null)
            {
                ed.AppendError(new ValidationError("Value Empty"));
            }
            else
            {
                ed.AppendError(CheckEmail(person.Email));
                ed.AppendError(IsValidPhoneNumber(person.Phone));
          

            }

            return ed;
           
        }
        public ValidationError IsValidPhoneNumber(string strPhone)
        {
            ValidationError se = new ValidationError("");
            string regExPattern = @"[0-9]{6}$";
            if(!MatchStringFromRegex(strPhone, regExPattern))
            {
                se.AppendErrorMessage("Invalid phone number");
            }
            return se;
        }
      
        public static bool MatchStringFromRegex(string str, string regexstr)
        {
            str = str.Trim();
            System.Text.RegularExpressions.Regex pattern = new System.Text.RegularExpressions.Regex(regexstr);
            return pattern.IsMatch(str);
        }
        public ValidationError CheckEmail(string email)
        {
            ValidationError se = new ValidationError("");
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (!MatchStringFromRegex(email, expresion))
            {
                se.AppendErrorMessage("Invalid Email");
            }

            return se;

        }

        
    }
}
