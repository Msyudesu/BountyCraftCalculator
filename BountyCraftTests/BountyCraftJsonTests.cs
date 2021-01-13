using Microsoft.VisualStudio.TestTools.UnitTesting;
using BountyCraftLibrary;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BountyCraftTests
{
    [TestClass]
    public class BountyCraftJsonTests
    {

        private static List<Item> GenerateListofTestItems(int quantity)
        {
            List<Item> test_items = new List<Item>();
            for (int i = 0; i < quantity; i++ )
                test_items.Add(GenerateTestItem(i));
            return test_items;
        }

        private static Item GenerateTestItem(int i = 1)
        {
            return new Item($"Test Item {i}", $"Test Realm {i}", $"Test Mold {i}", i, i, $"Test Recipe {i}", new Dictionary<string, int> { { "Alchemy Item", i } });
        }

        private static void CheckForAndDeleteTestFile(string filepath)
        {
            if (File.Exists(filepath)) { File.Delete(filepath); }
        }

        [TestMethod]
        public void ReadJsonDoesNotReturnNull()
        {
            string filepath = "Data/test_data.json";
            List<Item> items = BountyCraftItemsJson.ReadJson(filepath);
            Assert.IsNotNull(items);
        }
        [TestMethod]
        public void ReadJsonReturnsCorrectData()
        {
            string filepath = "Data/test_data.json";
            List<Item> items = BountyCraftItemsJson.ReadJson(filepath);
            Item test_item = GenerateTestItem(1);
            Assert.ReferenceEquals(items[0], test_item);
        }

        [TestMethod]
        public void SaveJsonCreatesCorrectFile()
        {
            Item test_item = GenerateTestItem(1);

            // Delete previous test file if it exists.
            string filepath = $"Data/{test_item.Name}.json";
            CheckForAndDeleteTestFile(filepath);


            BountyCraftItemsJson.SaveSingleItemJson(test_item);
            Assert.IsTrue(File.Exists($"Data/{test_item.Name}.json"));
        }

        [TestMethod]
        public void UpdateJsonItem()
        {
            // If the test has already been run, the previous test file must be deleted first.
            string filepath = "Data/update_test_file.json";
            CheckForAndDeleteTestFile(filepath);

            // Create test list and serialize to JSON to create test file.
            List<Item> test_items = GenerateListofTestItems(3);
            BountyCraftItemsJson.SaveListOfItemsJson(filepath, test_items);

            // Simulated changed item. Save to compare later.
            Item new_item = new Item("This Item was Changed", "Changed Realm", "Changed Mold", 4, 4, "Changed Recipe", new Dictionary<string, int> { { "Changed Item", 4 } });

            // Call Update. After, Read and Compare the changed item.
            BountyCraftItemsJson.UpdateItemInJson(filepath, test_items[1], new_item);
            test_items = BountyCraftItemsJson.ReadJson(filepath);
            Assert.ReferenceEquals(test_items[1], new_item);
        }

        [TestMethod]
        public void UpdateJsonItemWithoutChangingName()
        {
            // If the test has already been run, the previous test file must be deleted first.
            string filepath = "Data/update_test_file.json";
            CheckForAndDeleteTestFile(filepath);

            // Create test list and serialize to JSON to create test file.
            List<Item> test_items = GenerateListofTestItems(3);
            BountyCraftItemsJson.SaveListOfItemsJson(filepath, test_items);

            // Simulated changed item. Save to compare later.
            Item new_item = new Item("Test Item 2", "Changed Realm", "Changed Mold", 4, 4, "Changed Recipe", new Dictionary<string, int> { { "Changed Item", 4 } });

            // Call Update. After, Read and Compare the changed item.
            BountyCraftItemsJson.UpdateItemInJson(filepath, test_items[1], new_item);
            test_items = BountyCraftItemsJson.ReadJson(filepath);
            
            Assert.ReferenceEquals(test_items[1], new_item);
        }

        [TestMethod]
        public void DeleteItemFromJson()
        {
            // If the test has already been run, the previous test file must be deleted first.
            string filepath = "Data/delete_item_test_file.json";
            CheckForAndDeleteTestFile(filepath);

            // Create test list and serialize to JSON to create test file.
            List<Item> test_items = GenerateListofTestItems(3);

            BountyCraftItemsJson.SaveListOfItemsJson(filepath, test_items);

            // Choose an item to delete and then see if that item was deleted.
            BountyCraftItemsJson.DeleteItemFromJson(filepath, test_items[1]);
            List<Item> test_items_after_deletion = BountyCraftItemsJson.ReadJson(filepath);
            
            var query = (from _items in test_items_after_deletion where _items.Name == test_items[1].Name select _items).ToList();
            Assert.IsTrue(query.Count == 0);
        }
    }
}
