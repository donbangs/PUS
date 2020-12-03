using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CovidService
{
    [ServiceContract/*(SessionMode = SessionMode.Required)*/]
    public interface ICovidService
    {
        [OperationContract(IsInitiating = true, IsTerminating = false)]
        void AddInfected(CovidPerson covidPerson, string name, string town, string datesymptoms, string datetest);
        [OperationContract]
        void AddContact(CovidPerson covidPerson,string name, string town, string datecontact);
        [OperationContract]
        PersonWithCovid GetInfected();
        [OperationContract]
        List<PersonWithCovid> GetContacts();
        [OperationContract]
        List<PersonWithCovid> EndSession();
        [DataMember]
        PersonWithCovid InfectedPerson { get; set; } 
        [DataMember]
        List<PersonWithCovid> Contacts { get; set; }
    }

    [DataContract]
    public class PersonWithCovid
    {
        [DataMember]
        public CovidPerson TypePerson { get; set; }
        [DataMember]
        public  string Name { get; set; }
        [DataMember]
        public string Town { get; set; }
        [DataMember]
        public string DateSymptoms { get; set; }
        [DataMember]
        public string  DateTest { get; set; }
        [DataMember]
        public string DateContact { get; set; }

        public PersonWithCovid(CovidPerson typePerson,string name, string town, string datesymptoms, string datetest)
        {
            TypePerson = typePerson;
            Name = name;
            Town = town;
            DateSymptoms = datesymptoms;
            DateTest = datetest;
        }
        public PersonWithCovid(CovidPerson typePerson, string name, string town,string dateContact)
        {
            TypePerson = typePerson;
            Name = name;
            Town = town;
            DateContact = dateContact;
        }

    }
    public enum CovidPerson
    {
        Infected,
        ContactWithInfected,
    }
}
