public class Order : System.Object
{
    private string OrderId = "";
    
    public Order(string orderId)
    {
        this.OrderId = orderId;
    }

    public string OrderId
    {
        get { return this.OrderId; }
        set { this.OrderId = value; }
    }
}