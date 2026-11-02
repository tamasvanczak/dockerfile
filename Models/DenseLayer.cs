using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_IF175R.Models
{
    public class DenseLayer:Layer
    {
        public override void Forward()
        {
            Console.WriteLine($" -> {Name}: Súlyok és bemenetek szorzása...");
        }
    }
}
