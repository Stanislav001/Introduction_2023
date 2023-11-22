using System;

namespace P01_Students
{
	public class Student
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string City { get; set; }

		public int Age { get; set; }

		public Student()
		{

		}

		public Student(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public Student(string firstName, string lastName, string city, int age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.City = city;
			this.Age = age;
		}

		public void SayHello(string name)
		{
			Console.WriteLine($"{this.FirstName} say hello to {name}");
		}

		public void IdCard()
		{
			Console.WriteLine($"First name -> {this.FirstName}, last name -> {this.LastName}, age -> {this.Age}, city -> {this.City}");
		}
	}
}