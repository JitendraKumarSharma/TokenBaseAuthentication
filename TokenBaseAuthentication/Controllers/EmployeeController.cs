using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TokenBaseAuthentication.Controllers
{
    [Authorize]
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> GetAllEmployee()
        {
            using (TestingDBEntities ent = new TestingDBEntities())
            {
                return ent.Employees.ToList();
            }
        }
    }
}
