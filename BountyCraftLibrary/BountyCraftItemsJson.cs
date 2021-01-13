using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace BountyCraftLibrary
{
    public static class BountyCraftItemsJson
    {
        public static void SaveSingleItemJson(Item item)
        {
            using (StreamWriter r = new StreamWriter($"Data/{item.Name}.json"))
            {
                r.WriteLine(JsonConvert.SerializeObject(item));
            }
        }

        public static void SaveListOfItemsJson(string filepath, List<Item> all_items)
        {
            using (StreamWriter w = new StreamWriter(filepath))
            {
                w.WriteLine(JsonConvert.SerializeObject(all_items));
            }
        }
        public static List<Item> ReadJson(string filepath)
        {
            try
            {
                using (StreamReader r = new StreamReader(filepath))
                {
                    return JsonConvert.DeserializeObject<List<Item>>(r.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
        }

        public static void UpdateItemInJson(string filepath, Item item_to_modify, Item new_item)
        {
            List<Item> all_items = ReadJson(filepath);

            int index = 0;
            foreach (Item _item in all_items)
            {
                if (_item.Name == item_to_modify.Name)
                {
                    index = all_items.IndexOf(_item);
                    break;
                }
            }
            all_items[index] = new_item;

            SaveListOfItemsJson(filepath, all_items);

        }

        public static void DeleteItemFromJson(string filepath, Item item_to_delete)
        {
            List<Item> all_items = ReadJson(filepath);

            foreach (Item _item in all_items)
            {
                if (_item.Name == item_to_delete.Name)
                {
                    all_items.Remove(_item);
                    break;
                }
            }
            SaveListOfItemsJson(filepath, all_items);
        }
    }
}