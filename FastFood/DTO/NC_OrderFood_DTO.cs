using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NC_OrderFood_DTO
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int FoodCgrID { get; set; }
        public double Price { get; set; }
        public string Note { get; set; }

        public NC_OrderFood_DTO(int foodID, string foodName, int foodCgrID, double price, string note)
        {
            this.FoodID = foodID;
            this.FoodName = foodName;
            this.FoodCgrID = foodCgrID;
            this.Price = price;
            this.Note = note;
        }
    }
}
