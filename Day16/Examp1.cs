using System;
using System.Threading;
class Examp1{
	public void Player1(){
	for(int i=0;i<5;i++){
	Console.WriteLine("Player1");
	Thread.Sleep(2000);
	}
	}
	public void Player2(){
	for(int i=0;i<5;i++){
	Console.WriteLine("Player2");
	Thread.Sleep(2000);
	}
	}
	public void Player3(){
	for(int i=0;i<5;i++){
	Console.WriteLine("Player3");
	Thread.Sleep(2000);
	}
	}
	public static void Main(string [] args){
	Examp1 e1=new Examp1();
	Thread t1=new Thread(e1.Player1);
	Thread t2=new Thread(e1.Player2);
	Thread t3=new Thread(e1.Player3);
	t1.Start();
	t2.Start();
	t3.Start();
}
}