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
    public class Service1 : ICalculator
    {
        public Complex Add(Complex Value1, Complex Value2)
        {
            Complex OutValue = new Complex { RealValue= Value1.RealValue + Value2.RealValue, ImagValue= Value1.ImagValue + Value2.ImagValue };
            return OutValue;
        }
        public Complex Subtraction(Complex Value1, Complex Value2)
        {
            Complex OutValue = new Complex { RealValue = Value1.RealValue - Value2.RealValue, ImagValue = Value1.ImagValue - Value2.ImagValue };
            return OutValue;
        }
        public Complex Multiply(Complex Value1, Complex Value2)
        {
            double r=0, u=0;

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
            if (Value1.ImagValue == 0 || Value2.ImagValue == 0)
            {
                throw SampleMethod(" \n" + Value1.RealValue + "/" + Value2.RealValue + "\n" + Value1.ImagValue + "/" + Value2.ImagValue); ;
            }
            else
            {
                double r, u;
                if ((Value1.ImagValue != 0))
                {
                    r = ((Value1.RealValue * Value2.RealValue) + (Value1.ImagValue * Value2.ImagValue)) / ((Math.Pow(Value2.RealValue, 2) + Math.Pow(Value2.ImagValue, 2)));
                    u = (-(Value1.RealValue * Value2.ImagValue) + (Value1.ImagValue * Value1.RealValue)) / ((Math.Pow(Value2.RealValue, 2) + Math.Pow(Value2.ImagValue, 2)));
                    Complex OutValue2 = new Complex { RealValue = r, ImagValue = u };
                    return OutValue2;
                }
                r = (Value1.RealValue / Value2.RealValue);
                u = (Value1.ImagValue / Value2.RealValue);

                Complex OutValue = new Complex { RealValue = r, ImagValue = u };
                return OutValue;
            }
        }
        
        public Complex Add(double Value1, double Value2, double Value3, double Value4)
        {
            Complex OutValue = new Complex { RealValue = Value1 + Value3, ImagValue = Value2 + Value4 };
            return OutValue;
        }
        public Complex Subtraction(double Value1, double Value2, double Value3, double Value4)
        {
            Complex OutValue = new Complex { RealValue = Value1 - Value3, ImagValue = Value2 - Value4 };
            return OutValue;
        }

        public Complex Multiply(double Value1, double Value2, double Value3, double Value4)
        {
            double r = 0, u = 0;

            if ((Value2 != 0) && Value4 != 0)
            {
                r = (Value1 * Value3) - (Value2 * Value4);
                u = (Value1 * Value4) + (Value2 * Value3);

                Complex OutValue = new Complex { RealValue = r, ImagValue = u };
                return OutValue;
            }

            r = (Value1 * Value3);
            u = (Value1 * Value4) + (Value2 * Value3);

            Complex OutValue2 = new Complex { RealValue = r, ImagValue = u };
            return OutValue2;
        }
        public Complex Division(double Value1, double Value2, double Value3, double Value4)
        {
            double r, u;
            if ((Value2 != 0))
            {
                r = ((Value1 * Value3) + (Value2 * Value4)) / ((Math.Pow(Value3, 2) + Math.Pow(Value4, 2)));
                u = (-(Value1 * Value4) + (Value2 * Value1)) / ((Math.Pow(Value3, 2) + Math.Pow(Value4, 2)));
                Complex OutValue2 = new Complex { RealValue = r, ImagValue = u };
                return OutValue2;
            }
            r = (Value1 / Value3);
            u = (Value2 / Value3);

            Complex OutValue = new Complex { RealValue = r, ImagValue = u };
            return OutValue;
        }
        public string GetValue(Complex complex)
        {
            return complex.RealValue.ToString() + " " + complex.ImagValue.ToString();
        }

        public FaultException SampleMethod(string msg)
        {
                GreetingFault fault = new GreetingFault("Fault Exception");
            return new FaultException<GreetingFault>(fault, new FaultReason("Cant division by 0"+msg));
        }
    }
}
