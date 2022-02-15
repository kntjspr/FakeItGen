using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeGenerator
{
    internal class FakeGenBeta
    {
        public string name, countryCode, zodiacSign, weight, postCode, phone, mmn, hairColor, eyeColor, height, ethnicity, gender, email, dateOfBirth, city, ccType, ccPin, ccNum, ccExp, address, age, country, salary, qualification, jobTitle, companyPhone, companyName, insitution, companyEmail, companyAddress;


        /// <summary>
        /// Generate identity. 
        /// </summary>
        public void Generate(string country)
        {

            if (country == string.Empty)
            {
                throw new Exception("Country is blank");
               
            } else {
                country = Regex.Replace(country, @"\s+", "");
                country = country.ToLower();
                countryCode = GetCountryCode(country);
            }

            if (countryCode == null)
            {
                throw new Exception("Country are unsupported or doesn't exist");
                
            }
             

            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load("https://fake-it.ws/" + countryCode);


            var nodeLeft = document.DocumentNode.SelectNodes("//div//*//tr/td[1]/span");
            var nodeRight = document.DocumentNode.SelectNodes("//div//*//tr/td[2]/span");

            nodeLeft.ToArray();
            nodeRight.ToArray();

         
            this.country = nodeLeft[0].InnerText;
            this.address = nodeLeft[1].InnerText;
            this.city = nodeLeft[2].InnerText;
            this.gender = nodeLeft[3].InnerText;
            this.phone = nodeLeft[4].InnerText;
            this.mmn = nodeLeft[5].InnerText;
            this.age = nodeLeft[6].InnerText;
            this.height = nodeLeft[7].InnerText;
            this.hairColor = nodeLeft[8].InnerText;

            this.name = nodeRight[0].InnerText;
            this.postCode = nodeRight[1].InnerText;
            this.dateOfBirth = nodeRight[2].InnerText;
            this.email = nodeRight[3].InnerText;
            this.ethnicity = nodeRight[4].InnerText;
            this.zodiacSign = nodeRight[5].InnerText;
            this.weight = nodeRight[6].InnerText;
            this.eyeColor = nodeRight[7].InnerText;


            #region Financial Details
            this.ccType = nodeLeft[9].InnerText;
            this.ccExp = nodeLeft[10].InnerText;
            this.ccNum = nodeRight[9].InnerText;
            this.ccPin = nodeRight[10].InnerText;
            #endregion

            #region Education and Employment Details
            this.qualification = nodeLeft[14].InnerText;
            this.companyName = nodeLeft[15].InnerText;
            this.companyAddress = nodeLeft[16].InnerText;
            this.companyPhone = nodeLeft[17].InnerText;
            
            this.insitution = nodeRight[12].InnerText;
            this.salary = nodeRight[13].InnerText;
            this.jobTitle = nodeRight[14].InnerText;
            this.companyEmail = nodeRight[15].InnerText;
            #endregion
        }

        private string GetCountryCode(string country)
        {

            switch (country)
            {
                case "argentina":
                    return "ar";

                case "armenia":
                    return "am";

                case "australia":
                    return "au";

                case "austria":
                    return "at";

                case "bangladesh":
                    return "bd";

                case "belgium":
                    return "be";

                case "bosniaandherzegovina":
                    return "ba";

                case "brazil":
                    return "br";

                case "bulgaria":
                    return "bg";

                case "canada":
                    return "ca";

                case "china":
                    return "cn";

                case "croatia":
                    return "hr";

                case "cyprus":
                    return "cy";

                case "czechrepublic":
                    return "cz";

                case "denmark":
                    return "dk";

                case "egypt":
                    return "eg";

                case "estonia":
                    return "ee";

                case "finland":
                    return "fi";

                case "france":
                    return "fr";

                case "georgia":
                    return "ge";

                case "germany":
                    return "de";

                case "greatbritain":
                    return "gb";

                case "greece":
                    return "gr";

                case "hongkong":
                    return "hk";

                case "hungary":
                    return "hu";

                case "iceland":
                    return "is";

                case "india":
                    return "in";

                case "indonesia":
                    return "id";

                case "iran":
                    return "ir";

                case "israel":
                    return "il";

                case "italy":
                    return "it";

                case "japan":
                    return "jp";

                case "jordan":
                    return "jo";

                case "kazakhstan":
                    return "kz";

                case "latvia":
                    return "lv";

                case "lithuania":
                    return "lt";

                case "malaysia":
                    return "my";

                case "mexico":
                    return "mx";

                case "moldova":
                    return "md";

                case "mongolia":
                    return "mn";

                case "montenegro":
                    return "me";

                case "nepal":
                    return "np";

                case "netherlands":
                    return "nl";

                case "newzealand":
                    return "nz";

                case "nigeria":
                    return "ng";

                case "norway":
                    return "no";

                case "peru":
                    return "pe";

                case "philippines":
                    return "ph";

                case "poland":
                    return "pl";

                case "portugal":
                    return "pt";

                case "romania":
                    return "ro";

                case "russia":
                    return "ru";

                case "saudiarabia":
                    return "sa";

                case "serbia":
                    return "rs";

                case "singapore":
                    return "sg";

                case "slovakia":
                    return "sk";

                case "slovenia":
                    return "si";

                case "southafrica":
                    return "za";

                case "southkorea":
                    return "kr";

                case "spain":
                    return "es";

                case "sweden":
                    return "se";

                case "switzerland":
                    return "ch";

                case "taiwan":
                    return "tw";

                case "thailand":
                    return "th";

                case "turkey":
                    return "tr";

                case "usa":
                    return "us";

                case "uganda":
                    return "ug";

                case "ukraine":
                    return "ua";

                case "venezuela":
                    return "ve";

                case "vietnam":
                    return "vn";
                case "ar": return "ar";
                case "am": return "am";
                case "au": return "au";
                case "at": return "at";
                case "bd": return "bd";
                case "be": return "be";
                case "ba": return "ba";
                case "br": return "br";
                case "bg": return "bg";
                case "ca": return "ca";
                case "cn": return "cn";
                case "hr": return "hr";
                case "cy": return "cy";
                case "cz": return "cz";
                case "dk": return "dk";
                case "eg": return "eg";
                case "ee": return "ee";
                case "fi": return "fi";
                case "fr": return "fr";
                case "ge": return "ge";
                case "de": return "de";
                case "gb": return "gb";
                case "gr": return "gr";
                case "hk": return "hk";
                case "hu": return "hu";
                case "is": return "is";
                case "in": return "in";
                case "id": return "id";
                case "ir": return "ir";
                case "il": return "il";
                case "it": return "it";
                case "jp": return "jp";
                case "jo": return "jo";
                case "kz": return "kz";
                case "lv": return "lv";
                case "lt": return "lt";
                case "my": return "my";
                case "mx": return "mx";
                case "md": return "md";
                case "mn": return "mn";
                case "me": return "me";
                case "np": return "np";
                case "nl": return "nl";
                case "nz": return "nz";
                case "ng": return "ng";
                case "no": return "no";
                case "pe": return "pe";
                case "ph": return "ph";
                case "pl": return "pl";
                case "pt": return "pt";
                case "ro": return "ro";
                case "ru": return "ru";
                case "sa": return "sa";
                case "rs": return "rs";
                case "sg": return "sg";
                case "sk": return "sk";
                case "si": return "si";
                case "za": return "za";
                case "kr": return "kr";
                case "es": return "es";
                case "se": return "se";
                case "ch": return "ch";
                case "tw": return "tw";
                case "th": return "th";
                case "tr": return "tr";
                case "us": return "us";
                case "ug": return "ug";
                case "ua": return "ua";
                case "ve": return "ve";
                case "vn": return "vn";

                default:
                    return null;

            }
        }

    }
}

