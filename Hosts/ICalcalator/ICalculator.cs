using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ICalcalator
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface ICalculator
    {
        [OperationContract (Name = "Add")]
        Complex Add(Complex Value1,Complex Value2);
        [OperationContract(Name = "Subtraction")]
        Complex Subtraction(Complex Value1, Complex Value2);
        [OperationContract(Name = "Multiply")]
        Complex Multiply(Complex Value1, Complex Value2);
        [OperationContract(Name = "Division")]
        Complex Division(Complex Value1, Complex Value2);
        [OperationContract(Name = "Add2")]
        Complex Add(double Value1, double Value2, double Value3, double Value4);
        [OperationContract(Name = "Subtraction2")]
        Complex Subtraction(double Value1, double Value2, double Value3, double Value4);
        [OperationContract (Name = "Multiply2")]
        Complex Multiply(double Value1, double Value2, double Value3, double Value4);
        [OperationContract(Name = "Division2")]
        Complex Division(double Value1, double Value2, double Value3, double Value4);
        [OperationContract]
        string GetValue(Complex complex);

        [OperationContract]
        [FaultContractAttribute( typeof(GreetingFault),Action = "http://www.contoso.com/GreetingFault",ProtectionLevel = ProtectionLevel.None)]
        FaultException SampleMethod(string msg);
    }

    [DataContract]
    public class GreetingFault
    {
        public string Info { get; set; }
        public GreetingFault(string  info)
        {
            Info = info;
        }
    }
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
    }
}
