namespace Tutorial3.Containers;

public class L : Container, IHazardNotifier
{
    public L(int mass, int height, int tareWeight, int depth, int serialNumber, int maximumPayload) : base(mass, height, tareWeight, depth, serialNumber, maximumPayload)
    {
        
    }

    public override void emptyCargo()
    {
        mass = 0;
    }

    public override void loadCargo(int cargoWeight, string cargoType)
    {
        if (cargoWeight > maximumPayload)
        {
            throw new OverfillException();
        }

        if (cargoType is "fuel")
        {
            if (mass + cargoWeight > 0.5 * maximumPayload)
            {
                throw new OverfillException();
            }
        }

        if (cargoWeight > 0.9 * maximumPayload)
        {
            reportViolation();
        }
        
        mass += cargoWeight;
    }

    public void sendText()
    {
        Console.WriteLine("Hazardous event happened on liquid container with serial number: " + serialNumber + "!");
    }

    public void reportViolation()
    {
        Console.WriteLine("Violation reported");
    }
}