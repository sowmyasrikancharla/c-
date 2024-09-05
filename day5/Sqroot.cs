using System;
class Sqroot{
	static void Main(string [] args){
		Console.Write("Enter non negative number");
		int n=Convert.ToInt32(Console.ReadLine());
		double res=Math.Round(Math.Sqrt(n));
		Console.WriteLine(res);
}
}