using ConsoleApp6;
using System;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			// Создаем массив базового типа и заполняем его объектами наследников
			Person[] universityMembers = new Person[]
			{
				new Student("Альметов Радмир Рамильевич", 2007, "ИСЭбд-11", 4.5),
				new Teacher("Иванов Иван Иванович", 1980, "Доцент УлГТУ"),
				new Student("Смирнова Анна", 2006, "ИСЭбд-11", 4.8),
				new Person("Неизвестный Слушатель", 2000) // Объект самого базового класса
            };

			Console.WriteLine("Демонстрация полиморфного поведения");

			// Проходим по массиву и вызываем метод Study()
			foreach (Person member in universityMembers)
			{
				// Программа сама определит, какой именно метод вызывать (раннее/позднее связывание)
				member.Study();
			}

			Console.ReadLine();
		}
	}
}