package first;

import java.util.Scanner;

public class Calculator {
 
	public static void main(String args[])
	{
		int num1=0;
		int num2=0;
		char operator;
		double answer= 0.0;
	
		
		Scanner sc= new Scanner(System.in);
		System.out.println("please enter the first number");
		num1 = sc.nextInt();
		System.out.println("please enter the second number");
		num2 = sc.nextInt();
	    
		System.out.println("Enter the operation you want to perform");
		operator= sc.next().charAt(0);
		
		switch(operator)
		{
		   case '+':
			   
			answer= num1+num2;
			break;
			
		   case '-':
			   
				answer= num1+num2;
				break;
				
		   case '/':
			   
				answer= num1+num2;
				break;
				
		   case '*':
			   
				answer= num1+num2;
				break;
		}
		
		System.out.println(num1+"" +operator+"" +num2+"=" +answer);
	}
}

