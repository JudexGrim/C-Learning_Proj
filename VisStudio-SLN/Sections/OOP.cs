using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Proj.Sections
{
    internal class OOP
    {
        private  string _Prop2;
        private int Prop1 { get; set; }
        private string Pass { get; set; }
        private bool IsAdmin { get { if (Pass.ToLower() == "admin123") return true; else return false; } set { if (Pass.ToLower() == "admin123") IsAdmin = true; else IsAdmin = false; } }
        public string Prop2
        {
            get { if (IsAdmin) return _Prop2; else return "ACCESS DENIED."; }
            set
            {
                if (IsAdmin)
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("NULL VALUE ENTERED.");
                        _Prop2 = "DEFAULT.";
                    }
                    else _Prop2 = value;
                }

                else Console.WriteLine("ADMIN PASSWORD IS INCORRECT.");
            }
        }

        public int getProp1() { return Prop1; }

        public OOP(int prop1)
        {
            Prop1 = prop1;
            Console.Write("Please Enter Admin Password: ");
            Pass = Console.ReadLine();
            Console.Write("Initializing Object. Please Enter Prop2's Value: ");
            Prop2 = Console.ReadLine();
            Console.WriteLine($"Prop1= {Prop1}, Prop2 = {Prop2}");
        }
    }

    internal class Person
    {
        private string _name;
        private int _age;
        public string Name { get
                ; set; }
        public int Age { get { return _age; } set { if (value > 0) _age = value; } }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Greet() { Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old."); }
    }

    internal class ReadOnly
    {
        private readonly string Prop1;
        public ReadOnly()
        {
            Prop1 = "";
        }
    }

    internal class Question 
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswer {  get; set; }

        public Question() {}

        public Question(string QuestionText, string[] Answers, int CorrectAnswer)
        {
            this.QuestionText = QuestionText;
            this.CorrectAnswer = CorrectAnswer;
            this.Answers = Answers;
        }
}

    internal class Quiz
    {
        private int _score;
        public int Score { get; set; }
        public Quiz(Question[] questions)
        {
            foreach (Question item in questions) DisplayQuestion(item);

            Console.Write($"Your Results : ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(Score);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" out of ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(questions.Length);
            Console.ForegroundColor = ConsoleColor.White;

        }
        public void DisplayQuestion(Question question) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║              Question                ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{i + 1}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(($". {question.Answers[i]}"));
            }
                CheckAnswer(question);
        }

        private void CheckAnswer(Question question) 
        {
            Console.Write("Your Answer: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > question.Answers.Length)
            {
                Console.WriteLine("Invalid Choice.");
                Console.Write("Your Answer: ");
            }
            if (choice - 1 == question.CorrectAnswer) Score++ ;
        }
    }
}

