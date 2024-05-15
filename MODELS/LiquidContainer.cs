public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; private set; }

    public LiquidContainer(int height, int depth, string serialNumber, int tareWeight, int payloadMax, bool isHazardous)
        : base(height, depth, serialNumber, tareWeight, payloadMax)
    {
        IsHazardous = isHazardous;
    }

    
    public override void LoadCargo(int mass)
    {
        
        if (IsHazardous && mass > PayloadMax * 0.5)
        {
            NotifyHazard($"Attempt to overload a hazardous cargo: {mass} kg exceeds 50% of payload max.");
            throw new OverfillException("Cannot load hazardous cargo: exceeds 50% of payload max.");
        }
        
        else if (!IsHazardous && mass > PayloadMax * 0.9)
        {
            NotifyHazard($"Attempt to overload a non-hazardous cargo: {mass} kg exceeds 90% of payload max.");
            throw new OverfillException("Cannot load non-hazardous cargo: exceeds 90% of payload max.");
        }
        else
        {
            Mass += mass;
            Console.WriteLine($"Successfully loaded {mass} kg. Current total mass: {Mass} kg.");
        }
    }

    
    public override void UnloadCargo()
    {
        Console.WriteLine($"Unloading all cargo. {Mass} kg has been removed from the container.");
        Mass = 0;
    }

    
    public void NotifyHazard(string message)
    {
        Console.WriteLine($"Hazard warning: {message}");
    }
}