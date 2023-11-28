using System;
namespace P01_Students
{
	public class Subject
	{
		public double Grade { get; set; }
		public string Name { get; set; }

		public Subject(double grade, string name)
		{
			this.Name = name;
			this.Grade = grade;
		}
	}
}

