public class Journal
    {
        public List<Entry> entries  = new List<Entry>();
        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }
        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine("-------------------------------");
            }
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    sw.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            entries.Clear();
            string line;
            using (StreamReader sr = new StreamReader(fileName))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string response = parts[2];
                    entries.Add(new Entry { Date = date, Prompt = prompt, Response = response });
                }
            }
        }
    }