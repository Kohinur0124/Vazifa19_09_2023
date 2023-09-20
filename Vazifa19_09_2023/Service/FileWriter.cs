using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Vazifa19_09_2023.Service
{
    public static class FileWriter
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n >= 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static bool WriteNewTest(Test test)
        {
            try 
            { 
                using (StreamWriter streamWriter = new StreamWriter("Test.txt",append:true))
                {
                    streamWriter.WriteLineAsync(test.ToString());
                };
                return true;
            
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private static List<string> CountTestBySubjectName(string subjectName)
        {
            string readText = File.ReadAllText("Test.txt");
            var strings = readText.Split('\n').ToList();

            var lst= new List<string>();
            for (int i = 0;i<strings.Count-1;i++)
            {
                string[] strings1 = strings[i].Split("%%");
                if (strings1[1].Equals(subjectName))
                {
                    lst.Add(strings[i]);
                }
            }
            return lst;

        }

        public static void Generatsion(string SubjectName,int countStudent,int countTest)
        {
            var s = CountTestBySubjectName(SubjectName);
            if (s.Count >= countStudent * countTest)
            {
                s.Shuffle<string>();
                int ij = 0;
                for(int i = 0; i < countStudent; i++)
                {
                    using (StreamWriter streamWriter = new StreamWriter($"D:\\Bootcamp\\Vazifa19_09_2023\\Student{i+1}.txt"))
                    {

                        streamWriter.WriteLine($"Fan : {SubjectName}             Testlar soni : {countTest}");


                        for (int j = 0; j < countTest; j++)
                        {
                            string[] s1 = s[ij++].Split("%%");
                            streamWriter.WriteLine($"{j+1} .  {s1[2]}");
                            streamWriter.WriteLine($" A ) {s1[3]}\n B ) {s1[4]}\n C ) {s1[5]}\n D ) {s1[6]}\nTog`ri javob : {s1[7]}");
                        }
                    };

                   
                }
                 Console.WriteLine("File yozish yakunlandi ");

            }
            else
            {
                Console.WriteLine("Testlar soni yetarli emas !");
            }
            

        }
    }
}
