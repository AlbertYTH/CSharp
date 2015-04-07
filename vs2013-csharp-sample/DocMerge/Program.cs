using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocMerge
{
    class Program
    {
        static void Main(string[] args)
        {


            int counter = 0;
            string line;
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            //string[] words = text.Split(delimiterChars);
            System.IO.StreamReader file = new System.IO.StreamReader("C:/Users/Albert/Desktop/敏捷軟體/Git/CSharp/vs2013-csharp-sample/DocMerge/data.txt");
            while((line = file.ReadLine()) != null)
            {
               Console.WriteLine (line);
               counter++;
            }

            file.Close();
            System.IO.StreamReader file2 = new System.IO.StreamReader("C:/Users/Albert/Desktop/敏捷軟體/Git/CSharp/vs2013-csharp-sample/DocMerge/template.txt");
            while ((line = file2.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }

            file.Close();
            Console.ReadLine();
            
            
            /*System.Console.WriteLine("{0} words in text:", words.Length);

            foreach (string s in words)
            {
                System.Console.WriteLine(s);
            }*/

        }
    }
    
}

