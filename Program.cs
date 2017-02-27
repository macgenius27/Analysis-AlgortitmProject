using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AoaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader obj = File.OpenText(@"D://aoa.txt");
            string totalVertics = obj.ReadLine();

            int numOfVertics = int.Parse(totalVertics);
            string[] edges = new string[numOfVertics];
            for (int i = 0; i < numOfVertics; i++)
            {
                edges[i] = obj.ReadLine();
            }
            foreach (string i in edges)
            {
                Console.WriteLine(i);
            }
            int[,] Matrics = new int[numOfVertics, numOfVertics];
            for (int i = 0; i < edges.Length; i++)
            {
                string temp=edges[i];
                string [] array = temp.Split(',');
                for (int j = 0; j < numOfVertics; j++)
                {
                   // string [] each = edges[j].Split(',');
                   // int s = int.Parse(array[]);
                    Matrics[i, j] =int.Parse( array[j]);
                }
            }
            foreach (int i in Matrics)
            {
                Console.WriteLine(i);
        }
            Console.ReadLine();
        }
    }
}
