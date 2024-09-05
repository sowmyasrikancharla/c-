using System;
public class InvalidAgeException:Exception{
	public InvalidAgeException(string message):base(message){}
}
public class User{

	public static void details(int age){
		if(age>100 || age<0){
		throw new InvalidAgeException("Age cannot be negative");
}
	else{
	Console.WriteLine("valid");
}
}

	public static void Main(string [] args){

	try{
	int age=Convert.ToInt32(args[0]);
	details(age);
	}
	catch(Exception e){
	Console.Write(e.Message);
	
}

}
}