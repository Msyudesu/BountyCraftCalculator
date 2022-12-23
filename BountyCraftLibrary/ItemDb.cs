using System.Text.Json;

namespace BountyCraftLibrary
{
    public static class ItemDb
    {
        public static List<Item>? Items { get; set; }

        private const string item_jsonpath = "~/Data/items.json";

        public static void ReadJson()
        {
            try
            {
                using (StreamReader r = new StreamReader(item_jsonpath))
                {
                    Items = JsonSerializer.Deserialize<List<Item>>(r.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
        }
    }
}
