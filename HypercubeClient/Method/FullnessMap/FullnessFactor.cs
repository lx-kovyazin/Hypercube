using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercube.Client.Method.FullnessMap
{
    public class FullnessFactor
    {
        public FullnessFactor(float value)
            => Value = value;

        public float Value
        {
            get;
            private set;
        }

        private static float CalculateFactor(params Model.Cell[] list)
        {
            float factor = 0;

            if (!list.Length.Equals(0))
            {
                int count = 0;

                foreach (var value in list)
                {
                    if (!string.IsNullOrEmpty(value.FriendlyName) 
                        && !value.FriendlyName.Equals("(null)"))
                    {
                        ++count;
                    }
                }

                factor = count / list.Length * 100.0f;
            }

            return factor;
        }

        public static FullnessFactor Calculate(params Model.Cell[] list)
            => new FullnessFactor(CalculateFactor(list));

    }
}
