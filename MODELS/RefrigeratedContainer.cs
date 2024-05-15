public class RefrigeratedContainer : Container
{
    public int Temperature { get; private set; }

    public RefrigeratedContainer(int height, int depth, string serialNumber, int tareWeight, int payloadMax, int temperature)
        : base(height, depth, serialNumber, tareWeight, payloadMax)
    {
        Temperature = temperature;
    }

   
    public override void LoadCargo(int mass)
    {
        if (mass > PayloadMax)
        {
            
            throw new OverfillException("Cannot load cargo: exceeds payload max.");
        }
        else
        {
         
            Mass += mass;
            Console.WriteLine($"Cargo loaded. Current mass is now {Mass} kg.");
        }
    }

    // Empties all cargo from the container, setting its mass back to zero.
    public override void UnloadCargo()
    {
        Console.WriteLine($"Unloading cargo. {Mass} kg was removed from the container.");
        Mass = 0;
    }
}