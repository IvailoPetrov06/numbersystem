using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Изберете опция: ");
            Console.WriteLine("1. Преобразуване от десетична бройна система в друга ");
            Console.WriteLine("2. Преобразуване от друга бройна система в десетична ");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Въведете число: ");
            string number = Console.ReadLine();

            Console.Write("Въведете бройна система (2-16): ");
            int baseSystem = int.Parse(Console.ReadLine());

            if (baseSystem < 2 || baseSystem > 16)
            {
                Console.WriteLine("Невалидна бройна система.");
                return;
            }

            if (choice == 1)
            {
                int decimalNumber = int.Parse(number);
                string result = Convert.ToString(decimalNumber, baseSystem);
                Console.WriteLine($"Числото в бройна система {baseSystem} е: {result.ToUpper()}");
            }
            else if (choice == 2)
            {
                try
                {
                    int decimalNumber = Convert.ToInt32(number, baseSystem);
                    Console.WriteLine($"Числото в десетична бройна система е: {decimalNumber}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Грешка при преобразуването: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Невалидна опция.");
            }
        }
    }
}
