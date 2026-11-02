using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_IF175R.Interfaces
{
    public interface ITrainingObserver
    {
        void OnEpochEnd(int epoch, double loss);
    }
}
