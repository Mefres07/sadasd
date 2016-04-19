using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowania
{
    public class Program
    {   
        public static void Main(string[] args)
        {
            List<int> myInts = new List<int>
            {
                1,5,7,9,5,5,7,4,6,9,2,4
            };

            //BubbleSort(myInts);
            LINQSort(ref myInts);

            foreach(int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        public static void BubbleSort(List<int> lista)
        {
            int n = lista.Count-1;

            do
            {
                for (int i = 0; i < n; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        int temp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = temp;
                    }

                }
                n--;
            } while (n > 1);
        }

        public static void LINQSort(ref List<int> lista)
        {
            
            var sorted = from l in lista orderby l select l;

            lista = sorted.ToList<int>();
                                                 
        }
    }
}
