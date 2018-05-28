using System;
using Patterns_TemplateMethod.Food;

namespace Patterns_TemplateMethod {
	
	class Program {
	
		static void Main(string[] args) {

			HotDog hotDog = new HotDog();
			Burger burger = new Burger();

			hotDog.Prepare();

			Console.WriteLine();
			
			burger.Prepare();

			Console.ReadLine();
			
		}
	}
}
