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
       
        private static String connexionChaine = "Data Source=P104-14\\SQLEXPRESS2012;Initial Catalog=bdOperation;User ID=conOperation;Password=conOperation";

        #region Query

        /// <summary>
        /// Fait une requète SQL avec paramêtre et retourne un DataSet avec le résultat
        /// </summary>
        /// <param name="SQL">Requète Sql avec des tag pour les paramêtres </param>
        /// <param name="Parameters">Liste de paramêtres</param>
        /// <returns>Les données retournées par la BD</returns>
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

        /// <summary>
        /// Fait une requète SQL et retourne un DataSet avec le résultat
        /// </summary>
        /// <param name="SQL">requète Sql</param>
        /// <returns>Les données retournées par la BD</returns>
        public static DataSet Query(String SQL)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(connexionChaine))
                {
                    Conn.Open();

                    SqlCommand command = new SqlCommand(SQL, Conn);
                    
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
        #endregion

        #region NonQuery

        /// <summary>
        /// Fait une requète SQL avec paramêtre qui ne retourne pas de données
        /// </summary>
        /// <param name="SQL">Requète Sql avec des tag pour les paramêtres</param>
        /// <param name="Parameters">Liste de paramêtres</param>
        /// <returns>Retourne le nombre d'enregistrement affecté</returns>
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

        #endregion



    }
}
