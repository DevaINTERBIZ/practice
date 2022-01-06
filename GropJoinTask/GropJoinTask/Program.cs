using System;
using System.Collections.Generic;
using System.Linq;
namespace GropJoinTask
{

    class Student {
        public int stID {get;set;}
        public string stName { get;set }
    }
    class StudentAddress {
        public int stID { get; set; }
        public string city { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> st = new List<Student>() {
                new Student(){stID=1,stName="deva" },
                new Student(){stID=2,stName="anand" },
                new Student(){stID=3,stName="patel" },
                new Student(){stID=4,stName="kush" },
                new Student(){stID=5,stName="luv" },
                new Student(){stID=6,stName="rama" }
               };

            IList<StudentAddress> stA = new List<StudentAddress>() { 
                new StudentAddress() {stID=1,city="rpr" },
                new StudentAddress() {stID=2,city="bsp" },
                new StudentAddress() {stID=3,city="rpr" },
                new StudentAddress() {stID=4,city="rpr" },
                new StudentAddress() {stID=5,city="rai" },
                new StudentAddress() {stID=6,city="bsp" },
                new StudentAddress() {stID=7,city="rai" },
            };
        }
    }
}
