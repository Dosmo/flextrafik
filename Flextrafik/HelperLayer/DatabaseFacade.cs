using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data;
using System.Data.SqlClient;

namespace HelperLayer
{
    public class DatabaseFacade
    {
        SqlConnection conn = new SqlConnection("Server=ealdb1.eal.local;" + "Database=ejl03_db;" + "User Id=ejl03_usr;" + "Password=Baz1nga3;");

        public void AddProductToPlan(int PlanID, int ProductID, double Quantity)
        {
            SqlCommand cmd = new SqlCommand("AddProductToPlan", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PlanID", PlanID));
            cmd.Parameters.Add(new SqlParameter("@ProductID", ProductID));
            cmd.Parameters.Add(new SqlParameter("@Quantity", Quantity));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void GetBud()
        {
            SqlCommand cmd = new SqlCommand("GetBud", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.HasRows && rdr.Read())
            {
                Console.WriteLine(rdr["DB_COLUMN_NAME"]);
            }
            Console.ReadKey();
        }

        public void GetFirma()
        {
            SqlCommand cmd = new SqlCommand("GetFirma", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.HasRows && rdr.Read())
            {
                Console.WriteLine(rdr["DB_COLUMN_NAME"]);
            }
            Console.ReadKey();
        }
        //public void databaseConnect()
        //{

        //}
        //public static List<Firma> GetFirma()
        //{

        //}
    }
}
