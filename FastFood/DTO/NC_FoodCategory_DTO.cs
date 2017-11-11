using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NC_FoodCategory_DTO
    {
        public int FoodCategoryID { get; set; }
        public string CategoryName { get; set; }

        public NC_FoodCategory_DTO(int id, string cgrName)
        {
            this.FoodCategoryID = id;
            this.CategoryName = cgrName;
        }
    }
}
