using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise

    {
        
        public string Design;
        public Level Quality;

        public Amulet(string itemId, Level quality, string design)
        {
            Design = design;
            Quality = quality;
            base.ItemId = itemId;   
            

        }
        public Amulet(string itemId, Level quality): this(itemId, quality, "") 
        {
            
        }
        
        public Amulet(string itemId): this(itemId,Level.medium,"")
        {
            
        }

        
       
        
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
    




