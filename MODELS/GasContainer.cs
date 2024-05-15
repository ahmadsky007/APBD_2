using System;
using YourNamespace.Interfaces;  
using YourNamespace.Exceptions;  

namespace YourNamespace.Models
{
    public class GasContainer : Container, IHazardNotifier
    {
        public double Pressure { get; set; }

        public GasContainer(int height, int depth, string serialNumber, int tareWeight, int payloadMax, double pressure)
            : base(height, depth, serialNumber, tareWeight, payloadMax)
        {
            Pressure = pressure;
        }

        public override void LoadCargo(int mass)
        {
            if (mass > PayloadMax)
            {
                NotifyHazard($"Attempt to overload with {mass} kg, which exceeds the payload capacity of {PayloadMax} kg.");
                throw new OverfillException("Loading failed: mass exceeds payload capacity.");
            }
            
            Mass += mass;
            Console.WriteLine($"Gas loaded: Current total mass is {Mass} kg at {Pressure} atmospheres.");
        }

        public override void UnloadCargo()
        {
            
            int massToRemain = (int)(Mass * 0.05);
            int massRemoved = Mass - massToRemain;
        Mass = massToRemain;
            Console.WriteLine($"Unloaded {massRemoved} kg of gas. {Mass} kg remains in the container to maintain pressure stability.");
        }

        public void NotifyHazard(string message)
        {
            Console.WriteLine($"Hazard Alert for Gas Container {SerialNumber}: {message}");
        }
    }
}
