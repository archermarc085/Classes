using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {
        #region Fields
        string name = "";
        string sername = "";
        string Position = "Director";
        double salary_permonth = 20000;
        int experience = 1;
        int count_workday = 13;
        int count_mustworkday = 15;
        #endregion

        #region Properties
        public string FirstName
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return sername; }
            set { sername = value; }
        }
        #endregion

        #region Constructor
        public Employee(string name, string sername)
        {
            this.name = name;
            this.sername = sername;
        }
        #endregion

        #region Methods
        double Salary()
        {
            double salary = 0;
            if (experience >= 2)
            {
                salary = (salary_permonth / (count_mustworkday) * count_workday) + salary_permonth * 0.29;
            }
            else if (experience == 1)
            {
                salary = (salary_permonth / (count_mustworkday) * count_workday) + salary_permonth * 0.15;
            }
            else
            {
                salary = (salary_permonth / (count_mustworkday) * count_workday);
            }
            return salary;
        }

        double TaxLevy()
        {
            return Salary() * 0.20;
        }
        public void Display()
        {
            Salary();
            string output = string.Format(@"
                             Name: {0}
                             LastName: {1}
                             Position: {2}
                             Experience: {3}
                             Salary: {4}
                             TaxLevi: {5}", FirstName, LastName, Position, experience, Salary(), TaxLevy());
            Console.WriteLine(output);
        }
        #endregion
    }
}
