// Marks greater than or equal to 90 and Marks less than or equal to 100 as 1st Rank,
// Marks greater than or equal to 75 and Marks less than 90 as 2nd Rank,
//Marks greater than or equal to 50 and Marks less than 75 as 3rd Rank,
//Marks greater than or equal to 35 and Marks less than 50 as just passed,
//Marks greater than or equal to 10 and Marks less than 35 as failed
//Any Other Marks as "Invalid credentials. Please enter valid marks."


using System;
class Marks{
	public static void Main(string [] args){
		Console.rite("Enter You Marks:");
		string mark=Console.ReadLine();
		int marks=Convert.ToInt32(mark);
		if(marks>=90 && marks<100){
			Console.WriteLine( "Congratulations! You got 1st rank.");
		}
		else if(marks>=75 && marks<90){
			Console.WriteLine( "You got 2nd rank.");
		}
		else if(marks>=50 && marks<70){
			Console.WriteLine( "You got 3rd rank.");
		}
		else if(marks>=35 && marks<50){
			Console.WriteLine( "You just passed.");
		}
		else if(marks>=10 && marks<35){
			Console.WriteLine( "You failed");
		}
		else{
			Console.WriteLine("Invalid Credentials");
		}
}
}



	