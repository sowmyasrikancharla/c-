using System;

public class InvalidPrinterException:Exception{
	public InvalidPrinterException(string message):base(message){}
}
class Printer{

	public static void IsAvailable(string printer){
		if(printer=="Printer2"){
		throw new InvalidPrinterException("Device Failure:Not Available");
		}
		else{
			Console.WriteLine("Available");
		}
	}

	public static void Main(string [] args){
	try{
		string printer=args[0];
		IsAvailable(printer);
	}
	catch(Exception e){
	Console.WriteLine(e.Message);
}
}
}