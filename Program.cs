using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoutNumberSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int sheetNumber = 1000;
            List<int> lst = new List<int>();

            for (int i = 0; i < sheetNumber; i++)
            {
                int count = lst.Count;
                if (count == 0)
                    lst.Add(0);
                else
                {
                    for (int j = 0; j < count; j++)
                    {
                        if (lst[j] < 25)
                        {
                            lst[j]++;
                            break;
                        }
                        else
                        {
                            lst[j] = 0;
                            if (j == count - 1)
                                lst.Add(0);
                        }
                    }
                }
                int k = i % 26;
                string s = string.Empty;
                
                foreach (int item in lst.AsEnumerable().Reverse())
                {
                    s += alpha[item];
                }
                Console.WriteLine(i.ToString() + "_" + s);

            }
            Console.ReadLine();
        }


    }
}
