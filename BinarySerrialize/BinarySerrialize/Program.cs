using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
	[Serializable]
	class Person
	{
		
		public bool FilledRecord;
		public int FieldsFlags;
		public int GroupID;
		public int UserID;
		public int NameLength;
		public string Name;
		public bool Hidden;
		public int RSetlength;
		public string RightSet;
		public int HashLength;
		public string HashCode;
		public int CompanyLength;
		public string Company;
		public int AirportLength;
		public string Airport;
		public int TerminalLength;
		public string Terminal;
		public int CheckSum8;

		public Person(bool filledRecord, int fieldsFlags, int groupID, int userID, int nameLength, string name, bool hidden, int rSetlength,
			string rightSet, int hashLength, string hashCode, int companyLength, string company, int airportLength, string airport, int terminalLength,
			string terminal, int checkSum8)
		{
			
			
			FilledRecord = filledRecord;
			FieldsFlags = fieldsFlags;
			GroupID = groupID;
			UserID = userID;
			NameLength = nameLength;
			Name = name;
			Hidden = hidden;
			RSetlength = rSetlength;
			RightSet = rightSet;
			HashLength = hashLength;
			HashCode = hashCode;
			CompanyLength = companyLength;
			Company = company;
			AirportLength = airportLength;
			Airport = airport;
			TerminalLength = terminalLength;
			Terminal = terminal;
			CheckSum8 = checkSum8;

		}
	}

	class Program
	{
		static void Main(string[] args)
		{
		
			BinaryFormatter formatter = new BinaryFormatter();
		
			using (FileStream fs = new FileStream("User.dat", FileMode.OpenOrCreate))
			{
				Person newPerson = (Person)formatter.Deserialize(fs);

				Console.WriteLine("Объект десериализован");
				Console.WriteLine(" {0} ---  {1} ---  {2} --- {3} --- {4} --- {5} --- {6} --- {7} --- {8} --- {9} --- {10} --- {11} --- {12}" +
					"--- {13} --- {14} --- {15} --- {16} --- {17} --- {18} ", newPerson.FilledRecord, newPerson.FieldsFlags, newPerson.GroupID,
					newPerson.UserID, newPerson.NameLength, newPerson.Name, newPerson.Hidden, newPerson.RSetlength, newPerson.RSetlength,
					newPerson.HashLength, newPerson.HashCode, newPerson.CompanyLength, newPerson.Company, newPerson.AirportLength, newPerson.Airport,
					newPerson.TerminalLength, newPerson.Terminal, newPerson.CheckSum8);
			}

			Console.ReadLine();
		}
	}

}