using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ICalcalator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        // Wcf nie wspiera przeciążonych metod każdy kontrakt musi mieć unikalną nazwę
        [OperationContract(Name = "AsyncAdd")]
        Task AsyncAdd(Complex Value1, Complex Value2);
        [OperationContract (Name = "Add")]
        String Add(Complex Value1,Complex Value2);
        [OperationContract(Name = "Subtraction")]
        String Subtraction(Complex Value1, Complex Value2);
        [OperationContract(Name = "Multiply")]
        String Multiply(Complex Value1, Complex Value2);
        [OperationContract(Name = "Division")]
        String Division(Complex Value1, Complex Value2);
        [OperationContract(Name = "Add2")]
        String Add(double Value1, double Value2, double Value3, double Value4);
        [OperationContract(Name = "Subtraction2")]
        String Subtraction(double Value1, double Value2, double Value3, double Value4);
        [OperationContract (Name = "Multiply2")]
        String Multiply(double Value1, double Value2, double Value3, double Value4);
        [OperationContract(Name = "Division2")]
        String Division(double Value1, double Value2, double Value3, double Value4);
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Complex
    {
        double realValue=0;
        double imagValue=0;
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
        public string GetValue { 
            get { return RealValue.ToString() + " " + ImagValue.ToString();}
        }
    }
}
