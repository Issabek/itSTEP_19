using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace itSTEP_19
{
    public class tasks
    {
        public static async void task1()
        {
            using (StreamReader s = new StreamReader(@"fibonacci.txt"))
            {
                List<string> fibbs = s.ReadLine().Split(' ').ToList() ;
                int a, b;
                for(int i = 0; i < fibbs.Count; i++)
                {
                    a = fibbs.Count - 1;
                    b = fibbs.Count - 2;
                    fibbs.Add((a + b).ToString());
                }
                await File.WriteAllLinesAsync("WriteLines.txt", fibbs);
            }
        }
        public static async void task2()
        {
            using (StreamReader s = new StreamReader(@"twonums.txt"))
            {
                string a = s.ReadLine().Split(' ')[0];
                string b = s.ReadLine().Split(' ')[1];
                string c = "";
                int reminder = 0;
                if (a.Length < b.Length)
                {
                    string t = a;
                    a = b;
                    b = t ;
                }
                for(int i = b.Count()-1; i >= 0; i--)
                {
                    int sum = ((int)(a[i] - '0') +
                                    (int)(b[i] - '0') + reminder);
                    c += (char)(sum % 10 + '0');

                    reminder = sum / 10;
                }
                await File.WriteAllTextAsync("resnums.txt", c);
            }
        }
        public static void task3()
        {
            byte[] s=File.ReadAllBytes(@"/Users/sensei.rin/Desktop/itstep.txt");
            Dictionary<byte, int> myDict = new Dictionary<byte, int>();
            foreach(byte b in s)
            {
                if (!myDict.ContainsKey(b))
                    myDict.Add(b, 1);
                else
                    myDict[b] += 1;
            }
        }
        public static void task4()
        {
            string s = Console.ReadLine();
            File.AppendAllText(@"mytext.txt", "\n"+s);
        }
    }
}
