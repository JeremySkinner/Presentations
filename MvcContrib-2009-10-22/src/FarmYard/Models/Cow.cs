using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace FarmYard.Models
{
	public class Cow
	{
		public Cow(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int NumberOfCalves { get; set; }

		public Stream Milk()
		{
			return null;
		}
	}
}