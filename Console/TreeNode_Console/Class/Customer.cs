public class Customer : System.Object
{
    private string CustomerName = "";
    protected ArrayList CustomerOrders = new ArrayList();

    public Customer(string customerName)
    {
        this.CustomerName = customerName;
    }

    public string CustomerName
    {
        get { return this.CustomerName; }
        set { this.CustomerName = value; }
    }

    public ArrayList CustomerOrders
    {
        get { return this.CustomerOrders; }
    }
}
