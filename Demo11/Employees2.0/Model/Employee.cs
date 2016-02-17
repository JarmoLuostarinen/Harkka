using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees2._0.Model;
using System.Collections.ObjectModel;

namespace Employees.Model
{
    public class Employee
    {
        public string ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobTitle { get; set; }
        public string Image { get; set; }

        public string Fullname
        {
            get
            {
                return Lastname + " " + Firstname;
            }
        }
    }// class Employee

    public class EmployeeViewModel
    {
        //mallin sisäinen tietorakenne
        private ObservableCollection<Employee> employees = new List<Employee>();
        // ominaisuus, joka printataan UI:hin
        public ObservableCollection<Employee> Employees
        {
            get { return employees; }
        }
public  EmployeeImageViewModel
       
            public EmployeeViewModel()
        {

        }
        public void AddEmployee(string firstname, string lastname, , string jobTitle, EmployeeImage image)

        { string id = "0001";
            employees.Add(new Employee { ID = id, Firstname = firstname, Lastname = lastname, JobTitle = jobTitle, Image = image });
        }
            
            }
    }

