using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data
{
    public class ConnectionString
    {
        private Dictionary<string, string> mValues = new Dictionary<string, string>();

        public ConnectionString(string connectionString)
        {
            string[] param = connectionString.Split(';');
            param.ToList().ForEach(p =>
            {
                if (p.Length > 0)
                {
                    string[] values = p.Split('=');
                    mValues.Add(values[0], values[1]);
                }
            });
        }

        private string GetValue(string key)
        {
            return mValues.ContainsKey(key) ? mValues[key] : null;
        }

        public string UserId { get { return GetValue("User Id"); } }
        public string Database { get { return GetValue("Database"); } }
        public string Server { get { return GetValue("Server"); } }
        public string Password { get { return GetValue("Password"); } }
    }

    public static class ConnectionStringExtensions
    {
        public static ConnectionString AsConnectionString(this string connectionString)
        {
            return new ConnectionString(connectionString);
        }
    }
}
