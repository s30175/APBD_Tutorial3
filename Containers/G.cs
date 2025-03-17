namespace Tutorial3.Containers;

public class G : Container, IHazardNotifier
{
    public G(int mass, int height, int tareWeight, int depth, int serialNumber, int maximumPayload) : base(mass, height, tareWeight, depth, serialNumber, maximumPayload)
    {
        
    }

    public override void emptyCargo()
    {
        mass -= (int)(0.95 * mass);
    }

    public override void loadCargo(int cargoWeight)
    {
        if (cargoWeight > maximumPayload)
        {
            throw new OverfillException();
        }
    }

    public void sendText()
    {
        Console.WriteLine("Hazardous event happened on liquid container with serial number: " + serialNumber + "!");
    }
}