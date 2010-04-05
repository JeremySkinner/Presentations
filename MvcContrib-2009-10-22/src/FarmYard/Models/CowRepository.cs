using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmYard.Models
{
	public class CowRepository
	{
		private static readonly List<Cow> cows = new List<Cow>
     	{
			
     	};

		static CowRepository()
		{
			cows = new List<Cow>() { 
				new Cow(1) { Name="Rosemary", DateOfBirth = DateTime.Today.AddYears(-5).AddDays(4), NumberOfCalves = 1 },
				new Cow(2) { Name = "Emily", DateOfBirth = DateTime.Today.AddDays(-7), NumberOfCalves = 0},
				new Cow(3) { Name = "Murtle", DateOfBirth = DateTime.Today.AddYears(-6), NumberOfCalves = 2 },
				new Cow(4) { Name = "George", DateOfBirth = new DateTime(1994, 1, 17), NumberOfCalves = 0 }
			};

			for(int i = 5; i < 50; i++ )
			{
				cows.Add(new Cow(i) { Name = "Cow #" + i, DateOfBirth = DateTime.Today.AddDays(-150), NumberOfCalves = 1 });
			}
		}

		public Cow FindById(int id)
		{
			return cows.SingleOrDefault(x => x.Id == id);
		}

		public IEnumerable<Cow> FindAll()
		{
			return cows;
		}

		public Cow FindByName(string name)
		{
			return cows.SingleOrDefault(x => x.Name == name);
		}
	}
}