using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanWinForms
{
	public static class DataManager
	{
		public static void LoadTxt(string path, List<string> list)
		{
			using (StreamReader sr = new StreamReader(@path))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					list.Add(line);
				}
			}
		}

		public static void SaveTxt(string path, List<string> list)
		{
			using (StreamWriter sw = new StreamWriter(@path))
			{
				foreach (string line in list)
					sw.WriteLine(line);
				sw.Flush();
			}
		}

		public static void AppendTxt(string path, List<string> list)
		{
			using (StreamWriter sw = new StreamWriter(@path, true))
			{
				foreach (string line in list)
					sw.WriteLine(line);
				sw.Flush();
			}
		}
	}
}
