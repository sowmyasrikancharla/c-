using System;
class InputEx{
	public static void Main(String [] args){
		Console.Write("Enter the number");
		string price=Console.ReadLine();
		float price_f=Convert.ToSingle(price);
		long price_l=Convert.ToInt64(price_f);
		int price_i=Convert.ToInt32(price_f);
		Console.WriteLine("After narrowing values are:");
		Console.WriteLine("Float value"+price_f);
		Console.WriteLine("Long value"+price_l);
		Console.WriteLine("Int value"+price_i);


	}
}