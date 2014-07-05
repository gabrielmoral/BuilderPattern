using NUnit.Framework;
using System;

namespace BuilderPattern
{
	[TestFixture ()]
	public class PaellaTest
	{
		[Test ()]
		public void PaellaValenciana ()
		{
			Paella paella = new Paella.PaellaCreator ()
											.name ("Valenciana")
											.people (4)
											.with (Ingrdient.Rice)
											.with(Ingrdient.Vegetables)
											.with(Ingrdient.Tomato)
											.with(Ingrdient.Chicken)
											.with(Ingrdient.Rabbit)
											.addExtra(Extra.Rosemary)
											.build ();

			Assert.AreEqual (paella.Name, "Valenciana");
			Assert.AreEqual (paella.NumberOfPeople, 4);
			Assert.IsTrue (paella.Ingredients.Count == 5);
		}

		[Test ()]
		public void PaellaValencianaWithDefaultBuilder ()
		{
			Paella paella = new PaellaValencianaCreator ()
				.people (4)
				.build ();

			Assert.AreEqual (paella.Name, "Valenciana");
			Assert.AreEqual (paella.NumberOfPeople, 4);
			Assert.IsTrue (paella.Ingredients.Count == 5);
		}
	}
}

