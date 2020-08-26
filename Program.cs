using System;

namespace oop_6115261019_w07
{
   
           class Program
        {
            static void Main(string[] args)
            {
                Person p1 = new Person("Nitat", "Ninchawee", 20000, 10, 2, 2);
                Lecturer l1 = new Lecturer("Nitat", "Ninchawee", 20000, 0, 20, 20, 20, 20, 10);
                SupportPersonnel SP1 = new SupportPersonnel("Nitat", "Ninchawee", 20000, 0, 20, 20, 50);
                Console.WriteLine(p1.ToString());
                Console.WriteLine(l1.ToString());
                Console.WriteLine(SP1.ToString());
            }
        }
    }
