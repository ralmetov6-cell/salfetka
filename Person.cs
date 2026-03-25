using ConsoleApp6;
using System;

namespace ConsoleApp6
{
	public class Person : ILearnable
	{
		// Демонстрация private и protected
		private string fullName;
		protected int birthYear; // Доступно здесь и в классах-наследниках

		public string FullName
		{
			get { return fullName; }
			set { fullName = value; }
		}

		public int BirthYear
		{
			get { return birthYear; }
			set { birthYear = value; }
		}

		public Person(string fullName, int birthYear)
		{
			FullName = fullName;
			BirthYear = birthYear;
		}

		// Виртуальный метод, чтобы наследники могли его переопределить
		public virtual void Study()
		{
			Console.WriteLine($"{FullName} занимается изучением общих материалов.");
		}
	}
}