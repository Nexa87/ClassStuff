using System;
namespace Disaheim
{
    public class Book
    {
        public string ItemId;
        public string Title;
        public double Price;

        public Book(string itemID)
        {
            ItemId = itemID;
        }
        public Book(string itemID, string title) : this(itemID)
        {
            Title = title;
        }
        public Book(string itemID, string title, double price) : this(itemID, title)
        {
            Price = price;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}