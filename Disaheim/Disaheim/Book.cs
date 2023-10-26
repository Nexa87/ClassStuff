using System;
namespace Disaheim
{
    public class Book : Merchandise
    {
        
        public string Title;
        public double Price;

        public Book(string itemId, string title, double price)
        {
            Price = price;
            Title = title;
            base.ItemId = itemId;
        }
        public Book(string itemId, string title) : this(itemId, title, 0)
        {
            
        }
        public Book(string itemId): this(itemId, "", 0)
        {
            
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}