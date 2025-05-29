using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Habilitations2024.bddmanager
{
    public class BddManager
    {
        private MySqlConnection connection;
        private static BddManager instance;

        private BddManager(string chaineConnexion)
        {
            connection = new MySqlConnection(chaineConnexion);
            connection.Open();
        }

        public static BddManager GetInstance(string chaineConnexion)
        {
            if (instance == null)
            {
                instance = new BddManager(chaineConnexion);
            }
            return instance;
        }

        public void reqUpdate(string req, Dictionary<string, object> parametres = null)
        {
            MySqlCommand command = new MySqlCommand(req, connection);

            if (parametres != null)
            {
                foreach (KeyValuePair<string, object> param in parametres)
                {
                    command.Parameters.Add(new MySqlParameter(param.Key, param.Value));
                }
            }

            command.Prepare();
            command.ExecuteNonQuery();
        }
    }
}
