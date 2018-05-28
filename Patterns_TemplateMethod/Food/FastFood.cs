using System;

namespace Patterns_TemplateMethod.Food {

	public abstract class FastFood {

		public void Prepare() {
			PrepareBread();
			PrepareMainIngredient();
			AddVegetables();
			
			if(WithSouse())
				AddSpecialSouse();
		}
				
		public abstract void PrepareMainIngredient();

		public abstract void AddSpecialSouse();
		
		public virtual bool WithSouse(){
			return true;
		}

		private void PrepareBread(){
			Console.WriteLine("Prepare bread");
		}
		
		private void AddVegetables(){
			Console.WriteLine("Add vegetables");
		}		
		
	}
}
