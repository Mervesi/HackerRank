using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
            Console.ReadLine();
        }
    }
    public class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.testScores = scores;
        }
        internal char Calculate()
        {
            int toplam = 0;
            for (int i = 0; i < testScores.Length; i++)
            {
                toplam += testScores[i];
            }
            int ort = toplam / testScores.Length;
            if (ort >= 90 && ort <= 100)
                return 'O';
            else if (ort >= 80 && ort < 90)
                return 'E';
            else if (ort >= 70 && ort < 80)
                return 'A';
            else if (ort >= 55 && ort < 70)
                return 'P';
            else if (ort >= 40 && ort < 55)
                return 'D';
            else
                return 'T';
           

        }
    }
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }

        public Person()
        {

        }
        public Person(string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;

        }
        internal void printPerson()
        {
            Console.WriteLine("Name: " + lastName + "," + firstName + "\nID: " + id);
        }
    }
}
