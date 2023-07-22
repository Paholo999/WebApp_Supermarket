using FeatureLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CD_Users
    {
        public List<User> ToList() 
        { 
            List<User> list = new List<User>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Connection.cn)) 
                {
                    string query = "select Id_User,Names,Surnames,Mail,_Key,Resettle,Asset from _User";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader()){
                        while (dr.Read()) 
                        {
                            list.Add(
                                new User()
                                {
                                    Id = Convert.ToInt32(dr["Id_User"]),
                                    Names = dr["Names"].ToString(),
                                    Surnames = dr["Surnames"].ToString(),
                                    Mail = dr["Mail"].ToString(),
                                    Key = dr["_Key"].ToString(),
                                    Resettle = Convert.ToBoolean(dr["Resettle"]),
                                    Asset = Convert.ToBoolean(dr["Asset"])
                                }
                             ) ;  
                        }
                    }
                }
            }
            catch (Exception)
            {
                list= new List<User>();
            }
            return list;
        }
    }
}
