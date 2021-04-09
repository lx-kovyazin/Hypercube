using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Hypercube.Control
{
    internal static class ControlExtensions
    {
        internal static object GetDragData(this DragEventArgs e, Type type)
        {
            Debug.Print($"[{nameof(GetDragData)}]: {e.Data.GetData(type)?.GetType()}");
            return e.Data.GetData(type);
        }

        internal static T GetDragData<T>(this DragEventArgs e)
            where T : class
        {
            return e.GetDragData(typeof(T)) as T;
        }

        internal static object GetDragMetaData(this DragEventArgs e, Type type)
        {
            if (type is null)
                return null;

            var data = e.GetDragData(type);
            if (data is null)
            {
                var derivedTypes = type.Assembly
                                       .DefinedTypes
                                       .ToList()
                                       .FindAll(definedType => definedType.BaseType != null && definedType.BaseType.Equals(type));
                foreach(var derivedType in derivedTypes)
                {
                    data = e.GetDragData(derivedType);
                    if (data != null)
                        break;
                };
            }

            return data;
        }
    }
}
