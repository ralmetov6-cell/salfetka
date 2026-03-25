using ConsoleApp6;
using System;

namespace ConsoleApp6
{
	public class Teacher : Person
	{
		private string qualification;

		public string Qualification
		{
			get { return qualification; }
			set { qualification = value; }
		}

		public Teacher(string fullName, int birthYear, string qualification)
			: base(fullName, birthYear)
		{
			Qualification = qualification;
		}

		// Переопределение виртуального метода базового класса
		public override void Study()
		{
			Console.WriteLine($"Преподаватель {FullName} (Квалификация: {Qualification}) изучает новые методики.");
		}
	}
}