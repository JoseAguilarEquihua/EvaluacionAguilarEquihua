using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPitagoras
{
    public class ClassOp
    {

        public ClassOp() 
        {           
        }

        public double Opsuma(double x, double y) 
        {
            return x + y;
        }

        public double Opresta(double x, double y) 
        {
            return x - y;
        }

        public double Opmultiplicar(double x, double y) 
        {
            return x * y;
        }

        public double Opdividir(double x, double y) 
        {
            return x / y;
        }

        public double CalcularA(double b, double c)
        {
            if (b > 0 && c > 0)
            {
                if(c > b)
                {
                    return Math.Round(Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2)), 3);
                } else
                {
                    throw new ArgumentOutOfRangeException();
                }
                
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public double CalcularC(double a, double b)
        {           
            if( a > 0 && b > 0)
            {
                return Math.Round(Math.Sqrt( Math.Pow(a, 2) + Math.Pow(b, 2)), 3);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        

        public double CalcularB(double a, double c)
        {
            if (a > 0 && c > 0)
            {
                if (c > a)
                {
                    return Math.Round(Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2)), 3);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }                
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}
