public abstract class Container
{
    public int Mass { get; protected set; }
    public int Height { get; private set; }
    public int Depth { get; private set; }
    public string SerialNumber { get; private set; }
    public int TareWeight { get; private set; }
    public int PayloadMax { get; private set; }

    protected Container(int height, int depth, string serialNumber, int tareWeight, int payloadMax)
    {
        Height = height;
        Depth = depth;
        SerialNumber = serialNumber;
        TareWeight = tareWeight;
        PayloadMax = payloadMax;
    }

    public abstract void LoadCargo(int mass);
    public abstract void UnloadCargo();
}