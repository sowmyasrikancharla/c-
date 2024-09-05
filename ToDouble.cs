using System;
class ToDouble{
	public static void Main(string [] args){
	Console.Write("Enter a double value");
	string inp=Console.ReadLine();
	double res=double.Parse(inp);
	Console.WriteLine("Entered double value"+res);
}
}