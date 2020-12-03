using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]

    public interface IService1
    {

        // Wcf nie wspiera przeciążonych metod każdy kontrakt musi mieć unikalną nazwę
        [OperationContract(Name = "Add")]

        Complex Add(Complex Value1, Complex Value2);
        [OperationContract(Name = "Subtraction")]
        Complex Subtraction(Complex Value1, Complex Value2);
        [OperationContract(Name = "Multiply")]
        Complex Multiply(Complex Value1, Complex Value2);
        [OperationContract(Name = "Division")]
        [FaultContract(typeof(BadValue))]
        Complex Division(Complex Value1, Complex Value2);




        [OperationContract]
        string GetValue(Complex complex);

    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Complex
    {
        double realValue = 0;
        double imagValue = 0;
        [DataMember]
        public double RealValue
        {
            get { return realValue; }
            set { realValue = value; }
        }
        [DataMember]
        public double ImagValue
        {
            get { return imagValue; }
            set { imagValue = value; }
        }

    }

    [DataContract]
    public class DivideByZeroFault
    {
        [DataMember]
        public bool Result { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Description { get; set; }
    }

    [DataContract]
    public class BadValue
    {
        [DataMember]
        public bool Result { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Description { get; set; }
    }

    // TODO: Add your service operations here
}