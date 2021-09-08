﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    class ItemQuantity
    {
        public int ItemID { get; set; }
        public int Quantity { get; set; }

        public ItemQuantity(int itemID, int quantity)
        {
            ItemID = itemID;
            Quantity = quantity;
        }
    }
}
