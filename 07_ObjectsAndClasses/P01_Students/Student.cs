using System;

namespace P01_Students
{
	public class Student
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string City { get; set; }

		public int Age { get; set; }

		public List<Subject> Subjects { get; set; }

		public Student(int id, string firstName, string lastName, string city, int age, List<Subject> subjects)
		{
			this.Id = id;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.City = city;
			this.Age = age;
			this.Subjects = subjects;
		}

		public string GetFullName()
		{
			return $"{this.FirstName} {this.LastName}";
		}

		public void GetSubjects()
		{
			foreach (var subject in this.Subjects)
			{
				Console.WriteLine($"{subject.Name} - {subject.Grade}");
			}
		}

		public string AverageGrade()
		{
			double average = CalculateAverageGrade();

			return $"{GetFullName()} - {average}";
        }

		private double CalculateAverageGrade()
		{
            double sum = 0;

            foreach (var subject in this.Subjects)
            {
                sum += subject.Grade;
            }
            double average = sum / this.Subjects.Count();

			return average;
        }
	}
}