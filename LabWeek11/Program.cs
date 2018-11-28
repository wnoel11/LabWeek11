using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWeek11
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            Console.WriteLine(names[2]);
            Console.WriteLine(names[4]);

            Console.ReadLine();

            //#2

              string[] month = new string[12];
                month[0] = "January";
                month[1] = "February";
                month[2] = "March";
                month[3] = "April";
                month[4] = "May";
                month[5] = "June";
                month[6] = "July";
                month[7] = "August";
                month[8] = "September";
                month[9] = "October";
                month[10] = "November";
                month[11] = "December";
           
         
                    for (int i = 0; i < month.Length; i++)
                    {
                    Console.WriteLine(i.ToString() + month[i]);
                    }
                
             
            Console.ReadLine();
                                

            //#3

            string[] seasons = {"Spring", "Summer", "Fall", "Winter"};
            int y = 0;

            for (y = 0; y < seasons.Length; y++)
            {
                Console.WriteLine(seasons[y]);
            }

            Console.ReadLine();

            //#4

            int[] randomNumber = new int[1000];
            Random random = new Random();

            for (int z = 0; z < randomNumber.Length; z++)
            {
                randomNumber[z] = random.Next(0, 100);
            }

            foreach (int z in randomNumber)
            {
                Console.WriteLine(z.ToString());
            }
        }
    }
}
