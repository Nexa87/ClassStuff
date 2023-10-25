using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet

    {
        public string ItemId;
        public string Design;
        public Level Quality;

        public Amulet(string itemId)
        {
            this.ItemId = itemId;
            this.Quality = Level.medium;
        }
        public Amulet(string itemId, Level quality): this(itemId)
        {
            this.Quality= quality;
        }
        public Amulet(string itemId, Level quality, string design): this(itemId, quality)
        {
            this.Design = design;
        }
        

        
       
        
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
    




