using System;
class Pension{
	public static void Main(string [] args){
		Console.Write("Enter your name:");
		string name=Console.ReadLine();
		Console.Write("Enter your age:");
		string age=Console.ReadLine();
		int agee=Convert.ToInt32(age);
		Console.WriteLine("Hello "+name);
		Console.WriteLine("You were born in the year "+(2024-agee));
		if(agee<18){
			Console.WriteLine("You are a minor");
		}
		else if(agee>18 && agee<65){
			Console.WriteLine("You are an adult");
		}
		else{
			Console.WriteLine("You are a senior citizen");
		}
}
}