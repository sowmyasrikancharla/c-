using System;
public class InvalidCouponException:Exception{
public InvalidCouponException(string message):base(message){
	}
} 
class Coupon {
	static void checkValidity(string s){
		if(s!="Coupon123"){
	throw new InvalidCouponException("Failed to apply coupon: Invalid coupon");
		}
        else{
        Console.WriteLine("Coupon code applied successfully");
        }
	}
	static void Main(string [] args){
	try{
	string s=args[0];
	checkValidity(s);
	}
	catch(InvalidCouponException e){
	Console.WriteLine(e.Message);
}
	finally{
	Console.WriteLine("Thankyou for shopping with us!!");
}
}
}