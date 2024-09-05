using System;

class BookStore{
	
	public void displayDetails(int id, string title, string author,int price ,int no_of_copies){
		Console.WriteLine("Book Id is "+id);
		Console.WriteLine("Book Title is "+title);
		Console.WriteLine("Book author is "+author);
		Console.WriteLine("Book price is "+price);
		Console.WriteLine("Number of copies of book "+no_of_copies);
		Console.WriteLine("Value of book id "+(price*no_of_copies));

	}
	
	public static void Main(){
		Console.WriteLine("Hello");
		BookStore b1=new BookStore();
		BookStore b2=new BookStore();

		b1.displayDetails(1,"AI","Sowmya",1000,5); 
		b2.displayDetails(2,"DS","Roshini",1,5);
			
}
}