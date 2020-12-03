using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Complex Add(Complex Value1, Complex Value2)
        {
            try
            {
                Complex OutValue = new Complex { RealValue = Value1.RealValue + Value2.RealValue, ImagValue = Value1.ImagValue + Value2.ImagValue };
                return OutValue;
            }
            catch (Exception e)
            {

                throw new FaultException(e.Message);
            }
        }
        public Complex Subtraction(Complex Value1, Complex Value2)
        {
            Complex OutValue = new Complex { RealValue = Value1.RealValue - Value2.RealValue, ImagValue = Value1.ImagValue - Value2.ImagValue };
            return OutValue;
        }

        public Complex Multiply(Complex Value1, Complex Value2)
        {
            double r = 0, u = 0;

            if ((Value1.ImagValue != 0) && Value2.ImagValue != 0)
            {
                r = (Value1.RealValue * Value2.RealValue) - (Value1.ImagValue * Value2.ImagValue);
                u = (Value1.RealValue * Value2.ImagValue) + (Value1.ImagValue * Value2.RealValue);

                Complex OutValue = new Complex { RealValue = r, ImagValue = u };
                return OutValue;
            }

            r = (Value1.RealValue * Value2.RealValue);
            u = (Value1.RealValue * Value2.ImagValue) + (Value1.ImagValue * Value2.RealValue);

            Complex OutValue2 = new Complex { RealValue = r, ImagValue = u };
            return OutValue2;
        }
        public Complex Division(Complex Value1, Complex Value2)
        {

            double r = 0;
            double u = 0;

            try
            {

                if ((Value1.ImagValue != 0))
                {
                    r = ((Value1.RealValue * Value2.RealValue) + (Value1.ImagValue * Value2.ImagValue)) / ((Math.Pow(Value2.RealValue, 2) + Math.Pow(Value2.ImagValue, 2)));
                    u = (-(Value1.RealValue * Value2.ImagValue) + (Value1.ImagValue * Value1.RealValue)) / ((Math.Pow(Value2.RealValue, 2) + Math.Pow(Value2.ImagValue, 2)));
                    Complex OutValue2 = new Complex { RealValue = r, ImagValue = u };
                    return OutValue2;
                }
                r = (Value1.RealValue / Value2.RealValue);
                u = (Value1.ImagValue / Value2.RealValue);


            }
            catch (Exception ex)
            {
                BadValue fault2 = new BadValue();

                fault2.Result = false;
                fault2.Message = ex.Message;
                fault2.Description = "Zły format liczb. ";

                throw new FaultException<BadValue>(fault2);

            }
            Complex OutValue = new Complex { RealValue = r, ImagValue = u };
            return OutValue;

        }

        public string GetValue(Complex complex)
        {
            return complex.RealValue.ToString() + " " + complex.ImagValue.ToString();
        }
    }
}
