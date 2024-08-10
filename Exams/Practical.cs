using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Exams
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(DateTime examTime, int numberOfQuestions)
         : base(examTime, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam:");
            foreach (var question in Questions)
            {
                question.ShowQuestion();
            }
        }

        public void ShowAnswers()
        {
            Console.WriteLine("Showing right answers for the Practical Exam:");
            foreach (var question in Questions)
            {
                Console.WriteLine(question.Header);
                foreach (var answer in question.AnswerList)
                {
                    if (answer == question.RightAnswer)
                    {
                        Console.WriteLine($"Correct Answer: {answer}");
                    }
                }
            }
        }
    }
}
