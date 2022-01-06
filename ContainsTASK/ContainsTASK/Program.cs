using System;
using System.Collections.Generic;
using System.Linq;

namespace ContainsTASK
{
    class Student : IEquatable<Student>{ 
        public int sid { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        bool IEquatable<Student>.Equals(Student other)
        {
            if (other == null) return false;
            return (this.sid.Equals(other.sid));

        }
    }

    class StuClass {
        public int cid { get; set; }
        public int sid { get; set; }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student(){sid=1,name="Deva",address="rpr"},
                new Student(){sid=2,name="anand",address="bsp"},
                new Student(){sid=3,name="patel",address="rai"},
                new Student(){sid=4,name="rama",address="bsp" },
                new Student(){sid=5,name="kush",address="rpr" },
                new Student(){sid=6,name="luv",address="rpr"  }
            };

            IList<StuClass> classList = new List<StuClass>() { 
                   new StuClass(){cid=1,sid=2 },
                   new StuClass(){cid=3,sid=3 },
                   new StuClass(){cid=4,sid=4 },
                   new StuClass(){cid=5,sid=6 }
            };

            var lclass = classList.AsEnumerable();
            var lstudent = studentList.AsEnumerable();

            Console.WriteLine(lclass.GetType());
            Console.WriteLine(lstudent.GetType());
            Console.WriteLine("----------------------------------------------------");

            var x1= (from x in classList select x.sid).ToList();
            Console.WriteLine(x1.GetType());

            //var d = studentList.Contains(x1);
           
            foreach (var j in x1) {
                Console.WriteLine(
                    studentList.Contains(j)
                    );
                // Console.WriteLine(j); 
            }

        }
    }
}
