using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_design_patterns_sprint
{
    public class ConfigManager
    {
        /// <summary>
        /// NOTE:
        /// In this class, we could use auto-properties like { get; set; } here and 
        /// dispense with the backing field and public properties below...
        /// ... but this syntax is also valid and occasionally seen in older code!
        /// </summary>
        /// 

        private static ConfigManager instance;

        private string databaseUrl;
        private int connectionTimeout;
        private int requestTimeout;
        private int dataCounter = 0;

        private ConfigManager(string databaseUrl, int connectionTimeout, int requestTimeout)
        {
            this.databaseUrl = databaseUrl;
            this.connectionTimeout = connectionTimeout;
            this.requestTimeout = requestTimeout;
        }

        public static ConfigManager GetInstance(string databaseUrl, int connectionTimeout, int requestTimeout)
        {
            if (instance == null)
            {
                instance = new ConfigManager(databaseUrl, connectionTimeout, requestTimeout);
            }
            return instance;
        }

        /// <summary>
        /// This is an explicit property which uses the `databaseUrl` backing field
        /// It's essentially equivalent to a {get; set;} auto-property
        /// But this has the flexibility that we *could* add our own code in the getter/setter
        /// if we wish.
        /// </summary>
        public string DatabaseUrl
        {
            get { return databaseUrl; }
            set { databaseUrl = value; }
        }

        public int ConnectionTimeout
        {
            get { return connectionTimeout; }
            set { connectionTimeout = value; }
        }

        public int RequestTimeout
        {
            get { return requestTimeout; }
            set { requestTimeout = value; }
        }

        public int DataCounter
        {
            get { return dataCounter; }
            set { dataCounter = value; }
        }

        public void IncrementDataCount()
        {
            this.dataCounter++;
        }

        public void DecrementDataCount()
        {
            this.dataCounter--;
        }
    }

}
