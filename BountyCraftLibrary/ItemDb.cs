﻿using System.Text.Json;

namespace BountyCraftLibrary
{
    /// <summary>
    /// All Item Data stored in Json format locally in "items.json".
    /// </summary>
    public static class ItemDb
    {
        public static List<IItem>? Items { get; set; }

        private const string item_jsonpath = "~/Data/items.json";

        public static void ReadJson()
        {
            try
            {
                using (StreamReader r = new StreamReader(item_jsonpath))
                {
                    Items = JsonSerializer.Deserialize<List<IItem>>(r.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
        }
    }
}
