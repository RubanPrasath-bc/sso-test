using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CCS.UITests.Data
{
    public class DataHelpers
    {
        public static IDictionary<string, string> ObjectDict { get; private set; }
        //Load all data from the relevent csv
        public static List<KeyValue> LoadAllData(string dataFileName)
        {
            var path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{dataFileName}.csv";
            using (CsvReader csv = new CsvReader(File.OpenText(path)))
            {
                return csv.GetRecords<KeyValue>().ToList();
            }
        }

        /// <summary>
        /// Saves all key values to the relevent csv
        /// </summary>
        /// <param name="data">The data.</param>
        public static void SaveAllData(List<KeyValue> data, string dataFileName)
        {
            var path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{dataFileName}.csv";
            using (StreamWriter writer = new StreamWriter((path)))
            using (CsvWriter csv = new CsvWriter(writer))
            {
                csv.WriteRecord<KeyValue>(new KeyValue { Key = "Key", Value = "Value" });
                foreach (KeyValue kv in data)
                {
                    csv.NextRecord();
                    csv.WriteRecord<KeyValue>(kv);
                }
            }
        }
        public static string GetTestFilePath(string filename)
        {
            return $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\TestData\\{filename}";
        }
    }

    public class KeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}