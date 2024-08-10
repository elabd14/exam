using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Exams
{
    internal class FinalExam : Exam
    {

        public FinalExam(DateTime examTime, int numberOfQuestions)
            : base(examTime, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam:");
            foreach (var question in Questions)
            {
                question.ShowQuestion();
                Console.WriteLine("Answers:");
                foreach (var answer in question.AnswerList)
                {
                    Console.WriteLine(answer);
                }
            }

            int score = CalculateGrade();
            Console.WriteLine($"Grade: {score}/{NumberOfQuestions}");
        }

        private int CalculateGrade()
        {
            int correctAnswers = 0;
            foreach (var question in Questions)
            {
                Console.WriteLine($"For question '{question.Header}', enter your answer ID:");
                int userAnswerId = int.Parse(Console.ReadLine());

                if (question.RightAnswer != null && userAnswerId == question.RightAnswer.AnswerId)
                {
                    correctAnswers++;
                }
            }
            return correctAnswers;
        }
    }
}

