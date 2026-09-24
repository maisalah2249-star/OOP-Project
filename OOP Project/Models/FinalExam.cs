using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Models
{
    public class FinalExam : Exam
    {
        public FinalExam()
        {
        }

        public FinalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            int grade = 0;

            Console.WriteLine("=================================");
            Console.WriteLine("          FINAL EXAM");
            Console.WriteLine("=================================");

            Console.WriteLine($"Time: {Time} minutes");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            Console.WriteLine();

            for (int i = 0; i < Questions.Length; i++)
            {
                Question question = Questions[i];

                Console.WriteLine($"Question {i + 1}:");
                Console.WriteLine(question.Body);

                foreach (Answer answer in question.AnswerList)
                {
                    Console.WriteLine(answer);
                }

                Console.Write("Your Answer: ");
                int userAnswerId = int.Parse(Console.ReadLine()!);

                if (userAnswerId == question.RightAnswer.AnswerId)
                {
                    grade += question.Mark;
                }

                Console.WriteLine();
            }

            Console.WriteLine("=================================");
            Console.WriteLine($"Your Grade: {grade}");
            Console.WriteLine("=================================");
        }
    }
}
