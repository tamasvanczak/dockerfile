using Beadando_IF175R.Core;
using Beadando_IF175R.Interfaces;
using Beadando_IF175R.Models;
using Beadando_IF175R.Patterns;

class Program
{
    static void Main(string[] args)
    {
        ILossStrategy lossFunc = new MseLoss();

        var layers = new List<Layer>();
        layers.Add(LayerFactory.CreateLayer("dense", "Bemeneti réteg"));
        layers.Add(LayerFactory.CreateLayer("dropout", "Zajszűrés"));
        layers.Add(LayerFactory.CreateLayer("dense", "Kimeneti réteg"));

        Console.WriteLine($"Hálózat indítása {lossFunc.GetStrategyName()} használatával...\n");

        foreach (var layer in layers)
        {
            layer.PrintInfo();
            layer.Forward();
        }

        double hiba = lossFunc.CalculateLoss(1.0, 0.75);
        Console.WriteLine($"\nVégső hiba értéke: {hiba:F4}");


        var network = new NeuralNetwork();
        var logger = new ConsoleLogger();

        network.Subscribe(logger);

        network.RunTraining(5, new MseLoss());
    }
}