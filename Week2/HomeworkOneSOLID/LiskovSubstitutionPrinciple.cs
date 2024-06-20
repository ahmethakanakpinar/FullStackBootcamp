using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOneSOLID.LiskovSubstitutionPrinciple
{
    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void MakeSound();
    }
    public interface IFlyingAnimal
    {
        void Fly();
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Kedi Maması");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Havhav");
        }
      
    }
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Köpek Maması");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miyav");
        }
    }
    public class Bird : Animal, IFlyingAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Kuş Yemi");
        }

        public void Fly()
        {
            Console.WriteLine("Kuşlar Uçar");
        }

        public override void MakeSound()
        {
            Console.WriteLine("CikCik");
        }
    }
}
