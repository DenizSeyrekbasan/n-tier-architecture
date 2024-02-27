using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>> (_employeeDal.GetAll());
        }

        public IDataResult<List<Employee>> GetByReports(int min, int max)
        {
            return new SuccessDataResult<List<Employee>> (_employeeDal.GetAll(p => p.ReportsTo >= min && p.ReportsTo <= max));
        }

        public  IDataResult<List<Employee>> GetByTitle(string title)
        {
            return new SuccessDataResult<List<Employee>> (_employeeDal.GetAll(p => p.Title == title));
        }
    }
}
