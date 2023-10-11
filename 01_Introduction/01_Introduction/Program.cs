namespace _01_Introduction
{
    internal class Program
    {
        /* 1.Introduction to Variables -> what variables are, discuss the importance of variables in
         programming
         2.Data Types -> concept of data types. common data types in C# (int, double, string, bool, etc.).
         3.Variable Naming Conventions (camelCase, PascalCase)
         4.Operators and Operator Precedence -> common C# operators (arithmetic, assignment, comparison, logical, etc.)
         5.Practice */

        static void Main(string[] args)
        {
            // PascalCase
            string BookName = "";
            string book_name = "";
            string myFabvBookName = "";

            int number = 95;
            double price = 19.99;
            string name = "James";
            bool isStudent = true;

            // camelCase
            int studentAge;
            double averageScore;

            // PascalCase
            string EmployeeName;
            bool IsLoggedIn;

            int x = 5;
            int y = 3;

            // Arithmetic operators
            int sum = x + y;    // Addition
            int difference = x - y; // Subtraction
            int product = x * y;    // Multiplication
            int quotient = x / y;   // Division
            int remainder = x % y;  // Modulus

            // Comparison operators
            bool isEqual = (x == y);  // Equal to
            bool isNotEqual = (x != y);  // Not equal to
            bool isGreaterThan = (x > y);  // Greater than
            bool isLessThan = (x < y);     // Less than

            // Logical operators
            bool andResult = (true && false);  // AND
            bool orResult = (true || false);    // OR
            bool notResult = !true;             // NOT
        }
    }
}