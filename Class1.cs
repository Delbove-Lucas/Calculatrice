using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class Class1
    {
        public static double DoOperation(double num1, double num2, string op){
            double resultat = double.NaN;
            
            switch (op)
            {
                case "a":
                    resultat = num1 + num2;
                    break;
                case "s":
                    resultat = num1 - num2;
                    break;
                case "m":
                    resultat = num1 * num2;
                    break ;
                case "d": 
                    if(num2 != 0)
                            {
                        resultat = num1 / num2;
                    }
                    break ;
            }
            return resultat;
        }

    }
}
