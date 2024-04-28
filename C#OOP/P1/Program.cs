using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            HiringDate date1 = new HiringDate(10, 3, 2022);
            HiringDate date2 = new HiringDate(15, 6, 2023);
            HiringDate date3 = new HiringDate(20, 9, 2024);

            
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(101, SecurityPrivilege.DBA, 50000, 'M',date1);
            EmpArr[1] = new Employee(102, SecurityPrivilege.Guest, 30000, 'F',date2);
            EmpArr[2] = new Employee(103, SecurityPrivilege.DBA, 60000,'M',date3);

            
            Array.Sort(EmpArr, (x, y) => DateTime.Compare(new DateTime(x.HireDate.Year, x.HireDate.Month, x.HireDate.Day), new DateTime(y.HireDate.Year, y.HireDate.Month, y.HireDate.Day)));

           
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
