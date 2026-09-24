using OOP_Project.Models;

namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // Create Subject
            // ==========================================

            Subject subject = new Subject(1, "C# Programming");

            // ==========================================
            // Create Answers
            // ==========================================

            Answer[] answers1 =
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };

            Answer[] answers2 =
            {
                new Answer(1, "C#"),
                new Answer(2, "Java"),
                new Answer(3, "Python"),
                new Answer(4, "C++")
            };

            // ==========================================
            // Create Questions
            // ==========================================

            TrueFalseQuestion question1 =
                new TrueFalseQuestion(
                    "True or False",
                    "C# is an object-oriented programming language.",
                    5,
                    answers1,
                    answers1[0]
                );

            MCQQuestion question2 =
                new MCQQuestion(
                    "MCQ",
                    "Which language is used with .NET?",
                    5,
                    answers2,
                    answers2[0]
                );

            // ==========================================
            // Create Final Exam
            // ==========================================

            FinalExam finalExam =
                new FinalExam(60, 2);

            finalExam.Questions = new Question[]
            {
                question1,
                question2
            };

            // ==========================================
            // Associate Exam with Subject
            // ==========================================

            subject.CreateExam(finalExam);

            // ==========================================
            // Display Subject
            // ==========================================

            Console.WriteLine(subject);
            Console.WriteLine();

            // ==========================================
            // Show Exam
            // ==========================================

            subject.Exam.ShowExam();

            // ==========================================
            // Test IComparable
            // ==========================================

            Console.WriteLine();
            Console.WriteLine("Comparing Questions:");

            int result = question1.CompareTo(question2);

            if (result < 0)
                Console.WriteLine("Question 1 has less mark.");
            else if (result > 0)
                Console.WriteLine("Question 1 has greater mark.");
            else
                Console.WriteLine("Both questions have the same mark.");

            // ==========================================
            // Test ICloneable
            // ==========================================

            Console.WriteLine();
            Console.WriteLine("Cloning Question:");

            Question clonedQuestion =
                (Question)question1.Clone();

            Console.WriteLine(clonedQuestion);

            Console.ReadKey();
        }
    }
}
    

