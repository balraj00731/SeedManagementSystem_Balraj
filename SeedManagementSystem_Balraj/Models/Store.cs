using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeedManagementSystem_Balraj.Models
{
    public class Store
    {
        public int ID { get; set; }
        public int CropVarietyID { get; set; }
        public decimal Quantity { get; set; }
        public string NoofBags { get; set; }

        public CropVariety CropVariety { get; set; }
    }
}