using System;
class InterviewProcess{
	static public void Main(string [] args){
		Console.Write("Did you clear the written test? (yes/no):");
		string writtenTest=Console.ReadLine();
		if(writtenTest=="yes"){
			Console.WriteLine("You are eligible for the group discussion round");
			Console.Write("Did you pass the group discussion round? (yes/no):");
			string groupResult=Console.ReadLine();
			if(groupResult=="yes"){
				Console.WriteLine("You are eligible for the technical round");
				Console.Write("Did you pass the technical round? (yes/no):");
				string techResult=Console.ReadLine();
				if(techResult=="yes"){
					Console.WriteLine("Congrats! You are eligible for the HR round");
				}
				else{
					Console.WriteLine("Sorry,You can go home");
				}
			}
			else{
					Console.WriteLine("Sorry,You can go home");
				}
		}
		else{
					Console.WriteLine("Sorry,You can go home");
				}
}

}