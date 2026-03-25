using ConsoleApp6;
using System;

namespace ConsoleApp6
{
	public class Student : Person
	{
		private string group;
		private double averageGrade;

		public string Group
		{
			get { return group; }
			set { group = value; }
		}

		public double AverageGrade
		{
			get { return averageGrade; }
			set { averageGrade = value; }
		}

		// Вызов конструктора базового класса через base
		public Student(string fullName, int birthYear, string group, double averageGrade)
			: base(fullName, birthYear)
		{
			Group = group;
			AverageGrade = averageGrade;
		}

		// Переопределение виртуального метода базового класса
		public override void Study()
		{
			Console.WriteLine($"Студент {FullName} (Группа: {Group}) учится. Средний балл: {AverageGrade}");
		}
	}
}