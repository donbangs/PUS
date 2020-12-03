using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.Security.Policy;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CovidService
{
  //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
   // [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]  
   [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Service1 : ICovidService
    {
        public PersonWithCovid InfectedPerson { get; set; }
        public List<PersonWithCovid> Contacts { get; set; } = new List<PersonWithCovid>();

        public void AddInfected(CovidPerson covidPerson,string name, string town, string datesymptoms, string datetest)
        {
            InfectedPerson = new PersonWithCovid(covidPerson, name, town, datesymptoms, datetest);
        }
        public void AddContact(CovidPerson covidPerson,string name, string town, string datecontact)
        {
            Contacts.Add(new PersonWithCovid(covidPerson, name, town, datecontact));
        }
        public PersonWithCovid GetInfected()
        {
            return InfectedPerson;
        }

        public List<PersonWithCovid> GetContacts()
        {
            return Contacts;
        }

        public List<PersonWithCovid> EndSession()
        {
            throw new NotImplementedException();
        }
    }
}
