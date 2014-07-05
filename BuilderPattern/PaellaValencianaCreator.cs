using NUnit.Framework;
using System;

namespace BuilderPattern
{
	public class PaellaValencianaCreator : Paella.PaellaCreator
	{
		public PaellaValencianaCreator ()
		{
			this.name ("Valenciana")
				.with (Ingrdient.Rice)
				.with (Ingrdient.Vegetables)
				.with (Ingrdient.Tomato)
				.with (Ingrdient.Chicken)
				.with (Ingrdient.Rabbit)
				.addExtra (Extra.Rosemary);
		}

	}

}

