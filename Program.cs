using System;

namespace OOP_Lab1
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Student st = new Student(
				"Альметов Радмир Рамильевич",
				"ИСЭбд-11",
				1,
				4, 5, 3, 5, 4
			);

			
			Console.WriteLine("ФИО: " + st.FullName);
			Console.WriteLine("Группа: " + st.Group);
			Console.WriteLine("Курс: " + st.Course);
			Console.WriteLine("Оценки: " + string.Join(", ", st.Grades));


			Console.WriteLine("Средний балл: " + st.GetAverage());

			
			int min, max;
			st.GetMinMax(out min, out max);

			Console.WriteLine("Минимальная оценка: " + min);
			Console.WriteLine("Максимальная оценка: " + max);

			
			st.NextCourse();
			Console.WriteLine("\nПосле перевода на следующий курс:");
			Console.WriteLine("Курс: " + st.Course);
		}
	}
}