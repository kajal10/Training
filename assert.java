package testng;

import org.testng.annotations.Test;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.Parameters;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.Assert;
import org.testng.annotations.AfterClass;

public class NewTest {
	WebDriver driver;
	 @Test( groups= {"Regression", "smoke"})
	 public void Login()
	 {
	 driver.get("https://opensource-demo.orangehrmlive.com");
	 System.out.println("Application is loaded successfully");
	 }

	@Test( groups= {"Regression"})
	@Parameters({ "username", "password" })
	public void ApplicationLogin(String username, String password) throws InterruptedException {
		driver.get("https://opensource-demo.orangehrmlive.com");
		System.out.println("Application is loaded successfully");
		driver.findElement(By.id("txtUsername")).sendKeys(username);
		driver.findElement(By.id("txtPassword")).sendKeys(password);
		driver.findElement(By.id("btnLogin")).click();
		Thread.sleep(5000);
		 Assert.assertEquals("chandra", "chandra");
	}

	
	 @Test( groups= {"Regression"})
	 public void SearchForUser() throws InterruptedException
{
	 driver.findElement(By.xpath("//b[contains(text(),'Admin')]")).click();
	 driver.findElement(By.id("searchSystemUser_userName")).sendKeys("russel.hamilton");

	 driver.findElement(By.className("searchbutton")).click();
	 Thread.sleep(5000);
}
	
	 @Test(groups= {"smoke"})
 public void DeleteTheUser()
{
	 driver.findElement(By.xpath("//b[contains(text(),'Admin')]")).click();
	 driver.findElement(By.id("searchSystemUser_userName")).sendKeys("prasanth95");
	 driver.findElement(By.xpath("//input[@id='ohrmList_chkSelectRecord_19']")).click();
	 driver.findElement(By.className("delete")).click();
	 driver.findElement(By.className("btn")).click();
	 }

	@BeforeClass ( groups= {"Regression"})
	public void beforeClass() {
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\VSPICT\\Downloads\\chromedriver.exe");
		driver = new ChromeDriver();

	}

	@AfterClass
	public void afterClass() {
		// driver.close();
	}

}
