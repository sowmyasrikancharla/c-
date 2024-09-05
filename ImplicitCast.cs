using System;
class ImplicitCast{
	public static void Main(){
	int a=10;
	long b=a;
	double c=b;
	Console.WriteLine(a.GetType());
	Console.WriteLine(b.GetType());
	Console.WriteLine(c.GetType());
	}
}
