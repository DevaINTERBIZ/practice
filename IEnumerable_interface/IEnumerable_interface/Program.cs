using System;
using System.Collections.Generic;
namespace IEnumerable_interface
{
    class Program : IEnumerable
    {
        private int id;
        private string name;

        public Program(int id, string name) {
            this.id = id;
            this.name = name;
        }

        public void Display() {
            Console.WriteLine("ID : {0}  Name :{1}",id,name);
        }

        /*public IEnumerator GetEnumerator() {
            return (IEnumerator)GetEnumerator();
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
