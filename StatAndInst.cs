using System;
class StatAndInst{
	static int stat1=10;
	static int stat2=45;
	public void display1(int a, int b){
		Console.WriteLine(a+b);
		Console.WriteLine(a-stat1);
	}
	public void display2(int a){
		//stat1=20;
		a=45;
		Console.WriteLine(a);
}
	static void Main(){
		StatAndInst obj1=new StatAndInst();
		obj1.display1(10,20);
		obj1.display2(100);
}
}