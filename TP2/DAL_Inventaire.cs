using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TP2
{
    class DAL_Inventaire
    {
        //public static struct Inventaire
        //{
        //    int IdInventaire;
        //    String DescriptionInventaire;
        //    int IdFournisseur;
        //    int QteStock;
        //    int QteMinimum;
        //    int QteMaximum;
        //}
        public class Param
        {
            public Param(object value, DbType type)
            {

                Value = value;
                Type = type;
            }

            public override string ToString()
            {
                return Value.ToString();
            }
            public object Value { get; private set;}
            public DbType Type {  get; private set; }

            
        }

        private static  SqlConnection Conn;
        private static String connexionChaine = "Data Source=P104-14\\SQLEXPRESS2012;Initial Catalog=bdOperation;User ID=conOperation;Password=conOperation";

        private static SqlConnection MakeConnection()
        {
            try 
	        {	        
		        return new SqlConnection(connexionChaine);
	        }
	        catch (Exception e) 
	        {
		
		        throw new Exception("La connexion n'as pus être établie: "+e.Message);
	        }
            
        }

        private static void CloseConnection()
        {
            try
            {
                if(Conn != null)
                Conn = new SqlConnection(connexionChaine);
            }
            catch (Exception e)
            {

                throw new Exception("La connexion n'as pus être établie: " + e.Message);
            }
        }

        //public static List<Inventaire> QueryInventaire(String SQL, Dictionary<String, String> Parameters)
        //{
        //    try 
        //    {
        //        using (SqlConnection Conn = new SqlConnection(connexionChaine))
        //        {
        //            Conn.Open();
                    
        //            SqlCommand command = new SqlCommand(SQL, Conn);
        //            foreach (KeyValuePair<String, String> Parameter in Parameters)
        //            {
        //                command.Parameters.Add(new SqlParameter(Parameter.Key, Parameter.Value));
        //            }
        //            command.Prepare();

        //            DataSet carryData = new DataSet();

        //            SqlDataAdapter adapter = new SqlDataAdapter(command);
        //            adapter.fill(carryData,"Inventaire");

        //            return carryData;


                    
        //        }
        //    }
        //    catch (Exception e)
        //    {
		
        //        throw e;
        //    }
        //}

        public static DataSet Query(String SQL, Dictionary<String, Object> Parameters)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(connexionChaine))
                {
                    Conn.Open();

                    SqlCommand command = new SqlCommand(SQL, Conn);

                    //paramêtrise les values
                    foreach (KeyValuePair<String, Object> Parameter in Parameters)
                    {
                        command.Parameters.AddWithValue(Parameter.Key, Parameter.Value);
                    }
                    

                    DataSet carryData = new DataSet();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(carryData, "Inventaire");

                    return carryData;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static int NonQuery(String SQL, Dictionary<String, Object> Parameters)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(connexionChaine))
                {
                    Conn.Open();

                    SqlCommand command = new SqlCommand(SQL, Conn);

                    //paramêtrise les values
                    foreach (KeyValuePair<String, Object> Parameter in Parameters)
                    {
                        command.Parameters.AddWithValue(Parameter.Key, Parameter.Value);
                    }


                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {

                throw e;
            }                   
        }
        
         
    }
}
