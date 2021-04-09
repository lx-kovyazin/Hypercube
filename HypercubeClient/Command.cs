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
    internal static class StopwatchExtensions
    {
        internal static Stopwatch stopwatch;

        internal static T Start<T>(this T instance)
        {
            Debug.Print($"[Start] Type: {typeof(T)}");
            stopwatch = Stopwatch.StartNew();
            return instance;
        }

        internal static T Stop<T>(this T instance)
        {
            stopwatch.Stop();
            Debug.Print($"[Stop] Type: {typeof(T)}");
            Debug.Print($"[Stop] Elapsed: {stopwatch.Elapsed}");
            return instance;
        }
    }

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
