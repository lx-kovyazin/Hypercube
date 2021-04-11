using Hypercube.Client.Extensions;
using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Hypercube.Client
{
    public class Command
    {
        private readonly Client client;
        private readonly ICommandProvider commandProvider;

        public Command(Client client, ICommandProvider commandProvider)
        {
            this.client = client;
            this.commandProvider = commandProvider;
        }

        private AdomdCommand Create()
        {
            Debug.Print($"{nameof(Create)} by {commandProvider.Name}");
            return new AdomdCommand(commandProvider.Command, client.Connection);
        }

        public CellSet ExecuteCellSet() => Create().Start().ExecuteCellSet().Stop();
        public AdomdDataReader ExecuteReader() => Create().ExecuteReader();
        public XmlReader ExecuteXmlReader() => Create().ExecuteXmlReader();
        public int ExecuteNonQuery() => Create().ExecuteNonQuery();
    }
}
