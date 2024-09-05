using System;
class Variabless{

	static int stat1=30;	
	static int stat2=20;		
	public static void Main(){
		int inst1=10;
		int inst2=20;
		Console.WriteLine("Sum of Two instance variables "+(inst1+inst2));
		Console.WriteLine("Difference of two static variables "+(stat1-stat2));
		Console.WriteLine("Product of two static variables "+stat1*inst1);
		inst2=45;
		Console.WriteLine("Reassign of instance variable" +inst2);
		Console.WriteLine("Division of reassigned instance variable and instance variable "+(inst2/inst1));	
	}
}