using System;

namespace MultipleInheritance
{
    public interface IGovRule{
        public abstract void nightCarfue();
    }

    public class Office {
        public void task() {
            Console.WriteLine("Doing Task from Office ");
        }
    }
    class Program : Office,IGovRule  //multiple inherictance using interface
    {
       public void nightCarfue()
        {
            Console.WriteLine("Stay in home at night");
        }
       
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.nightCarfue();
            pr.task();
        }

    }
}
