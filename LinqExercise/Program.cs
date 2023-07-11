using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            
            Console.WriteLine(numbers.Sum());


            Console.WriteLine();


            //TODO: Print the Average of numbers

            static double Average(params double[] r)
            {
                double sum = 0;
                foreach (var c in r)
                    sum += c;
                return sum / r.Length;

                Console.WriteLine($"Average={Average(1, 2, 3, 4, 5, 6, 7, 8, 9, 0)}");

            }

            Console.WriteLine();


            //TODO: Order numbers in ascending order and print to the console

            var numbersSorted = numbers.OrderBy(x => x);

            foreach (var i in numbersSorted)
            {
                Console.WriteLine(i);

            }


            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console

            var sortedNumbers = numbers.OrderByDescending(x => x);

            foreach (var i in sortedNumbers)
            {
                Console.WriteLine(i);

            }


            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6

            var numbersGreaterThan6 = numbers.Where(n => n > 6);

            foreach (var number in numbersGreaterThan6)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine();

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            var orderedNumbers = numbers.OrderBy(n => n); 

            int count = 0;
            foreach (var number in orderedNumbers)
            {
                Console.WriteLine(number);

                count++;
                if (count == 4)
                    break;

            }


            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            int myAge = 19;

            numbers[4] = myAge;

            var orderNumbers = numbers.OrderByDescending(n => n);

            foreach (var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();



            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S
            //and order this in ascending order by FirstName.

            var orderEmployees = employees.Where(name => name.FirstName.StartsWith("C") || name.FirstName.StartsWith("S")).OrderBy(x => x.FirstName );

            foreach (var employee in orderEmployees)
            {
                Console.WriteLine(employee.FullName);
            }


            Console.WriteLine();


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first
            //and then by FirstName in the same result.

            var filteredEmployees = employees.FindAll(emp => emp.Age > 26);
            var sortedEmployees = filteredEmployees.OrderBy(emp => emp.Age).ThenBy(emp => emp.FirstName);
            foreach (var emp in sortedEmployees)
            {
                Console.WriteLine($"FullName: {emp.FirstName} {emp.LastName}, Age: {emp.Age}");
            }

            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal
            //to 10 AND Age is greater than 35.

            var filterEmployees = employees.Where(emp => emp.YearsOfExperience <= 10 && emp.Age > 35);
            var sumOfYearsOfExperience = filterEmployees.Sum(emp => emp.YearsOfExperience);
            var averageOfYearsOfExperience = filterEmployees.Average(emp => emp.YearsOfExperience);
            Console.WriteLine($"Sum of YearsOfExperience: {sumOfYearsOfExperience}");
            Console.WriteLine($"Average of YearsOfExperience: {averageOfYearsOfExperience}");


            Console.WriteLine();


            //TODO: Add an employee to the end of the list without using employees.Add()

            Employee newEmployee = new Employee("Isaiah", "Wilson", 19, 1);
            employees.Insert(employees.Count, newEmployee);

            foreach (var emp in employees)
            {
                Console.WriteLine($"FullName: {emp.FirstName} {emp.LastName}, Age: {emp.Age}, YearsOfExperience: {emp.YearsOfExperience}");
            }




            Console.WriteLine();

            Console.ReadLine();

        }



        

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
