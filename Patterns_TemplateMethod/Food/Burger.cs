using System;
namespace Patterns_TemplateMethod.Food {
	public class Burger : FastFood {

		public override void PrepareMainIngredient() {
			Console.WriteLine("Prepare cutlete");
		}

		public override void AddSpecialSouse() {
			Console.WriteLine("Add ketchup");
		}
		
	}
}
