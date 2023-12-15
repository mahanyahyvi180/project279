using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp141
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch (Exception exceptionParameter)
            {
                Console.WriteLine("exceptionParameter.ToString:\n" + exceptionParameter);
                Console.WriteLine("exceptionParameter.Message:\n" + exceptionParameter.Message);
                Console.WriteLine("exceptionParameter.StackTrace:\n" + exceptionParameter.StackTrace);
                Console.WriteLine("exceptionParameter.innerException\n" + exceptionParameter.InnerException);
                Console.ReadLine();
            }
        }
        static void Method1()
        {
            Method2();
        }
        static void Method2()
        {
            Method3();
        }
        static void Method3()
        {
            try
            {
                int.Parse("int not to press");
            }
            catch (FormatException formatExceptionParameter)
            {
                throw new Exception ("Exception",formatExceptionParameter);
            }
            Console.ReadLine();

        }
    }
    }
