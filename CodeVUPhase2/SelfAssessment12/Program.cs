using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfAssessment12
{

    class Program
    {
        static void Main(string[] args)
        {
            //Question2();
            //Question3();
            //Question4(); 
            //Question5();
            //Question6();
            Question8();
            
            
        }
        static void Question2()
        {
            //Question2 output
            Worker jim = new Worker("Jim", "Bones", 3000.00m, 2m);
            Console.WriteLine(jim.ToString());
            //EndQuestion2
        }
        static void Question3()
        {
            //Question3 Output
            //At this point the Student class is no longer inheriting from Human because 
            //I dont' know how to implement IComparable and inherit from Human at the same time
            //and still sort by Mark.
            SortedList<Student, string> studs = new SortedList<Student, string>();

            studs.Add(new Student("Jim", "Bones", 100), "Jim Bones 1");
            studs.Add(new Student("Tim", "Jones", 10), "Jim Bones 2");
            studs.Add(new Student("Grim", "Clones", 80), "Jim Bones 3");
            studs.Add(new Student("Hymn", "Tones", 90), "Jim Bones 4");
            studs.Add(new Student("Gym", "Groans", 30), "Jim Bones 5");
            studs.Add(new Student("Shim", "Scones", 40), "Jim Bones 6");
            studs.Add(new Student("Tele", "Phones", 70), "Jim Bones 7");
            studs.Add(new Student("Slingin", "Loans", 200), "Jim Bones 8");
            studs.Add(new Student("Chisel", "Hones", 60), "Jim Bones 9");
            studs.Add(new Student("Jacob", "Moans", 50), "Jim Bones 10");

            foreach (KeyValuePair<Student, string> kvp in studs)
            {
                Console.WriteLine($"{kvp.Value} {kvp.Key.Mark}");
            }
            //End Question3
        }
        static void Question4()
        {
            //Question 4 output
            Worker[] workers = new Worker[10];
            workers[0] = new Worker("Jim", "Bones", 300000000000m, 300m);
            workers[1] = new Worker("Jim", "Bones", 30000000000m, 300m);
            workers[2] = new Worker("Jim", "Bones", 3000000000m, 300m);
            workers[3] = new Worker("Jim", "Bones", 300000000m, 300m);
            workers[4] = new Worker("Jim", "Bones", 30000000m, 300m);
            workers[5] = new Worker("Jim", "Bones", 3000000m, 300m);
            workers[6] = new Worker("Jim", "Bones", 300000m, 300m);
            workers[7] = new Worker("Jim", "Bones", 30000m, 300m);
            workers[8] = new Worker("Jim", "Bones", 3000m, 300m);
            workers[9] = new Worker("Jim", "Bones", 300m, 300m);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (workers[i].CalcHourlyWage() < workers[j].CalcHourlyWage())
                    {
                        Worker temp = workers[i];
                        workers[i] = workers[j];
                        workers[j] = temp;

                    }
                }
            }
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }
            //End Question 4
        }
        static void Question5()
        {
            //Question 5 Output
            Triangle t = new Triangle(50, 2);
            Console.WriteLine(t.CalculateSurface());
            Rectangle r = new Rectangle(50, 2);
            Console.WriteLine(r.CalculateSurface());
            Circle c = new Circle(1, 1);
            Console.WriteLine(c.CalculateSurface());
        }
        static void Question6()
        {
            Animal[] animals = new Animal[5];
            animals[0] = new Dog(12, "Dying", true);
            animals[1] = new Cat(12, "Dying", false);
            animals[2] = new Kitten(1, "Cute", true);
            animals[3] = new Frog(12, "Overlord of Frogling Culture", true);
            animals[4] = new TomCat(37, "Bald and Unemployed", true);

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
        static void Question8()
        {
            Bank bank = new Bank();
            Customer jGalleys = new Customer("John Galloway", false);
            DepositAccount depo = new DepositAccount(3m, .12m, jGalleys);
            bank.AddAccount(depo);
            bank.ListAccounts();
            Console.WriteLine("Testing interest calc");
            depo.Deposit(2997m);
            depo.Withdraw(2000m);
            Console.WriteLine(depo.CalcInterest(36));
        }
    }
}
