using Newtonsoft.Json;

namespace Prakticheskai_Rabota_8
{
    internal class deserialisuem
    {
        private static List<kotiki> kotiata_info = new List<kotiki>();

        public static void add_kotaita(kotiki kotaita)
        {
            out_json();
            kotiki_info.Add(kotiata);
            in_json();
        }

        private static void in_json()
        {
            string json = JsonConvert.SerializeObject(users_info);
            File.WriteAllText("Table.json", json);
        }

        public static void out_json()
        {
            string to_json = File.ReadAllText("Table.json");
            kotiki_info = JsonConvert.DeserializeObject<List<kotiki>>(to_json);
        }

        public static void vuvod()
        {
            Console.Clear();
            foreach (var kotiata in users_info.OrderBy(x => x.minute))
            {
                Console.WriteLine("Имя:" + kotiata.Name + "Результат работы в минутах: " + kotiata.minute + "Результат работы в секундах: " + kotiata.sec);
            }
        }
    }
