using Beadando_IF175R.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_IF175R.Core
{
    public class NeuralNetwork
    {
        private List<ITrainingObserver> observers = new List<ITrainingObserver>();

        public void Subscribe(ITrainingObserver observer)
        {
            observers.Add(observer);
        }

        public void RunTraining(int totalEpochs, ILossStrategy strategy)
        {
            for (int i = 1; i <= totalEpochs; i++)
            {
                double currentLoss = strategy.CalculateLoss(1.0, 0.7 + (i * 0.05));

                NotifyObservers(i, currentLoss);
            }
        }

        private void NotifyObservers(int epoch, double loss)
        {
            foreach (var observer in observers)
            {
                observer.OnEpochEnd(epoch, loss);
            }
        }


    }
}
