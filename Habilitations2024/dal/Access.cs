using habilitations2024.bddmanager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations2024.dal
{
    public class Access
    {
        private static readonly string connectionString = "Server=localhost;Database=habilitations;User Id=habilitations;Password=motdepasseuser;";

        private static Access instance = null;

        public BddManager Manager { get; }

        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}
