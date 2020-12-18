using System;
using Observer;
using Mediator;

namespace PatternsCli
{
	class Program
	{
		/// <summary>
		/// Иллюстрирует работу наблюдателя.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			ObserverCli();
			MediatorCli();
		}

		// <summary>
		/// Иллюстрирует работу наблюдателя.
		/// </summary>
		static void ObserverCli() 
		{
			Console.WriteLine("Демонстрация работы наблюдателя.");
			var appState = new AppState("Старое Имя");
			var dcListner = new DownCaseListener();
			var ucListner = new UpperCaseListener();
			Console.WriteLine($"Старое имя приложения: {appState.Name}\nВведите новое имя приложения, чтобы увидеть его в  2х регистрах:");
			appState.AddListener(dcListner);
			appState.AddListener(ucListner);
			appState.Name = Console.ReadLine();
			Console.Read();
		}

		// <summary>
		/// Иллюстрирует работу медиатора.
		/// </summary>
		static void MediatorCli()
		{
			Console.WriteLine("Демонстрация работы медиатора.");
			var compA = new ComponentA();
			var compB = new ComponentB();
			var mediator = new ComponentMediator(compA, compB);
			Console.WriteLine("Сейчас компонент В среагирует на действие компонента А.");
			compA.Act1();
			Console.WriteLine("А сейчас компонент В не среагирует на действие компонента А.");
			compA.Act2();
			Console.Read();
		}

	}
}
