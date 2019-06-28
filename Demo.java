package third;

public class Demo {
	String title;
    String author;
    String subject;
    int id;

    public void getValues(String t, String a, String s, int id) {
        title = t;
        author = a;
        subject = s;
        id = id;
        System.out.println(title+" "+author+" "+subject+" "+id);
    }
	
	public static void main(String args[])
	{
		Demo d=new Demo();
		d.getValues("Hello", "Hi", "Bye", 678);

	}


}
