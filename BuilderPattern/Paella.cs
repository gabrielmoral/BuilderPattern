using System;
using System.Collections.Immutable;
using System.Collections.Generic;

namespace BuilderPattern
{
	public class Paella
	{
		private List<Ingrdient> ingredients;

		private List<Extra> extras;

		private string name;

		private int numberOfPeople;

		public Paella ()
		{
			this.ingredients = new List<Ingrdient> ();
			this.extras = new List<Extra> ();
		}

		public string Name { get { return this.name; }}

		public int NumberOfPeople { get{ return this.numberOfPeople; }}

		public ImmutableList<Ingrdient> Ingredients 
		{ 
			get 
			{
				return this.ingredients.ToImmutableList ();
			}
		}

		public ImmutableList<Extra> Extras 
		{ 
			get 
			{
				return this.extras.ToImmutableList ();
			}
		}

		public class PaellaCreator
		{
			private Paella paella = new Paella();

			public PaellaCreator name(string name)
			{
				paella.name = name;
				return this;
			}

			public PaellaCreator people(int number)
			{
				paella.numberOfPeople = number;
				return this;
			}

			public PaellaCreator with (Ingrdient ingredient)
			{
				paella.ingredients.Add (ingredient);
				return this;
			}

			public PaellaCreator addExtra (Extra extra)
			{
				paella.extras.Add (extra);
				return this;
			}

			public Paella build ()
			{
				Paella paella = this.paella;

				this.paella = null;

				return paella;
			}
		}
	}
}

