using NotificationList.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NotificationList.Controllers.DAO
{
    internal class OverGroupDAO
    {
        internal List<OverGroup> FetchDataFullPopulation(string connectionstring, string queryString)
        {
            List<OverGroup> return_list = new List<OverGroup>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OverGroup np = new OverGroup();
                        np.relativityid = reader.IsDBNull(0) ? "" : reader.GetString(0);
                        np.CRA_UNIQUE_ID = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        np.CRA_PARENT_RECORD_ID = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        np.FIRSTNAME = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        np.MIDDLENAME = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        np.LASTNAME = reader.IsDBNull(5) ? "" : reader.GetString(5);
                        np.SSN = reader.IsDBNull(6) ? "" : reader.GetString(6);
                        np.BIRTHDATE = reader.IsDBNull(7) ? "" : reader.GetString(7);
                        np.EIN = reader.IsDBNull(8) ? "" : reader.GetString(8);
                        np.CRA_MERGED_ADDRESS = reader.IsDBNull(9) ? "" : reader.GetString(9);
                        np.Review_Flag = reader.IsDBNull(10) ? "" : reader.GetString(10);

                        return_list.Add(np);
                    }
                }
                reader.Close();
                command.Connection.Close();
                return return_list;
            }
        }

        internal List<Entity> FetchEntity(string connectionstring, string queryString)
        {
            List<Entity> return_list = new List<Entity>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Entity np = new Entity();
                        np.PARENT_RECORD = reader.IsDBNull(0) ? "" : reader.GetString(0);
                        np.ENT = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        np.SSN = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        np.BIRTHDATE = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        np.EIN = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        np.MERGED_ADDRESS = reader.IsDBNull(5) ? "" : reader.GetString(5);
                        np.Review_Flag = reader.IsDBNull(6) ? "" : reader.GetString(6);

                        return_list.Add(np);
                    }
                }
                reader.Close();
                command.Connection.Close();
                return return_list;
            }
        }

        internal List<NotificationPopulation> FetchNotificationPopulation(string connectionstring, string queryString)
        {
            List<NotificationPopulation> return_list = new List<NotificationPopulation>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        
                        NotificationPopulation np = new NotificationPopulation();
                        np.CRA_PARENT_RECORD_ID = reader.IsDBNull(0) ? "" : reader.GetString(0);
                        np.FIRSTNAME = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        np.MIDDLENAME = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        np.LASTNAME = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        np.Suffix = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        np.Entity = reader.IsDBNull(5) ? "" : reader.GetString(5);
                        np.SSN = reader.IsDBNull(6) ? "" : reader.GetString(6);
                        np.BIRTHDATE = reader.IsDBNull(7) ? "" : reader.GetString(7);
                        np.EIN = reader.IsDBNull(8) ? "" : reader.GetString(8);
                        np.CRA_MERGED_ADDRESS = reader.IsDBNull(9) ? "" : reader.GetString(9);
                        np.Review_Flag = reader.IsDBNull(10) ? "" : reader.GetString(10);

                        return_list.Add(np);
                    }
                }
                reader.Close();
                command.Connection.Close();
                return return_list;
            }
        }


        internal bool UpdateReviewFlag(string connectionstring, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.CommandText = queryString;
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return true;
        }
    }
}
