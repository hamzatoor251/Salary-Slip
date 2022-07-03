using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Slip
{
    class SalarySlip
    {
        public SalarySlip()
        {
            bool valid = false;
            Console.Write("Enter your designation: ");
            string designation = Console.ReadLine();
            Designation = designation;
            BaseSalary = 1500;
            foreach (char c in designation)
            {
                if (!Char.IsLetter(c))
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                }
            }
            while (Designation=="" || valid)
            {
                Console.WriteLine("__________________________________________________");
                Console.WriteLine("You entered wrong Entery!!!\n");
                Console.Write("Enter your designation again: ");
                designation = Console.ReadLine();
                Designation = designation;
                foreach (char c in designation)
                {
                    if (!Char.IsLetter(c))
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                }
            }
        }
        public string Designation { get; set; }
        protected int BaseSalary { get; set; }
        protected int SallaryCal(int fuel=0, int medical=0)
        {
            return (BaseSalary + fuel + medical);

        }
    }
    class GrossSallary:SalarySlip
    {
        public void DesigSallary()
        {
            if (this.Designation=="Engineer")
            {
                Console.WriteLine("You are our Employee Engineer,\nYour gross sallary is: $" + SallaryCal(100, 500));
            }
            else if (this.Designation == "Managers")
            {
                Console.WriteLine("You are our Employee Managers,\nYour gross sallary is: $" + SallaryCal(250, 1000));
            }
            else if (this.Designation == "Analysts")
            {
                Console.WriteLine("You are our Employee Analysts,\nYour gross sallary is: $" + SallaryCal(150, 800));
            }
            else
            {
                Console.WriteLine("Being an employee,\nYour sallary is: $" + SallaryCal());
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GrossSallary man = new GrossSallary();
            man.DesigSallary(); 
            
            
        }
    }
}
