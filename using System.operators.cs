using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign property values
            Employee emp1 = new Employee { Id = 101, FirstName = "John", LastName = "Doe" };

            // Instantiate the second Employee object and assign property values
            // Note: We are giving this employee the same ID to test the equality logic
            Employee emp2 = new Employee { Id = 101, FirstName = "Jane", LastName = "Smith" };

            // Instantiate a third employee with a different ID to test the inequality logic
            Employee emp3 = new Employee { Id = 102, FirstName = "Alice", LastName = "Brown" };

            // Use the overloaded "==" operator to compare emp1 and emp2
            // Since both have Id 101, this should return true
            bool areEqual = (emp1 == emp2);

            // Use the overloaded "!=" operator to compare emp1 and emp3
            // Since the IDs are different (101 vs 102), this should return true
            bool areNotEqual = (emp1 != emp3);

            // Print the result of the equality comparison to the console
            Console.WriteLine("Are Employee 1 and Employee 2 equal? " + areEqual);

            // Print the result of the inequality comparison to the console
            Console.WriteLine("Are Employee 1 and Employee 3 different? " + areNotEqual);

            // Keep the console window open to view results
            Console.ReadLine();
        }
    }
}

