using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data.SqlClient;

namespace BUS
{
    public class NC_OrderFood_BUS
    {
        public List<NC_OrderFood_DTO> GetData(int CategoryID)
        {
            try
            {
                return (new NC_OrderFood_DAO().GetData(CategoryID));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public List<NC_FoodCategory_DTO> GetCategory()
        {
            try
            {
                return (new NC_OrderFood_DAO().GetCategory());
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
