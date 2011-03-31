namespace FVDemo.Models {
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class PeopleRepository {
		static List<Person> people = new List<Person>();

		static PeopleRepository() {

			var startDate = new DateTime(1980, 1, 1);

			for(int i = 1; i <= 10; i++) {
				var rnd = new Random(i);
				int random = rnd.Next(100);

				var person = new Person {
                    Id = i,
					Forename = "Person",
					Surname = "#" + i,
                    Email = string.Format("Person{0}@RandomPeopleGenerator.net", i),
                    DateOfBirth = startDate.AddDays(i + random).AddMonths(i - random) 
				};

				people.Add(person);
			}
		}

		public Person FindById(int id) {
			return people.SingleOrDefault(x => x.Id == id);
		}

		public IQueryable<Person> FindAll() {
			return people.AsQueryable();
		}

		public void Save(Person person) {
			var nextId = people.Max(x => x.Id) + 1;
			person.Id = nextId;

			if (!people.Contains(person)) {
				people.Add(person);
			}
		}

		public void Delete(Person person) {
			if(people.Contains(person)) {
				people.Remove(person);
			}
		}
	}
}