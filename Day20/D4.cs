using System;
class D4{
	public delegate int Show(int a,int b,int c);
	public int display(int a,int b,int c){
	return a*b+c;
}

	static void Main(string [] args){
	D4 d=new D4();
	Show s1=d.display;
	Console.WriteLine(s1.Invoke(23,3,8));
}
}