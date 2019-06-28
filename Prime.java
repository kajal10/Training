package second;


public class Prime {

	public static void prime() {
		System.out.println("The prime numbers are:");
		
		for(int i=1; i<=500; i++)
		{
			int j=0;
		for(int k=1; k<=500; k++)
		{
			if(i%k==0) {
				j++;
			}
			}
		if(j==2) {
			System.out.println(i);
		}
	}
}
	public static void fibonaci() {
		int n, a=0, b=0, c=1;
		 System.out.print("Fibonacci Series:");
		 
	        for(int i = 1; i <= 100; i++)
	        {
	            a = b;
	            b = c;
	            c = a + b;
	            System.out.print(c+" ");
	        }


	}
	
	public static void main(String args[])
	{
		prime();
		fibonaci();
	}

}
