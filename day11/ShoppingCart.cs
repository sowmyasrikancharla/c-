using System;
public class BulkStockException:Exception{
	public BulkStockException(string message):base(message){}
}
public class ShoppingCart{

	public static void addToCart(string name,int quantity){
		if(quantity>10){
		throw new BulkStockException("Error:");
}
	else{
	Console.WriteLine("{0} units of {1} added to the cart.",quantity,name);
}
}

	public static void Main(string [] args){
	string name=args[0];

	try{
	int quantity=Convert.ToInt32(args[1]);
	addToCart(name,quantity);
	}
	catch(Exception e){
	Console.Write(e.Message);
	Console.WriteLine("The {0} cannot be ordered in quantities of more than 10 units.",name);
	
}

}
}