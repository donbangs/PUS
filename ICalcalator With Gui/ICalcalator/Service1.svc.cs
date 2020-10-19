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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ICalculator
    {
        public string Add(Complex Value1, Complex Value2)
        {
            Complex OutValue = new Complex { RealValue= Value1.RealValue + Value2.RealValue, ImagValue= Value1.ImagValue + Value2.ImagValue };
            return OutValue.GetValue;
        }
        public string Subtraction(Complex Value1, Complex Value2)
        {
            Complex OutValue = new Complex { RealValue = Value1.RealValue - Value2.RealValue, ImagValue = Value1.ImagValue - Value2.ImagValue };
            return OutValue.GetValue;
        }
     
        public string Multiply(Complex Value1, Complex Value2)
        {
            double r=0, u=0;

            if ((Value1.ImagValue != 0) && Value2.ImagValue != 0)
            {
                r = (Value1.RealValue * Value2.RealValue) - (Value1.ImagValue * Value2.ImagValue);
                u = (Value1.RealValue * Value2.ImagValue) + (Value1.ImagValue * Value2.RealValue);

                Complex OutValue = new Complex { RealValue = r, ImagValue = u };
                return OutValue.GetValue;
            }

            r = (Value1.RealValue * Value2.RealValue);
            u = (Value1.RealValue * Value2.ImagValue) + (Value1.ImagValue * Value2.RealValue);

            Complex OutValue2 = new Complex { RealValue = r, ImagValue = u };
            return OutValue2.GetValue;
        }
        public string Division(Complex Value1, Complex Value2)
        {
            double r, u;
            if ((Value1.ImagValue != 0))
            {
                r = ((Value1.RealValue * Value2.RealValue) + (Value1.ImagValue * Value2.ImagValue)) / ((Math.Pow(Value2.RealValue, 2) + Math.Pow(Value2.ImagValue, 2)));
                u = (-(Value1.RealValue * Value2.ImagValue) + (Value1.ImagValue * Value1.RealValue)) / ((Math.Pow(Value2.RealValue, 2) + Math.Pow(Value2.ImagValue, 2)));
                Complex OutValue2 = new Complex { RealValue = r, ImagValue = u };
                return OutValue2.GetValue;
            }
            r = (Value1.RealValue / Value2.RealValue);
            u = (Value1.ImagValue / Value2.RealValue);

            Complex OutValue = new Complex { RealValue = r, ImagValue = u };
            return OutValue.GetValue;
        }
        public string Add(double Value1, double Value2, double Value3, double Value4)
        {
            Complex OutValue = new Complex { RealValue = Value1 + Value3, ImagValue = Value2 + Value4 };
            return OutValue.GetValue;
        }
        public string Subtraction(double Value1, double Value2, double Value3, double Value4)
        {
            Complex OutValue = new Complex { RealValue = Value1 - Value3, ImagValue = Value2 - Value4 };
            return OutValue.GetValue;
        }

        public string Multiply(double Value1, double Value2, double Value3, double Value4)
        {
            double r = 0, u = 0;

            if ((Value2 != 0) && Value4 != 0)
            {
                r = (Value1 * Value3) - (Value2 * Value4);
                u = (Value1 * Value4) + (Value2 * Value3);

                Complex OutValue = new Complex { RealValue = r, ImagValue = u };
                return OutValue.GetValue;
            }

            r = (Value1 * Value3);
            u = (Value1 * Value4) + (Value2 * Value3);

            Complex OutValue2 = new Complex { RealValue = r, ImagValue = u };
            return OutValue2.GetValue;
        }
        public string Division(double Value1, double Value2, double Value3, double Value4)
        {
            double r, u;
            if ((Value2 != 0))
            {
                r = ((Value1 * Value3) + (Value2 * Value4)) / ((Math.Pow(Value3, 2) + Math.Pow(Value4, 2)));
                u = (-(Value1 * Value4) + (Value2 * Value1)) / ((Math.Pow(Value3, 2) + Math.Pow(Value4, 2)));
                Complex OutValue2 = new Complex { RealValue = r, ImagValue = u };
                return OutValue2.GetValue;
            }
            r = (Value1 / Value3);
            u = (Value2 / Value3);

            Complex OutValue = new Complex { RealValue = r, ImagValue = u };
            return OutValue.GetValue;
        }
        public async Task AsyncAdd(Complex Value1,Complex Value2)
        {
           await  Task.Factory.StartNew(() => {
               Complex OutValue = new Complex { RealValue = Value1.RealValue + Value2.RealValue, ImagValue = Value1.ImagValue + Value2.ImagValue };
               return OutValue.GetValue;
           });
            
        }
    }
}
