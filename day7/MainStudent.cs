using System;
abstract class Student{
	string name;
	int rollNo;
	static int backlogs=0;
	protected abstract void Percentage(int p);
	
	protected abstract void Marks(int telugu,int hindi,int english,int maths);
	
	protected void StudentDetails(string name,int rollNo){
	this.name=name;
	this.rollNo=rollNo;
	Console.WriteLine(name);
	Console.WriteLine(rollNo);
	}

	protected static void Backlogs(){
	Console.WriteLine("You have {0} backlogs!!",backlogs);
}
	protected static void Courses(string course1,string course2){
	Console.WriteLine("You selected {0} and {1} courses",course1,course2);
}


	
}

class MainStudent:Student{
	protected override void Percentage(int p){
	Console.WriteLine("The Percentage is "+p);
}
	protected override void Marks(int telugu,int hindi,int english,int maths){
	Console.WriteLine("Telugu marks: "+telugu);
	Console.WriteLine("Hindi marks: "+hindi);
	Console.WriteLine("English marks: "+english);
	Console.WriteLine("Maths marks: "+maths);
}
	static void Main(){
	MainStudent s1=new MainStudent();
	s1.StudentDetails("Sowmya",45);
	s1.Percentage(95);
	s1.Marks(90,91,92,99);
	MainStudent.Backlogs();
	MainStudent.Courses("social","science");
}
}
