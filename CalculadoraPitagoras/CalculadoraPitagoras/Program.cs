using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPitagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Char opcion;
            String continuar;            

            do
            {                
                Console.WriteLine("|**********************************************************|");
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|*               Calculadora General                      *|");
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|*           1.-Suma de dos números           (x + y)     *|");
                Console.WriteLine("|*           2.-Resta de dos números          (x - y)     *|");
                Console.WriteLine("|*           3.-Multiplicación de dos números (x * y)     *|");
                Console.WriteLine("|*           4.-División de dos números       (x / y)     *|");
                Console.WriteLine("|*           5.-Todas las operaciones                     *|");
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|*              Teorema de Pitágoras                      *|");
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|*           6.-Calcular cateto A                         *|");
                Console.WriteLine("|*           7.-Calcular cateto B                         *|");
                Console.WriteLine("|*           8.-Calcular hipotenusa C                     *|");
                Console.WriteLine("|*                                                        *|");                
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|*           0.-Salir                                     *|");
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|**********************************************************|");
                Console.Write("\n");
                Console.Write("Dime una opción: ");

                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                }
                while (opcion < '0' || opcion > '8');



                switch (opcion)
                {
                    case '0':
                        {
                            Environment.Exit(0);
                        }
                        break;

                    case '1':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");


                            Console.Write("Ingrese primer número  (x): ");
                            double x = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double y = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp();

                            Console.WriteLine("El resultado de la suma es: " + op.Opsuma(x, y).ToString());

                        }
                        break;
                    case '2':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double x = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double y = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp();

                            Console.WriteLine("El resultado de la resta es: " + op.Opresta(x, y).ToString());

                        }
                        break;
                    case '3':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double x = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double y = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp();

                            Console.WriteLine("El resultado de la multiplicación es: " + op.Opmultiplicar(x, y).ToString());

                        }
                        break;
                    case '4':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double x = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double y = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp();

                            Console.WriteLine("El resultado de la división es: " + op.Opdividir(x, y).ToString());

                        }
                        break;
                    case '5':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double x = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double y = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp();

                            Console.WriteLine("El resultado de la suma es           : " + op.Opsuma(x, y).ToString());
                            Console.WriteLine("El resultado de la resta es          : " + op.Opresta(x, y).ToString());
                            Console.WriteLine("El resultado de la multiplicación es : " + op.Opmultiplicar(x, y).ToString());
                            Console.WriteLine("El resultado de la división es       : " + op.Opdividir(x, y).ToString());

                        }
                        break;
                    case '6':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese cateto B: ");
                            double b = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese hipotenusa C: ");
                            double c = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp();

                            Console.WriteLine("El lado a mide: " + op.CalcularA(b, c).ToString());
                        }
                        break;
                    case '7':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese cateto A: ");
                            double a = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese hipotenusa C: ");
                            double c = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp();

                            Console.WriteLine("El lado b mide: " + op.CalcularB(a, c).ToString());
                        }
                        break;
                    case '8':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese Cateto A: ");
                            double a = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese Cateto B: ");
                            double b = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp();

                            Console.WriteLine("El lado c mide: " + op.CalcularC(a, b).ToString());
                        }
                        break;
                }

                Console.WriteLine("-------------------------------");
                Console.Write("¿Deseas continuar? y/n: ");
                continuar = Console.ReadLine();
                Console.WriteLine("\n");
                Console.Clear();
            }
            while (continuar != "n");

        }
    }
}
