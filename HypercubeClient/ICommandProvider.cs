using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercube.Client
{
    public interface ICommandProvider
    {
        string Name { get; }
        string Command { get; }
    }
}
