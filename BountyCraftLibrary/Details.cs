using Azure.Core;
using System.Xml.Serialization;

namespace BountyCraft
{
    public sealed class Details
    {
        public static readonly Details Instance = new Details();

        public static readonly List<string> Categories = new List<string>()
        {
            "Seasonal",
            "Pictslayer",
            "Darkess Falls Weapons",
            "Darkness Falls Armor",
            "Darkness Falls Misc",
            "Aurulite Chestpieces",
            "Aurulite Boots",
            "Aurulite Accessories",
            "Hallowed Unique Rewards",
            "Frozen Chestpieces",
            "Frozen Weapons",
            "Frozen Mythirians",
            "Otherworldly Helms",
            "Otherworldly Gloves",
            "Otherworldly Accessories",
            "Curse Chestpieces",
            "Curse Sleeves",
            "Curse Leggings",
            "Curse Boots",
            "Curse Accessories",
            "Curse Gloves"
        };
        public static readonly List<string> Realms = new List<string>()
        {
            "All",
            "Hibernia",
            "Midgard",
            "Albion"
        };
        public static readonly List<string> AlchemyMats = new List<string>()
        {
            "Ancient Giant Blood",
            "Ancient Troll Blood",
            "Ancient Crushed Focus Stone",
            "Ancient Mirror",
            "Enriched Quicksilver",
            "Ancient Necrotic Brain Fluid",
            "Ancient Lich Tooth",
            "Ancient Pure Mercury"
        };
        public static readonly Dictionary<string, int> Molds = new Dictionary<string, int>()
        {
            { "Weapon"      , 7500 },
            { "Accessory"   , 5000 },
            { "Armor"       , 6250 }
        };
        public static readonly Dictionary<string, int> Recipes = new Dictionary<string, int>()
        {
            { "Darkness"      , 75000  },
            { "Pictslayer"    , 50000  },
            { "Seasonal"      , 100000 },
            { "Aurulite"      , 100000 },
            { "Otherworldly"  , 125000 },
            { "Frozen"        , 150000 },
            { "Curse"         , 175000 }
        };

        public static string GetItemXML(Item item)
        {
            XmlSerializer xml = new XmlSerializer(item.GetType());
            using (StringWriter sw = new StringWriter())
            {
                xml.Serialize(sw, item);
                return sw.ToString();
            }
        }

        public static string GoldAsString(long gold)
        {
            string _gold = gold.ToString();
            while (_gold.Length < 10) { _gold = "0" + _gold; }

            return $"{_gold[0..3]}p {_gold[3..6]}g {_gold[6..8]}s {_gold[8..10]}c";
        }
    }
}
