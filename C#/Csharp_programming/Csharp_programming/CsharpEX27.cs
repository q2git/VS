using System;

//例27 多态案例 员工工资

namespace CsharpEX27

{

    class Program

    {

        public static void Example()

        {

            SalariedEmployee salariedEmployee =

            new SalariedEmployee("Jhon", "111-111-111", 800M);

            HourlyEmployee hourlyEmployee =

            new HourlyEmployee("Karen", "222-222-222", 16.78M, 39M);

            CommissonEmployee commissionEmployee =

            new CommissonEmployee("Sue", "333-333-333", 10000M, 0.05M);

            BasePlusCommissionEmployee basePlusCommissionEmployee =

            new BasePlusCommissionEmployee("Bob", "444-444-444", 20000M, 0.05M, 300M);

            Console.WriteLine("Earning.......");

            Console.WriteLine(salariedEmployee);

            Console.WriteLine(salariedEmployee.Earning());

            Console.WriteLine(hourlyEmployee);

            Console.WriteLine(hourlyEmployee.Earning());

            Employee[] employee = new Employee[4];

            employee[0] = salariedEmployee;

            employee[1] = hourlyEmployee;

            employee[2] = commissionEmployee;

            employee[3] = basePlusCommissionEmployee;

            foreach (var currentEmployee in employee)

            {

                Console.WriteLine(currentEmployee);

                if (currentEmployee is BasePlusCommissionEmployee)

                {

                    //ADD Salary

                }

            }

        }

    }

    public abstract class Employee

    {

        public string Name { get; private set; }

        public string SSD { get; private set; }

        public Employee(string name, string ssd)

        {

            Name = name;

            SSD = ssd;

        }

        public override string ToString()

        {

            return string.Format("{0} ID number:{1}", Name, SSD);

        }

        public abstract decimal Earning();

    }

    public class SalariedEmployee : Employee

    {

        private decimal weekSalary;

        public decimal WeekSalary

        {

            get { return weekSalary; }

            set { weekSalary = value >= 0 ? value : 0; }

        }

        public SalariedEmployee(string name, string ssd, decimal salary)

        : base(name, ssd)

        {

            WeekSalary = salary;

        }

        public override decimal Earning()

        {

            return WeekSalary;

        }

        public override string ToString()

        {

            return string.Format("SalaryEmployee: {0} \n {1:C}",

            base.ToString(), WeekSalary);

        }

    }

    public class HourlyEmployee : Employee

    {

        private decimal wage;

        private decimal hours;

        public decimal Wage

        {

            get { return wage; }

            set { wage = value >= 0 ? value : 0; }

        }

        public decimal Hours

        {

            get { return hours; }

            set { hours = value >= 0 ? value : 0; }

        }

        public HourlyEmployee(string name, string ssd, decimal hourlyWage, decimal hourWorked)

        : base(name, ssd)

        {

            Wage = hourlyWage;

            Hours = hourWorked;

        }

        public override decimal Earning()

        {

            if (Hours <= 40)

                return Wage * Hours;

            else

                return (40 * Wage) + (Hours - 40) * 1.5M * Wage;

        }

        public override string ToString()

        {

            return string.Format("HourlyEployee:{0} \n HourlyWage: {1:C}"

            + " Hours Worked {2}", base.ToString(), Wage, Hours);

        }

    }

    public class CommissonEmployee : Employee

    {

        private decimal grossSale;

        private decimal commissionRate;

        public decimal GrossSale

        {

            get { return grossSale; }

            set { grossSale = value > 0 ? value : 0; }

        }

        public decimal CommissionRate

        {

            get { return commissionRate; }

            set { commissionRate = value > 0 ? value : 0; }

        }

        public CommissonEmployee(string name, string ssd, decimal sales, decimal rate)

        : base(name, ssd)

        {

            GrossSale = sales;

            CommissionRate = rate;

        }

        public override decimal Earning()

        {

            return GrossSale * CommissionRate;

        }

        public override string ToString()

        {

            return string.Format("CommissionEmployee : {0} \n"

            + " GrossSale : {1:C} Rate {2}", base.ToString(), GrossSale, CommissionRate);

        }

    }

    public class BasePlusCommissionEmployee : CommissonEmployee

    {

        private decimal baseSalary;

        public decimal BaseSalary

        {

            get { return baseSalary; }

            set { baseSalary = value > 0 ? value : 0; }

        }

        public BasePlusCommissionEmployee(string name, string ssd, decimal sales,

        decimal rate, decimal salary) : base(name, ssd, sales, rate)

        {

            BaseSalary = salary;

        }

        public override decimal Earning()

        {

            return base.Earning() + BaseSalary;

        }

        public override string ToString()

        {

            return string.Format("BasePlusCommissionEmployee : {0} \n"

            + " Base Salary {1:c}", base.ToString(), BaseSalary);

        }

    }

}

