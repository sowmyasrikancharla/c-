using System;
class Sample{

	 public virtual void Display(string s){
	Console.WriteLine("The {0} engine starts",s);
}
}

class Sample2:Sample{
	public sealed override void Display(string s){
	Console.WriteLine("The {0} engine starts",s);
	}	


	public static void Main(string [] args){
	string s1=args[0];
	Sample2 obj1=new Sample2();
	obj1.Display(s1);
	
}
}