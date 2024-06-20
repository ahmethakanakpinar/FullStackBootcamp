using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOneSOLID.InterfaceSegregationPrinciple
{
    public interface IWorkable
    {
        void Work();
    }

    public interface IEatable
    {
        void Eat();
    }
    public class HumanWorker : IWorkable, IEatable
    {
        public void Work()
        {
            Console.WriteLine("İnsan Çalışır");
        }

        public void Eat()
        {
            Console.WriteLine("İnsan Yer");
        }
    }

    public class RobotWorker : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("İnsan Çalışır");
        }
    }

}
