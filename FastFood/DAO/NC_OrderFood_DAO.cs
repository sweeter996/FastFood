using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class NC_OrderFood_DAO : HP_SetConnect_DAO
    {
        public List<NC_OrderFood_DTO> GetData(int CategoryID)
        {
            Connect();
            List<NC_OrderFood_DTO> listFood = new List<NC_OrderFood_DTO>();
            string sql = "SELECT * FROM Foods WHERE FoodCategoryID = " + CategoryID;
            try
            {
                SqlDataReader dr = excuteNonquery(sql);
                int id, foodCgrID;
                string foodName, note;
                double price;
                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                    foodName = dr.GetString(1);
                    foodCgrID = dr.GetInt32(2);
                    price = dr.GetDouble(3);
                    note = dr[4].ToString();
                    NC_OrderFood_DTO food = new NC_OrderFood_DTO(id, foodName, foodCgrID, price, note);
                    listFood.Add(food);
                }
                dr.Close();
                return listFood;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public List<NC_FoodCategory_DTO> GetCategory()
        {
            Connect();
            List<NC_FoodCategory_DTO> listCategory = new List<NC_FoodCategory_DTO>();
            string sql = "SELECT * FROM FoodCategories";
            try
            {
                SqlDataReader dr = excuteNonquery(sql);
                int id;
                string Name;
                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                    Name = dr.GetString(1);
                    NC_FoodCategory_DTO Category = new NC_FoodCategory_DTO(id, Name);
                    listCategory.Add(Category);
                }
                dr.Close();
                return listCategory;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DisConnect();
            }
        }
    }
}
