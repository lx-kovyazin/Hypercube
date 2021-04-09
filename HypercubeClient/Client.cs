using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Data;
using Hypercube.Client.Model;

// TODO: Implement a logger.

namespace Hypercube.Client
{
    public class Client
    {
        private static readonly Client client = new Client();

        public static Client Instance => client;

        public ConnectionString ConnectionString { get; private set; }

        // TODO: Implement a connection state change event.
        public AdomdConnection Connection { get; private set; }
        public MetaInfo MetaInfo { get; private set; }
        private Client()
        { }

        public event Action ConnectionChanged;

        public bool Connect(ConnectionString connectionString)
        {
            if (Connection?.State is ConnectionState.Open)
                Disconnect();

            //var oldConnectionString = ConnectionString;
            ConnectionString = connectionString;
            Connection = new AdomdConnection(connectionString.ToString());
            try
            {
                Connection.Open();
            }
            catch (AdomdConnectionException ex)
            {
                Debug.Print(ex.ToString());
                return false;
            }
            MetaInfo = new MetaInfo(this);
            ConnectionChanged.Invoke();
            return true;
        }

        public bool Reconnect()
        {
            return Connect(ConnectionString);
        }

        public void Disconnect()
        {
            try
            {
                Connection.Close();
                Connection.Dispose();
            }
            catch (AdomdConnectionException ex)
            {
                Debug.Print(ex.ToString());
                throw;
            }
        }

        public Command CreateCommand(ICommandProvider commandProvider)
            => new Command(this, commandProvider);
    }
}
