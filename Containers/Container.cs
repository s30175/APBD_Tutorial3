namespace Tutorial3.Containers;

public abstract class Container
{
    protected int mass;
    protected int height;
    protected int tareWeight;
    protected int depth;
    protected int serialNumber;
    protected int maximumPayload;

    public Container(int mass, int height, int tareWeight, int depth, int serialNumber, int maximumPayload)
    {
        this.mass = mass;
        this.height = height;
        this.tareWeight = tareWeight;
        this.depth = depth;
        this.serialNumber = serialNumber;
        this.maximumPayload = maximumPayload;
    }

    public abstract void emptyCargo();

    public abstract void loadCargo(int cargoWeight, string cargoType);
}