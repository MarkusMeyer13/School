using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolData
{
    public class DataAccess
    {
        private string filename = "Durchschnitt.csv";

        public void SaveData(string data)
        {
            string fullPath = Environment.CurrentDirectory.Trim('\\') + "\\" + filename;

            if (!File.Exists(fullPath))
            {
                data = "Fach,Note1,Note2,Note3,Durchschnitt" + Environment.NewLine + data;
            }

            if (!data.EndsWith(Environment.NewLine))
            {
                data += Environment.NewLine;
            }
            File.AppendAllText(fullPath, data);

            ReadBest(string.Empty);
        }

        public void ReadBest(string name)
        {
            string fullPath = Environment.CurrentDirectory.Trim('\\') + "\\" + filename;

            string[] lines = File.ReadAllLines(fullPath);
            var entries = lines.ToList();
            entries.RemoveAt(0);

            var values = entries.Select(l => new { Subject = l.Split(',').First(), Grade1 = l.Split(',').Skip(1).Select(v => double.Parse(v)).First() });
            foreach (var value in values)
            {
                Console.WriteLine(value.Subject);
                Console.WriteLine(value.Grade1);
            }
        }
    }
}
