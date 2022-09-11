using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, p;
            int[,] aar1 = new int[10, 10];
            int de = 0;
            Console.Write("\n The determinat of 3 by 3 matrix\n");
            Console.Write("++++++++++++++++++++++++++++++++++++++++");

            Console.Write(" Enter the element of the arrary\n");
            for (k = 0; k < 3; k++) 
            {
                for (p=0; p < 3; p++)

                {
                    Console.Write(" the element[{0}], [{1}]:", k, p);
                    try
                    {
                        aar1[k, p] = Convert.ToInt32(Console.ReadLine());

                    } catch(Exception e)
                    {
                        Console.Write(" You have not entered a valid number, try again to continue :\n");
                        break;
                    }
                }

            }
            Console.Write(" the matrix is started below :\n");
            

 for(k=0; k<3; k++)
                {

                    for (p = 0;p<3;p++)
                        Console.Write("{0}", aar1[k, p]);
                    Console.Write("\n");

                }
                for (k = 0; k < 3; k++)
                {
                    de=de + (aar1[0, k] * (aar1[1, (k + 1) % 3] * aar1[2, (k + 2) % 3] - aar1[1, (k + 2) % 3] * aar1[2, (k + 1) % 3]));
                    Console.Write("\n\n  determinant of 3 x 3 matrix is {0}\n\n" , de);
                }
                Console.ReadLine();

            }

        }
        
    }

