using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_IF175R.Interfaces
{
    public interface ILossStrategy
    {
        double CalculateLoss(double target, double output);
        string GetStrategyName();
    }
}
