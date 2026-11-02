using Beadando_IF175R.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_IF175R.Patterns
{
    public class MaeLoss:ILossStrategy
    {
        public double CalculateLoss(double target, double output)
        {
            return Math.Abs(target - output);
        }

        public string GetStrategyName()
        {
            return "Átlagos Abszulót Hiba (MSE)";
        }
    }
}
