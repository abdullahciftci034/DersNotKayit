using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DersNotKayit.SqlConnectionClass
{
    public class SqlConnectionDataBase
    {
        private string connectionString = "Data Source=ABDULLAHPC\\SQLEXPRESS;Initial Catalog=ogrencikayit;Integrated Security=True";

        public List<ogrencipuan> OgrenciKayitSelect()
        {
            List<ogrencipuan> ogrencipuans = new List<ogrencipuan>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
               
                string querystring = "SELECT * FROM [ogrencikayit].[dbo].[ogrencipuan];";
                SqlCommand command = new SqlCommand(querystring, sqlConnection);

                sqlConnection.Open();
                    
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {     
                        int id = Convert.ToInt32(reader["id"]);
                        string name = reader["name"].ToString();
                        int puan = Convert.ToInt32(reader["puan"]);
                        ogrencipuans.Add(new ogrencipuan(id, puan, name));
                        
                    }
                }
            }
            return ogrencipuans;
        }
        public DataTable OgrenciKayitSelect1()
        {

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string querystring = "SELECT * FROM [ogrencikayit].[dbo].[ogrencipuan];";
            SqlCommand command = new SqlCommand(querystring, sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
         public ogretmen ogretmenPasswordControl(String tcno)
        {
            ogretmen ogretmens = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string querystring = "SELECT * FROM [ogrencikayit].[dbo].[ogretmen] WHERE tcno = " + tcno;
                SqlCommand command = new SqlCommand(querystring, sqlConnection);
                sqlConnection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        int id = Convert.ToInt32(reader["id"]);
                        int sda = Convert.ToInt32(reader["tcno"]);
                        string  password = reader["password"].ToString();
                        ogretmens = new ogretmen(id,sda,password);

                    }
                }
            }
          
            return ogretmens;
        }
    }
}
