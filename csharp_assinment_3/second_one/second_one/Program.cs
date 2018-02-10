using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_one
{
    public abstract class Employee_abstract_class
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Experience { get; set; }
        public int _Annual_salary { get; set; }
        public int basic { get; set; }
        public string joining_date { get; set; }
        public abstract int salary_calc(int basic,int Experience);
    }
    public class Hr: Employee_abstract_class
    {
        
        public Hr(string Id, string Name, string Designation, int Experience,int _Annual_salary, int basic, string joining_date)
        {
            this.Id = Id;
            this.Name = Name;
            this.Designation = Designation;
            this.Experience = Experience;
            this._Annual_salary = _Annual_salary;
            this.basic = basic;
            this.joining_date = joining_date;
        }
        public override int salary_calc(int basic, int Experience)
        {
            _Annual_salary = (basic + (Experience * 1000))*12;
            return _Annual_salary;
        }
    }
    public class developer : Employee_abstract_class
    {
       
        public developer(string Id, string Name, string Designation, int Experience, int _Annual_salary, int basic, string joining_date)
        {
            this.Id = Id;
            this.Name = Name;
            this.Designation = Designation;
            this.Experience = Experience;
            this._Annual_salary = _Annual_salary;
            this.basic = basic;
            this.joining_date = joining_date;
        }
        public override int salary_calc(int basic, int Experience)
        {
            _Annual_salary = (basic + (Experience * 2000)) * 12;
            return _Annual_salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hr h = new Hr("A", "Rahul", "Hr", 4, 0, 8000, "1/1/2014");
            developer d = new developer("B", "Anwesh", "Developer", 5, 0, 8000, "1/1/2013");
            h._Annual_salary = h.salary_calc(h.basic, h.Experience);
            Console.WriteLine($"Annual salary of HR whose basic is 8000 is : {h._Annual_salary}");
            d._Annual_salary = d.salary_calc(d.basic, d.Experience);
            Console.WriteLine($"Annual salary of Developer whose basic is 8000 is : {d._Annual_salary}");
            
        }
    }
}
