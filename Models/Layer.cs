using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_IF175R.Models
{
    public abstract class Layer
    {
        public string Name { get; set; }
        public abstract void Forward();
        public void PrintInfo() => Console.WriteLine($"Réteg: {Name} [{this.GetType().Name}]");
    }
}
