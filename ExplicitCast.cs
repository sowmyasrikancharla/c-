using System;
class ExplicitCast{
	public static void Main(){
		double price=62382;
		float price_f=(float)price;
		long price_l=(long)price;
		int price_i=(int)price;
		Console.WriteLine(price_f.GetType());
		Console.WriteLine(price_l.GetType());
		Console.WriteLine(price_i.GetType());

	}
}