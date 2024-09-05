using System;
class ExplicitCast2{
	static void Main(string [] args){
		Console.Write("Enter a double value");
		string val=Console.ReadLine();
		float val_f=Convert.ToSingle(val);
		Console.WriteLine("Original value before Casting:"+val_f);
		short val_s=Convert.ToInt16(val);
		Console.WriteLine("After Type Casting to short:"+val_s);
		int val_i=Convert.ToInt32(val);
		Console.WriteLine("After Type Casting to int:"+val_i);


}
}