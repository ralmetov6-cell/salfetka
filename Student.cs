using System;
using System.Linq;

namespace OOP_Lab1
{
	class Student
	{
		
		private string fullName;
		private string group;
		private int course;
		private int[] grades;

		
		public string FullName
		{
			get { return fullName; }
			set { fullName = value; }
		}

		public string Group
		{
			get { return group; }
			set { group = value; }
		}

		public int Course
		{
			get { return course; }
			set { course = value; }
		}

		public int[] Grades
		{
			get { return grades; }
			set { grades = value; }
		}

		
		public Student(string name, string groupName, int courseNumber, params int[] marks)
		{
			FullName = name;
			Group = groupName;
			Course = courseNumber;
			Grades = marks;
		}

		
		public double GetAverage()
		{
			return Grades.Average();
		}

		
		public void NextCourse()
		{
			Course++;
		}

		
		public void GetMinMax(out int min, out int max)
		{
			min = Grades.Min();
			max = Grades.Max();
		}
	}
}
