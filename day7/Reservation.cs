using System;
abstract class Train{
	
	static int price=100;
	static string starting="gudivada";
	static string destination="vijayvada";
	int seat=5;

	
	protected abstract void Travelling(int d);
	
	protected  abstract void PassengerDetails(string name,int id);
	
	protected static void TicketPrice(){
	Console.WriteLine("price of ur ticket is {0}!!",price);
}
		protected static void JourneyDetails(){
	Console.WriteLine("Your journey from {0} to {1}",starting,destination);
}

	protected void Dropping(){
	Console.WriteLine("Your dropping location is {0}",destination);

}
	protected void SeatAllocation(){
	Console.WriteLine("Your seat allocation is {0}",seat);
}
	
}

class Reservation:Train{
	protected override void Travelling(int d){
	Console.WriteLine("You travelled {0} km",d);
}
	protected  override void PassengerDetails(string name,int id){
	Console.WriteLine("Passenger Name: "+name);
	Console.WriteLine("Passenger Id: "+id);	
}
	

	static void Main(){
	Reservation r1=new Reservation();
	r1.PassengerDetails("sowmya",45);
	Reservation.JourneyDetails();
	r1.Travelling(95);
	Reservation.TicketPrice();
	r1.SeatAllocation();
	r1.Dropping();
}
}
