using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        List<Employee> GetByReports(int min, int max);
        List<Employee> GetByTitle(string title);
    }
}
