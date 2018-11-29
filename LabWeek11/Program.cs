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

              string[] months = new string[12];
                months[0] = "January";
                months[1] = "February";
                months[2] = "March";
                months[3] = "April";
                months[4] = "May";
                months[5] = "June";
                months[6] = "July";
                months[7] = "August";
                months[8] = "September";
                months[9] = "October";
                months[10] = "November";
                months[11] = "December";
           
         
                    for (int i = 0; i < months.Length; i++)
                    {
                    Console.WriteLine((i + 1) + " " + months[i]);
                    }
                
         Console.ReadLine();
                                

            //#3

            string[] seasons = {"Spring", "Summer", "Fall", "Winter"};
           

            foreach (string value in seasons)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();

            //#4

            int[] randomNumber = new int[1000];
            Random random = new Random();

            for (int z = 0; z < randomNumber.Length; z++)
            {
                randomNumber[z] = random.Next(0, 1000);
            }

            foreach (int a in randomNumber)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}
