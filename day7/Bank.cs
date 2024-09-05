using System;
public class FixedAmount{
	public static int initialAmount=10000;
}

abstract class WithDrawlAmount{
	protected abstract void Withdraw(int amount);
	
}

class Bank:WithDrawlAmount{
	protected override void Withdraw(int amount){
	Console.WriteLine("Maintain minimum balance : "+FixedAmount.initialAmount);
	Console.WriteLine("The available balance :"+(FixedAmount.initialAmount-amount));
	}


	public static void Main(string [] args){
	int req=Convert.ToInt32(args[0]);
	Console.WriteLine(req);
	Bank obj=new Bank();
	obj.Withdraw(req);
}
} 