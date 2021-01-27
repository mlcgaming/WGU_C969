using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WGU_C969 {
    public static class Settings {
        private static string settingsFilename = "settings.xml";

        private static string databaseServerUrl;
        private static int databasePort;
        private static string databaseSchema;
        private static string databaseUsername;
        private static string databasePassword;
        private static string databaseConnectionUrl;

        public static string DBServer {
            get { return databaseServerUrl; }
        }
        public static int DBPort {
            get { return databasePort; }
        }
        public static string DBSchema {
            get { return databaseSchema; }
        }
        public static string DBUser {
            get { return databaseUsername; }
        }
        public static string DBConnectionString {
            get { return databaseConnectionUrl; }
        }

        public static void Initialize() {
            if(File.Exists(settingsFilename)) {
                LoadFromFile();
            }
            else {
                LoadFromNull();
            }

            databaseConnectionUrl = $"SERVER={DBServer}; PORT={DBPort}; DATABASE={DBSchema}; UID={DBUser}; PASSWORD={databasePassword};";
        }

        private static void LoadFromFile() {
            XDocument settings = XDocument.Load(settingsFilename);
            XElement connectionElement = settings.Element("Settings").Element("Connection");

            databaseServerUrl = connectionElement.Element("Server").Value;
            databasePort = int.Parse(connectionElement.Element("Port").Value);
            databaseSchema = connectionElement.Element("Schema").Value;
            databaseUsername = connectionElement.Element("User").Value;
            databasePassword = connectionElement.Element("Password").Value;
        }
        private static void LoadFromNull() {
            databaseServerUrl = "wgudb.ucertify.com";
            databasePort = 3306;
            databaseSchema = "U07v8q";
            databaseUsername = "U07v8q";
            databasePassword = "53689143851";

            XElement settingsElement = new XElement("Settings");
            XElement connectionElement = new XElement("Connection");

            XElement dbServerElement = new XElement("Server", databaseServerUrl);
            XElement dbPortElement = new XElement("Port", databasePort);
            XElement dbSchemaElement = new XElement("Schema", databaseSchema);
            XElement dbUserElement = new XElement("User", databaseUsername);
            XElement dbPasswordElement = new XElement("Password", databasePassword);

            connectionElement.Add(dbServerElement);
            connectionElement.Add(dbPortElement);
            connectionElement.Add(dbSchemaElement);
            connectionElement.Add(dbUserElement);
            connectionElement.Add(dbPasswordElement);

            settingsElement.Add(connectionElement);

            XDocument settingsFile = new XDocument();

            settingsFile.Add(settingsElement);
            settingsFile.Save(settingsFilename);
        }
    }
}
