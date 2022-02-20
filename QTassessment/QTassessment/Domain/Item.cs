using System;

namespace QTassessment
{
    public class Item
    {
        public int id { get; set; }

        public int itemTypeId { get; set; }

        public ItemType itemType { get; set; }

        public string name { get; set; }
    }
}
