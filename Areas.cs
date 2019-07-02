package kajal;
import java.io.*;
abstract class Shape
{
     double r, h,w;
     Shape(double r, double h,double w)
     {
          this.r = r;
          this.h = h;
          this.w = w;
     }
     abstract double getArea();
}
class Rectangle extends Shape
{
     Rectangle(double w,double h)
     {
          super(0,w,h);
     }
     double getArea()
     {
          return w*h;
     }
}
class Circle extends Shape
{
     Circle(double r)
     {
          super(r,0,0);
     }
     double getArea()
     {
          return 3.14*r*r;
     }
}
class Triangle extends Shape
{
     Triangle(double w,double h)
     {
          super(0,w,h);
     }
     double getArea()
     {
          return w*h/2;
     }
}
class Cone extends Shape
{
     Cone(double r,double h)
     {
          super(r,0,h);
     }
     double getArea()
     {
          return 3.14*r*(r+Math.sqrt(r*r+h*h));
     
     }
}
public class Demo
{
	public static void main(String[] args) throws Exception
	
    {
         BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
         Shape s = null; 
         double r = 0;
         double h = 0;
         double w = 0;
         int ch;
         do
         {
              System.out.print("\n1.Rectangle"+"\n2.Circle"+"\n3.Triangle"+ "\n4.Cone"+"\n5.Exit "+"\nEnter your choice : ");
              ch = Integer.parseInt(br.readLine());
              switch (ch)
              {
                   case 1:
                        System.out.print("Enter width of Rectangle:");
                        w = Double.parseDouble(br.readLine());
                        System.out.print("Enter height of Rectangle:");
                        h = Double.parseDouble(br.readLine());
                        s = new Rectangle(w,h);
                        break;
                        
                   case 2:
                        System.out.print("Enter radius of Circle:");
                        r = Double.parseDouble(br.readLine());
                        s = new Circle(r);
                        break;
                        
                   case 3:
                	   System.out.print("Enter width of Triangle:");
                       w = Double.parseDouble(br.readLine());
                       System.out.print("Enter height of Triangle:");
                       h = Double.parseDouble(br.readLine());
                        s = new Triangle(w,h);
                        break;
                        
                   case 4:
                	   System.out.print("Enter radius of Cone:");
                       w = Double.parseDouble(br.readLine());
                       System.out.print("Enter height of Cone:");
                       h = Double.parseDouble(br.readLine());
                        s = new Cone(w,h);
                        break;
                        
                   case 5:
                	   System.out.print("you are successfully exited");
                       System.exit(0);
                	   
                    default:
                		  System.out.print("Please enter the numbers between 1 and 5");
              }   		  
              
              System.out.println("Area = "+s.getArea());
         }
         while (ch!=4);
    }
}

