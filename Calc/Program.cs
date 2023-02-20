using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {

        interface ICalc
        {
            int Less(int valueToCompare);
            int Greater(int valueToCompare);

        }


        class Array : ICalc
        {
            List<int> list;

            public Array() { 
                list = new List<int>(); 
                Random random = new Random();

                for (int i = 0; i < random.Next(10,20); i++)
                {
                    list.Add(random.Next(1, 100));
                }
            }

            public int Greater(int valueToCompare)
            {
                int greater = 0;

                for (int i = 0; i < list.Count; i++)
                {

                    if (list[i]>valueToCompare)
                    {
                        greater++;
                    }
                    
                }

                return greater;
            }

            public int Less(int valueToCompare)
            {
                int less = 0;

                for (int i = 0; i < list.Count; i++)
                {

                    if (list[i] < valueToCompare)
                    {
                        less++;
                    }

                }

                return less;
            }


            public void Print()
            {

                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i]+" ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {

            int less = 20;
            int greater = less;

            Array array = new Array();
            array.Print();

            Console.WriteLine($"чисел меньше за {less} = {array.Less(less)}");
            Console.WriteLine($"чисел меньше за {greater} = {array.Greater(greater)}");

            Console.ReadLine();
        }
    }
}
