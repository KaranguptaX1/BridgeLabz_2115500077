using System;
//Parent class
class Order{
    //Protected variables
    protected int OrderId;
    protected string OrderDate;
    //constructor
    public Order(int OrderId,string OrderDate){
        this.OrderId=OrderId;
        this.OrderDate=OrderDate;
    }
    //order status method
    public virtual void GetOrderStatus(){
        Console.WriteLine("Order Status: Pending");
        Console.WriteLine($"Order ID: {OrderId}\n Order Date: {OrderDate}");
    }
}
//Subclass of Order
class ShippedOrder:Order{
    //protected variable
    protected int TrackingNumber;
    //Constructor
    public ShippedOrder(int OrderId,string OrderDate,int TrackingNumber):base(OrderId,OrderDate){
        this.TrackingNumber=TrackingNumber;
    }
    //Override Parent class method
    public override void GetOrderStatus(){
        Console.WriteLine("Order Status: Shipped");
        Console.WriteLine($"Order ID: {OrderId}\n Order Date: {OrderDate}\n Tracking Number: {TrackingNumber}");
        
    }
}
//subclass of ShippedOrder
class DeliverdOrder:ShippedOrder{
    //Private variable
    private string DeliveryDate;
    //Constructor
    public DeliverdOrder(int OrderId,string OrderDate,int TrackingNumber,string DeliveryDate):base(OrderId,OrderDate,TrackingNumber){
        this.DeliveryDate=DeliveryDate;
    }
    //Override methods
    public override void GetOrderStatus(){
        Console.WriteLine("Order Status: Delivered");
        Console.WriteLine($"Order ID: {OrderId}\n Order Date: {OrderDate}\n Tracking Number: {TrackingNumber}\n Delivery Date: {DeliveryDate} ");
        
    }
}
class OrderManagement{
    //MainMethod
    static void Main(string [] args){
        Order order1= new Order(1,"20-02-2025");
        ShippedOrder shippedOrder= new ShippedOrder(2,"19-02-2025",1123);
        DeliverdOrder deliverdOrder= new DeliverdOrder(3,"15-02-2025",112,"20-02-2025");
        order1.GetOrderStatus();
        shippedOrder.GetOrderStatus();
        deliverdOrder.GetOrderStatus();

    }
}

