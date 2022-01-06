using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebApp.Controllers
{
    public class Employee {
        public int eid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public long mobile { get; set; }
    }
    public class FirstController : ApiController
    {
        IList<Employee> emplist = new List<Employee>() {
            new Employee(){eid=1,name="deva",address="raipur",mobile=989897 },
            new Employee(){eid=2,name="anand",address="bislaspur",mobile=09876 },
            new Employee(){eid=3,name="patel",address="raigarh",mobile=537322 },
            new Employee(){eid=4,name="kush",address="bhilai",mobile=89767 }
        };

        // FirstController fc = new FirstController();

        [Route("api/first/showemp")]
        [HttpGet]
        public IList<Employee> showEmp() {
            return emplist;
        }

        [Route("api/first/showempbyid")]
        [HttpGet]
        public Employee showEmpById(int id) {

            var e = from i in emplist
                    where i.eid == id
                    select i;


            return e.FirstOrDefault();
        }

    }
}
