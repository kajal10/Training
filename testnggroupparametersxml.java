<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE suite SYSTEM "http://testng.org/testng-1.0.dtd">

<suite name="testng">
	<test name="Test">
		<parameter name="username" value="Admin"/>
		<parameter name="password" value="admin123"/>
		<groups>
		<run>
		<include name="Regression">
		</include>
		</run>
		</groups>
			<classes>
			<class name="testng.NewTest" />

		</classes>
	</test> <!-- Test -->
</suite> <!-- Suite -->
