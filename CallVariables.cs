using System;
class CallVariables{
	static int a=10;
	const int b=20;
	void display(int a, int b ,int c){
		Console.WriteLine(a+b+c);
	}
	public static void Main(){
	int c=30;
	CallVariables obj=new CallVariables();
	obj.display(a,b,c);
}
}