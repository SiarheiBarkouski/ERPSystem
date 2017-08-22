using ERPSystem.Entities;
using ERPSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem.Repository
{
    static class EmployeeBase
    {
        private static ObservableCollection<Employee> employees;

        static EmployeeBase()
        {
            employees = new ObservableCollection<Employee>();
            CreateTestEmployees();
        }

        public static ObservableCollection<Employee> Employees { get => employees; set => employees = value; }

        private static void CreateTestEmployees()
        {
            employees.Add(new Employee() { Id = 1, Fio = "Grace Hicks", Birth = DateTime.Parse("08/03/1978"), Address = "4678 Ranchview Dr", Photo = @"/Images/c.jpg", Role = 1, Effeciency = new EffeciencyValues(EffeciencyValues.GetRandom100Values(3)) });
            employees.Add(new Employee() { Id = 2, Fio = "Shawn Green", Birth = DateTime.Parse("10/07/1983"), Address = "4051 Westheimer Rd", Photo = @"/Images/a.jpg", Role = 2, Effeciency = new EffeciencyValues(EffeciencyValues.GetRandom100Values(3)) });
            employees.Add(new Employee() { Id = 3, Fio = "Dylan Rogers", Birth = DateTime.Parse("8/5/1982"), Address = "8669 Cherry St", Photo = @"/Images/b.jpg", Role = 3, Effeciency = new EffeciencyValues(EffeciencyValues.GetRandom100Values(3)) });
            employees.Add(new Employee() { Id = 4, Fio = "Nevaeh Wright", Birth = DateTime.Parse("5/6/1972"), Address = "4006 Third St", Photo = @"/Images/d.jpg", Role = 4, Effeciency = new EffeciencyValues(EffeciencyValues.GetRandom100Values(3)) });
            employees[0].ThisEmployeeProjects.Add(ProjectBase.Projects[0]);
            employees[0].ThisEmployeeProjects.Add(ProjectBase.Projects[2]);    
            employees[1].ThisEmployeeProjects.Add(ProjectBase.Projects[1]);
            employees[1].ThisEmployeeProjects.Add(ProjectBase.Projects[2]);
            employees[2].ThisEmployeeProjects.Add(ProjectBase.Projects[1]);
            employees[3].ThisEmployeeProjects.Add(ProjectBase.Projects[0]);
        }
    }
}
