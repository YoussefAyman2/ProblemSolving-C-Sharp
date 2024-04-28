using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   enum SecurityPrivilege {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class Employee 
    {
        public int Id { set; get; }
        public SecurityPrivilege Privilege { get; set; }
        public decimal Salary { set; get; }

        private char gender;
        public char Gender
        {
            get { return gender; }
            set { gender = value == 'M' ? value : value == 'F' ? value :throw new ArgumentException("Gender must be M or F."); ; }
        }
        public HiringDate HireDate { set; get; }
        public Employee()
        {
            
        }
        public Employee(int _id, SecurityPrivilege _privilege, decimal _salary,char _gender,HiringDate _HireDate)
        {
            Id = _id;Privilege = _privilege; Salary = _salary; Gender = _gender;
            HireDate = _HireDate;
        }
        public override string ToString()
        {
            //:C for $
            return $"ID: {Id}, Security Privilege: {Privilege}, Salary: {Salary:C}, Hire Date: {HireDate.Day}/{HireDate.Month}/{HireDate.Year}, Gender: {Gender}";
        }
    }
}
