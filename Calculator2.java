package first;
import java.util.Scanner;

public class Calculator2 {
 
	public static void main(String args[])
	{
		int num1=0;
		int num2=0;
	
	
		
		Scanner sc= new Scanner(System.in);
		System.out.println("please enter the first number");
		num1 = sc.nextInt();
		System.out.println("please enter the second number");
		num2 = sc.nextInt();
	    
		System.out.println("Addition is:"+num1+"+"+num2+"="+(num1+num2));
		System.out.println("Substraction is:"+num1+"-"+num2+"="+(num1-num2));
		System.out.println("multiplication is:"+num1+"*"+num2+"="+(num1*num2));
		System.out.println("division is:"+num1+"/"+num2+"="+(num1/num2));
	
	}
		
		
}