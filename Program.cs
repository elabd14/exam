using exam.Exams;
using exam.question;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter subject ID:");
            int subjectId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter subject name:");
            string subjectName = Console.ReadLine();

            Subject subject = new Subject(subjectId, subjectName);
            Console.Clear();
            Console.WriteLine("Enter the type of exam (Practical/Final):");
            string examType = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the number of questions for the exam:");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            Exam exam = examType == "practical"
                ? new PracticalExam(DateTime.Now, numberOfQuestions)
                : new FinalExam(DateTime.Now, numberOfQuestions);

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine("Enter question header:");
                string header = Console.ReadLine();

                Console.WriteLine("Enter question body:");
                string body = Console.ReadLine();

                Console.WriteLine("Enter question mark:");
                int mark = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the type of question (TrueOrFalse/MCQ):");
                string questionType = Console.ReadLine().ToLower();

                Question question = questionType == "trueorfalse"
                    ? new TrueFalse(header, body, mark)
                    : new Mcq(header, body, mark);

                Console.WriteLine("Enter the number of answers:");
                int numberOfAnswers = int.Parse(Console.ReadLine());

                question.AnswerList = new Answer[numberOfAnswers];
                for (int j = 0; j < numberOfAnswers; j++)
                {
                    Console.WriteLine("Enter answer ID:");
                    int answerId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter answer text:");
                    string answerText = Console.ReadLine();

                    question.AnswerList[j] = new Answer(answerId, answerText);
                }

                Console.WriteLine("Enter the ID of the right answer:");
                int rightAnswerId = int.Parse(Console.ReadLine());
                question.RightAnswer = Array.Find(question.AnswerList, a => a.AnswerId == rightAnswerId);

                exam.AddQuestion(question);
            }
            Console.Clear(); 
            subject.CreateExam(exam);

            // Start the exam
            exam.StartExam();

            // Show exam details
            exam.ShowExam();

            // End the exam and display the time taken
            exam.EndExam();

            if (exam is PracticalExam practicalExam)
            {
                practicalExam.ShowAnswers();
            }
        }
    }
  }

