using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Model
    {
        
        public double Sum(int a, int b)
        {
            double sum;
            try
            {
                checked
                {
                    sum = a + b;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
            return sum;
        }
        public double Sub(int a, int b)
        {
            double sbtract;
            try
            {
                checked
                {
                    sbtract = a - b;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
            return sbtract;
        }
        public double Mul(int a, int b)
        {
            double multiply;
            try
            {
                checked
                {
                    multiply = a * b;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
            return multiply;
        }
        public double Div(int a, int b)
        {
            double div;
            try
            {
                checked
                {
                    div = a / b;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
            return div;
        }
    }
}
