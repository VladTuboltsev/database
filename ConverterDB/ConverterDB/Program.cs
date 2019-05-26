using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterDB
{
	struct Data
	{
		public bool filledRecord;
		public int fieldsFlags;
		public int groupID;
		public int userID;
		public int nameLength;
		public string name;
		public bool hidden;
		public int rSetlength;
		public string rightSet;
		public int hashLength;
		public string hashCode;
		public int companyLength;
		public string company;
		public int airportLength;
		public string airport;
		public int terminalLength;
		public string terminal;
		public int checkSum8;


		public Data(int gr, int use, string n, bool h, string r, string hc, string c, string a, string ter,bool fr, int ff,
			int nl, int rsl, int hl, int cl, int al, int tl, int chs8)
		{
			filledRecord = fr;
			fieldsFlags = ff;
			groupID = gr;
			userID = use;
			nameLength = nl;
			name = n;
			hidden = h;
			rSetlength = rsl;
			rightSet = r;
			hashLength = hl;
			hashCode = hc;
			companyLength = cl;
			company = c;
			airportLength = al;
			airport = a;
			terminalLength = tl;
			terminal = ter;
			checkSum8 = chs8;
							   				 
		}
	}
}

	class Program
	{
		static void Main(string[] args)
		{
		//string path = @"E:\mySQLserver\User.dat";

		using (FileStream reader = new FileStream("e:\\mySQLserver\\User.dat", FileMode.Open))
		using (BinaryReader br = new BinaryReader(reader, Encoding.ASCII))

		{
			
			//long length = reader.BaseStream.Length;
			//while (reader.BaseStream.Position < length)
			//for (long i = reader.BaseStream.Position; i + by < reader.BaseStream.Length; i++)
			//while (reader.PeekChar() > -1)
			{
				reader.Position = 0x1646;
				bool filledRecord = br.ReadBoolean();
				Console.WriteLine("FieldRecord: " + filledRecord);
				int fieldsFlags = br.ReadInt32();
				Console.WriteLine("FieldFlags: " + fieldsFlags);
				int groupID = br.ReadInt32();
				Console.WriteLine("Групповой ид:" + groupID);
				int userID = br.ReadInt32();
				Console.WriteLine("UserId: " + userID);
				int nameLength = br.ReadInt32();
				Console.WriteLine(": " + nameLength);
				string name = br.ReadString();
				Console.WriteLine("Name: " + name);
				bool hidden = br.ReadBoolean();
				Console.WriteLine("Hidden: " + hidden);
				int rSetLength = br.ReadInt32();
				Console.WriteLine("Групповой ид:" + rSetLength);
				string rightSet = br.ReadString();
				Console.WriteLine("RightSet: " + rightSet);
				int hashLength = br.ReadInt32();
				Console.WriteLine("Групповой ид:" + hashLength);
				string hashCode = br.ReadString();
				Console.WriteLine("Hashcode:" + hashCode);
				int companyLength = br.ReadInt32();
				Console.WriteLine("Групповой ид:" + companyLength);
				string company = br.ReadString();
				Console.WriteLine("Compane:" + company);
				int airportLength = br.ReadInt32();
				Console.WriteLine("Групповой ид:" + airportLength);
				string airport = br.ReadString();
				Console.WriteLine("Airport:" + airport);
				int terminalLength = br.ReadInt32();
				Console.WriteLine("Групповой ид:" + terminalLength);
				string terminal = br.ReadString();
				Console.WriteLine("terminal:" + terminal);
				int checkSum8 = br.ReadInt32();
				Console.WriteLine("Групповой ид:" + checkSum8);
				Console.ReadLine();

			}
		}
		}
	}


