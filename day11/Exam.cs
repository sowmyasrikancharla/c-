using System;
class Exam{
	public static void Main(string [] args){
	try{
	Console.Write("Enter the value of a: ");
	int a=Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter the value of b: ");
	int b=Convert.ToInt32(Console.ReadLine());
	int c=a/b;
	Console.WriteLine(c);
	}
	catch(ArithmeticException e){
	Console.WriteLine(e.Message);
	}
	catch(FormatException e1){
	Console.WriteLine(e1.Message);
}
}
}