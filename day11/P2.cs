using System;
class P2{	

	public void findKey( int input1,int input2,int input3){
		int [] a1=new int [3];
		int [] a2=new int [3];
		a2[0]=input1;
		a2[1]=input2;
		a2[2]=input3;
	int c=0;
	int result=0;
	while(c<=3){
	for(int i=0;i<3;i++){
		int r=a2[i]%10;
		arr[i]=a2[i]/10;
		a1[i]=r;

	}
	int max=a1[0];
	int min=a1[0];
	int temp=0;
	foreach(int x in a1){
	if(x>max){
		temp=max;
		max=x;
	}
	if(x<max){
		temp=min;
		min=x;	
}
	}
	c++;
	int diff=max-min;
	result=result*10+diff;
	}
	int ans=0;
	while(result>0){
	int rem=result%10;
	result=result/10;
	ans=ans*10+rem;
	}

	Console.WriteLine(ans);
	}

}
public static void Main(string [] args){

	int []arr=new int [3];

	Console.Write("Enter input1: ");
	arr[0]=Convert.ToInt32(Console.ReadLine());
	if(arr[0]>1000 && arr[0]<=9999){
		Console.Write("Enter input2: ");
		arr[1]=Convert.ToInt32(Console.ReadLine());
		if(arr[1]>=1000 && arr[1]<=9999){
			Console.Write("Enter input3: ");
			arr[2]=Convert.ToInt32(Console.ReadLine());
			if(arr[2]>=1000 && arr[2]<=9999){
				findKey(arr[0],arr[1],arr[2])	
	else{
		Console.WriteLine("Invalid Input");
		}
		}
		else{
			Console.WriteLine("Invalid Input");

		}
		}
	else{
	Console.WriteLine("Invalid Input");
	}
	}
}