using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lesson7Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //дана произвольная коллекция List<T>.Сколько раз встречается каждый элемнт в данной коллекции

            List<int> intList = new List<int>() { 6, 5, 4, 6, 3, 2, 12, 100, 100, 52, 3, 6, 99, 12 };

            Dictionary<int, int> intSpesial = new Dictionary<int, int>();
            
            foreach (int i in intList)
            {
                if (intSpesial.ContainsKey(i))
                {
                    intSpesial[i]++;
                }
                else
                {
                    intSpesial[i] = 1;
                }
            }

            foreach(KeyValuePair<int, int> x in intSpesial)
            {
                Console.WriteLine($"Элемент {x.Key}  встречается {x.Value} раз");
            }

            

        }
    }
}
