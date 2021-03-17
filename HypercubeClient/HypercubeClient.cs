using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging.Console;
using System.Diagnostics;

// TODO: Implement a logger.

namespace Hypercube.Client
{
    public class HypercubeClient
        : IDisposable
    {
        private bool disposedValue;

        // TODO: Implement a connection state change event.
        public AdomdConnection Connection { get; }

        public HypercubeClient()
        {
            try
            {
                Connection = new AdomdConnection("Data Source=localhost;Catalog=HypercubeAS");
            }
            catch (AdomdConnectionException ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        public void Start()
        {
            Connection.Open();
        }

        public void Close()
        {
            Connection.Close();
            Connection.Dispose();
        }

        public AdomdCommand CreateCommand(string commandText) => new AdomdCommand(commandText, Connection);
        public AdomdCommand CreateCommand() => Connection.CreateCommand();

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                    Close();

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
