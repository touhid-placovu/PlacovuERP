using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Core.Security
{
    public sealed class ConnectionStringHelper
    {
        private static ConnectionStringHelper _connectionStringHelper = null;
        private string _ontrackHelthConnectionString = null;
        private string _uronavRegistryConnectionString = null;
        private static bool? _doNotUseEncryption = null;

        private static string GetConnectionString(string appSettingKey)
        {
            string encryptConnectionString = ConfigurationManager.AppSettings.Get(appSettingKey);
            string decryptConnectionString = CryptographyHelper.Decrypt(encryptConnectionString);
            return decryptConnectionString;
        }
        private static bool DoNotUseEncryption()
        {
            if (_doNotUseEncryption == null)
            {
                _doNotUseEncryption = ConfigurationManager.ConnectionStrings["Placovu.ErpEntities"] != null;
            }
            return _doNotUseEncryption.GetValueOrDefault();
        }

        public static string OntrackHelthConnectionString
        {
            get
            {
                if (DoNotUseEncryption())
                    return "name=Placovu.ErpEntities";

                if (_connectionStringHelper?._ontrackHelthConnectionString != null)
                    return _connectionStringHelper._ontrackHelthConnectionString;

                _connectionStringHelper = new ConnectionStringHelper { _ontrackHelthConnectionString = GetConnectionString("OntrackHelth.Database.ConnectionString") };
                return _connectionStringHelper._ontrackHelthConnectionString;
            }
        }

        public static string UronavRegistryConnectionString
        {
            get
            {
                if (DoNotUseEncryption())
                    return "name=UronavRegistryContext";

                if (_connectionStringHelper?._uronavRegistryConnectionString != null)
                    return _connectionStringHelper._uronavRegistryConnectionString;

                _connectionStringHelper = new ConnectionStringHelper { _uronavRegistryConnectionString = GetConnectionString("UronavRegistry.Database.ConnectionString") };
                return _connectionStringHelper._uronavRegistryConnectionString;
            }
        }
    }
}
