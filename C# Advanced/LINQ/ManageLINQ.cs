using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.LINQ
{
    internal class ManageLINQ
    {
        public List<Employee> Employees { get; set; }
        public List<Department> Departments { get; set; }
        public ManageLINQ()
        {
            Employees = new List<Employee>()
            {
                new Employee(){Name="Mahmoud",Age=12,Salary="2000",DeptId=1},
                new Employee(){Name="Taha",Age=76,Salary="1500",DeptId=2},
                new Employee(){Name="Ahmed",Age=30,Salary="5666",DeptId=3},
                new Employee(){Name="Nada",Age=21,Salary="3500",DeptId=4},
                new Employee(){Name="Sara",Age=23,Salary="2500",DeptId=3},
                new Employee(){Name="Ledo",Age=18,Salary="4000",DeptId=2},
                new Employee(){Name="Alaa",Age=15,Salary="5000",DeptId=4},
                new Employee(){Name="Nour",Age=19,Salary="1000",DeptId=4},
            };

            Departments = new List<Department>()
            {
                new Department(){ Id=1,Name="HR"},
                new Department(){ Id=2,Name="IT"},
                new Department(){ Id=3,Name="Development"},
                new Department(){ Id=4,Name="Finance"},
            };
        }

        public IEnumerable<(string EmployeeName, string DeptName)> GetEmployeeWithDeptJOIN()
        {

            var dataWithQueryExpression = from emp in Employees
                                          join dept in Departments on emp.DeptId equals dept.Id
                                          select (emp.Name, dept.Name);


            var dataWithMethodExpression = Employees.Join(Departments, e => e.DeptId, d => d.Id,
                (emp, dept) => (emp.Name, dept.Name));

            return dataWithQueryExpression;
        }

        public IEnumerable<IGrouping<string, Employee>> GetEmployeeWithDeptGrouping()
        {

            var dataWithQueryExpression = from emp in Employees
                                          join dept in Departments on emp.DeptId equals dept.Id
                                          group emp by dept.Name;

            return dataWithQueryExpression;
        }

        public IEnumerable<(string, IEnumerable<Employee>)> GetEmployeeWithDeptGroupJoin()
        {

            var dataWithMethodLambdaExpression = Departments.GroupJoin(Employees, x => x.Id, d => d.DeptId,
                            (d, employees) => (d.Name, employees));

            return dataWithMethodLambdaExpression;
        }


    }
}
