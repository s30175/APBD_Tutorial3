namespace Tutorial3.Containers;

public class C : Container, IHazardNotifier
{
    private string typeOfProduct;
    private int temperature;
    
    public C(int mass, int height, int tareWeight, int depth, int serialNumber, int maximumPayload) : base(mass, height, tareWeight, depth, serialNumber, maximumPayload)
    {
        
    }

    public override void emptyCargo()
    {
        
    }

    public override void loadCargo(int cargoWeight, string cargoType)
    {
        
    }

    public void sendText()
    {
        
    }
}