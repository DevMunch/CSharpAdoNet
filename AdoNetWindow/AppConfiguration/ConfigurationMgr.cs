using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace AppConfiguration
{
    public class ConfigurationMgr
    {
        private static ConfigurationMgr instance;
        public string ConnectionString { get; set; }
        IDbConnection connection;
        public IDbConnection Connection
        {
            get 
            {
                if(connection == null)
                    connection = new SqlConnection(ConnectionString);
                if(connection.State != ConnectionState.Open) // 인스턴스는 있지만 닫혀있다면.
                    connection.Open();
                return connection;
            }
            private set { }
        }
        private ConfigurationMgr()
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                // DB접속을 위한 파일을 읽어온다.
                LoadConfiguration();
            }
        }

        private void LoadConfiguration()
        {
            // App.config를 읽어온다.
            Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionString = currentConfig.ConnectionStrings.ConnectionStrings["WinConnection"].ConnectionString;
        }
        public static ConfigurationMgr Instance()
        {
            if(instance == null)
                instance = new ConfigurationMgr();
            return instance;
        }
    }
}