using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.question
{
    internal class TrueFalse : Question
    {
        public TrueFalse(string header, string body, int mark) : base(header, body, mark)
        {
        }

     \

        public override void ShowQuestion()
        {
            Console.WriteLine($"MCQ Question: {Header}");
            Console.WriteLine($"{Body}");
            foreach (var answer in AnswerList)
            {
                Console.WriteLine(answer);
            }

        }
    }
}
