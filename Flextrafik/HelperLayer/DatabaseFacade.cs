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

        public List<Bud> GetBud()
        {
            List<Bud> bids = new List<Bud>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetBud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CVRNummer", null));

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Firms.Add(new Firma(rdr["CVRNummer"].ToString(), rdr["AndetFirma"].ToString(), rdr["Navn"].ToString()));
                }
                rdr.Close();
            }
            catch (SqlException e)
            {
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return Firms;
        }

        public List<Firma> GetFirma()
        {
            List<Firma> Firms = new List<Firma>();
            try 
	        {	        
		        conn.Open();
                SqlCommand cmd = new SqlCommand("GetFirma", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CVRNummer", null));
            
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Firms.Add(new Firma(rdr["CVRNummer"].ToString(), rdr["AndetFirma"].ToString(), rdr["Navn"].ToString()));
                }
                rdr.Close();
	        }
	        catch (SqlException e)
	        {
	        }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            
            return Firms;
        }
    }
}