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


            int counter = 0,template_len=0;
            string data_txt = "aa", template_txt = "cc";
            string[] data_list = { };
            List<string> template_txt_copy = new List<string>();
            //List<string> result_txt = new List<string>();
            char[] delimiterChars = { '\t' };//' ', ',', '.', ':', 
            data_list = new string[] { template_txt };
            System.IO.StreamReader template_file = new System.IO.StreamReader("C:/Users/Albert/Desktop/敏捷軟體/Git/CSharp/vs2013-csharp-sample/DocMerge/template.txt");
            counter = 0;
            while ((template_txt = template_file.ReadLine()) != null)
            {
                //Console.WriteLine(template_txt);
                template_txt_copy.Add(template_txt);
                counter++;
            }
            template_len = counter;
            //Console.WriteLine(template_len);
            template_file.Close();

            /*foreach (string s in result_txt)
                Console.WriteLine(s);*/


            System.IO.StreamReader data_file = new System.IO.StreamReader("C:/Users/Albert/Desktop/敏捷軟體/Git/CSharp/vs2013-csharp-sample/DocMerge/data.txt");
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:/Users/Albert/Desktop/敏捷軟體/Git/CSharp/vs2013-csharp-sample/DocMerge/result.txt");

            counter = 0;
            data_txt = data_file.ReadLine();
            while ((data_txt = data_file.ReadLine()) != null)
            {
                //Console.WriteLine(data_txt);
                data_list = data_txt.Split(delimiterChars);
                string[] result_txt = new string[template_len];
                for (int i = 0; i < template_len; i++)
                    result_txt[i] = template_txt_copy[i];
                for (int i = 0; i < template_len; i++)
                { 
                    result_txt[i] = result_txt[i].Replace("${中文姓名}", data_list[0]);
                    result_txt[i] = result_txt[i].Replace("${身份證字號}", data_list[1]);
                    result_txt[i] = result_txt[i].Replace("${年數}", data_list[2]);
                }
                //foreach (string s in result_txt)
                //    Console.WriteLine(s);
                for (int i = 0; i < template_len; i++)
                {
                    file.WriteLine(result_txt[i]);
                    Console.WriteLine(result_txt[i]);
                }
                counter++;
            }
            data_file.Close();
                file.Close();



            //foreach (string s in data_list)
            //    Console.WriteLine(s);
            //string  aa ;
            //    aa= "aaaaaaaajifahgoah" ;
            //aa=aa.Replace("aa", "i");
            //Console.WriteLine(aa);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
    
}

