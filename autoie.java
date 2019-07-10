package automation;

import org.openqa.selenium.WebDriver;

import org.openqa.selenium.ie.InternetExplorerDriver;

public class Bbb {
	
     public static void main(String[] args) {
    	  
             System.setProperty("webdriver.ie.driver","C:\\Users\\VSPICT\\Desktop\\kajal\\IEDriverServer.exe");
             WebDriver driver =new InternetExplorerDriver();
             driver.get("https:\\www.google.com");
             driver.manage().window().maximize();
     }
}
