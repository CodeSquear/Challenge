private ArrayList customerArray = new ArrayList();

void FillMyTreeView()
{
    for(int i = 0; i < 1000; i++)
        customerArray.Add(new Customer("Customer" + i.ToString()));

    foreach(var item in customerArray)
        for(int i = 0; i < 15; i++)
            item.CustomerOrders.Add(new Order("Order" + i.ToString()));


    Cursor.Current = new Cursor("MyWait.cur");
    treeView1.BeginUpdate();

    foreach(var item in customerArray)
    {
       treeView1.Nodes.Add(new TreeNode(item.CustomerName));

       foreach(var order in item.CustomerOrders)
            treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Add(new TreeNode(order.OrderId));
    }

    Cursor.Current = Cursors.Default;

    treeView1.EndUpdate();
}