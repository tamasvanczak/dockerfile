using Beadando_IF175R.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_IF175R.Patterns
{
    public class ConsoleLogger:ITrainingObserver
    {
        public void OnEpochEnd(int epoch, double loss)
        {
            Console.WriteLine($">>> [Megfigyelő] {epoch}. kör: A hiba jelenleg {loss:F4}");
        }
    }
}
