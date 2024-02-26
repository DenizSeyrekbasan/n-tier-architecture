using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public List<Employee> GetByReports(int min, int max)
        {
            return _employeeDal.GetAll(p => p.ReportsTo >= min && p.ReportsTo <= max);
        }

        public List<Employee> GetByTitle(string title)
        {
            return _employeeDal.GetAll(p => p.Title == title);
        }
    }
}
