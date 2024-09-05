using System;
class Transpose{
	static void Main(string [] args){
	Console.Write("Enter rows: ");
	int rows=Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter columns: ");
	int cols=Convert.ToInt32(Console.ReadLine());
	int [,] matrix=new int [rows,cols];
	int [,] result=new int [cols,rows];
	Console.WriteLine("Enter elements");
	for(int i=0;i<rows;i++){
		for(int j=0;j<cols;j++){
			Console.Write("element {0} {1}: ",i,j);
			matrix[i,j]=Convert.ToInt32(Console.ReadLine());
		}
	}
	for(int i=0;i<rows;i++){
		for(int j=0;j<cols;j++){
			result[j,i]=matrix[i,j];
		}
	}
	Console.WriteLine("Transpose Matrix is:");
	for(int i=0;i<cols;i++){
		for(int j=0;j<rows;j++){
		Console.Write(result[i,j]+" ");
			
		}
		Console.WriteLine();
	}
	
}
}