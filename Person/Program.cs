using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");

            Person p1 = new Person();
            p1.Name = "Miki";
            p1.Surname = "Kiki";
            p1.Age = 1;
            p1.Document = "12345";

            p1.PrintPersonalInfo();

        }
    }



    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Document { get; set; }
        public DateTime BornAt { get; set; }

        public void PrintPersonalInfo()
        {
            Console.WriteLine("Ati introdus urmatoarele date; ce au fost validate cu succes: ");
            Console.WriteLine($"Nume: {Name}, Prenume: {Surname}, Varsta: {Age}, CNP(Document): {Document}, ");
        }



    }
}
