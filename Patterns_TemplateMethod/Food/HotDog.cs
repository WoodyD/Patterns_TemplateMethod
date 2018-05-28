using System;

namespace Patterns_TemplateMethod.Food {

	public class HotDog : FastFood {
		
		public override bool WithSouse(){
			Console.Write("Add souse? y/n : ");
			string userInput = Console.ReadLine();
			return userInput.ToLower() == "y";
		}
		
		public override void PrepareMainIngredient() {
			Console.WriteLine("Prepare sausage");
		}
		
		public override void AddSpecialSouse() {	
			Console.WriteLine("Add mustard");
		}

	}
}
