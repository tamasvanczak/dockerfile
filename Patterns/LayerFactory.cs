using Beadando_IF175R.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_IF175R.Patterns
{
    public static class LayerFactory
    {
        public static Layer CreateLayer(string type, string name)
        {
            return type.ToLower() switch
            {
                "dense" => new DenseLayer { Name = name },
                "dropout" => new DropoutLayer { Name = name },
                _ => throw new ArgumentException($"Ismeretlen rétegtípus: {type}")
            };
        }
    }
}
