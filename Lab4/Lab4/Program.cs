using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Animal
    {
        public string Name;
        public string Species;
        public int Age;
        public double Weight;
        public double Height;
        public string Region;
        public bool IsWild;
        public bool IsDied;

        public double GetIndexMassBody() // Індекс маси тіла
        {
            return Weight / (Height * Height);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введiть iм'я тварини: ");
            string sName = Console.ReadLine();

            Console.Write("Введiть вид тварини: ");
            string sSpecies = Console.ReadLine();

            Console.Write("Введiть вiк тварини: ");
            string sAge = Console.ReadLine();

            Console.Write("Введiть вагу тварини (кг): ");
            string sWeight = Console.ReadLine();

            Console.Write("Введiть зрiст тварини (м): ");
            string sHeight = Console.ReadLine();

            Console.Write("Введiть середовище: ");
            string sRegion = Console.ReadLine();

            Console.Write("Чи є тварина дикою? (y - так, n - нi): ");
            ConsoleKeyInfo keyIsWild = Console.ReadKey();
            Console.WriteLine();

            Console.Write("Чи є тварина зникаючим видом? (y - так, n - нi): ");
            ConsoleKeyInfo keyIsDied = Console.ReadKey();
            Console.WriteLine();

            Animal animal = new Animal();

            animal.Name = sName;
            animal.Species = sSpecies;
            animal.Age = int.Parse(sAge);
            animal.Weight = double.Parse(sWeight);
            animal.Height = double.Parse(sHeight);
            animal.Region = sRegion;
            animal.IsWild = keyIsWild.Key == ConsoleKey.Y ? true : false;
            animal.IsDied = keyIsDied.Key == ConsoleKey.Y ? true : false;

            double IndexMassBody = animal.GetIndexMassBody();

            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Дані про тварину:");
            Console.WriteLine(new string('-', 50));
            
            Console.WriteLine("Iм'я: " + animal.Name);
            
            Console.WriteLine("Вид: " + animal.Species);
            
            Console.WriteLine("Вiк: " + animal.Age);
            
            Console.WriteLine("Вага: " + animal.Weight.ToString("0.00") + " кг");
            
            Console.WriteLine("Зрiст: " + animal.Height.ToString("0.00") + " м");
            
            Console.WriteLine("Середовище: " + animal.Region);
            
            Console.WriteLine(animal.IsWild ? "Це дика тварина" : "Це домашня тварина");
            
            Console.WriteLine(animal.IsDied ? "Це зникаючий вид" : "Це не зникаючий вид");
            
            Console.WriteLine();
            Console.WriteLine("Iндекс маси тiла: " + IndexMassBody.ToString("0.00"));

            Console.ReadKey();
        }
    }
}