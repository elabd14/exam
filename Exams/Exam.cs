using exam.question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Exams
{
    public abstract class Exam {
        public DateTime ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; } = new Question[0]; // Initialize with an empty array
        public Subject? AssociatedSubject { get; set; }
        private DateTime _startTime;
        private DateTime _endTime;

        protected Exam(DateTime examTime, int numberOfQuestions)
        {
            ExamTime = examTime;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void ShowExam();

        public Question[] GetQuestions()
        {
            return Questions;
        }

        public void AddQuestion(Question? question)
        {
            if (question == null)
            {
                Console.WriteLine("Cannot add a null question.");
                return;
            }

            if (Questions.Length < NumberOfQuestions)
            {
              
                Question[] newQuestions = new Question[Questions.Length + 1];

             
                for (int i = 0; i < Questions.Length; i++)
                {
                    newQuestions[i] = Questions[i];
                }

              
                newQuestions[Questions.Length] = question;

              
                Questions = newQuestions;
            }
            else
            {
                Console.WriteLine("Cannot add more questions. Exam is full.");
            }
        }

        public void StartExam()
        {
            _startTime = DateTime.Now;
            Console.WriteLine("Exam started at: " + _startTime);
        }

        public void EndExam()
        {
            _endTime = DateTime.Now;
            Console.WriteLine("Exam ended at: " + _endTime);
            TimeSpan timeTaken = _endTime - _startTime;
            Console.WriteLine("Total time taken: " + timeTaken.TotalMinutes + " minutes");
        }
    }
}
