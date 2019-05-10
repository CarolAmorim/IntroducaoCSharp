using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenando String ultima aula
            //
            string s1 = "one";

            string s2 = "one";
            s2 += ",two";
            s2 += ",three";

            // Concatenando
            //
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("onye");
            sb.Append(",two");
            sb.Append(",Three");

            // s2.EndsWith("ree");  reorna boolean -  true
            // s2.Equals("");
            // s2.IndexOf("two");
            // sb.ToString().IndexOf("two");
            // s2 = s2.Insert(4, "OK,");
            // s2.Length;
            // s2.Remove(4, 3); //a partir da posição 4 remove 3 caracteres
            // s2.Replace("two", "one");
            // string []s3 = s2.Split(',');
            Console.WriteLine(s2.Replace("two", "one"));

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}
