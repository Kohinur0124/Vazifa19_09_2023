using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vazifa19_09_2023.Service;

namespace Vazifa19_09_2023
{
    public class Test
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public string TestDescription { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }

        public string CorrectAnswer { get; set; }


        public Test( string subject,string testDescription,string a,string b,string c,string d,string correctAnswer)
        {
            Id = Guid.NewGuid();
            SubjectName = subject;
            TestDescription = testDescription;
            A = a;
            B = b;
            C = c;
            D = d;
            CorrectAnswer = correctAnswer;
            if (FileWriter.WriteNewTest(this))
            {
                Console.WriteLine("Test qo`shildi !!!");
            }
            else
            {
                Console.WriteLine("Test qo`shishda Xatolik !!!");
            }

        }

        public override string ToString()
        {
            return $"{Id}%%{SubjectName}%%{TestDescription}%%{A}%%{B}%%{C}%%{D}%%{CorrectAnswer}";

        }

    }
}
