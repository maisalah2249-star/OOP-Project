using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Models
{
    public class PracticalExam : Exam
    {
        public PracticalExam()
        {
        }

        public PracticalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("        PRACTICAL EXAM");
            Console.WriteLine("=================================");

            Console.WriteLine($"Time: {Time} minutes");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            Console.WriteLine();

            int[] userAnswers = new int[Questions.Length];

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
                userAnswers[i] = int.Parse(Console.ReadLine()!);

                Console.WriteLine();
            }

            Console.WriteLine("=================================");
            Console.WriteLine("       CORRECT ANSWERS");
            Console.WriteLine("=================================");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(
                    $"Question {i + 1}: {Questions[i].RightAnswer}"
                );
            }
        }
    }
}
