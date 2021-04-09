using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercube.Client.Model
{
    public interface IMetaModel
    {
        string FriendlyName { get; }
        string UniqueName { get; }
    }
}
