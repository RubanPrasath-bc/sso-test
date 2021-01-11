import org.testng.annotations.Test;
import static io.restassured.RestAssured.*;
import io.restassured.RestAssured;
import io.restassured.response.Response;
import io.restassured.specification.RequestSpecification;
import static io.restassured.matcher.RestAssuredMatchers.*;
import static org.hamcrest.Matchers.*;
import java.util.HashMap;
import java.util.Map;


public class Test_PasswordReset {
	
	@Test
	//Test case ID 0009 - Verify password reset request send successfully scenario.
	public void PasswordResetRequestSuccess() {
	   
		//Provide the base URL
		RestAssured.baseURI ="https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";

			  given().header("Content-Type","application/json")
			  
			  //Send the user name as a query parameter in the URL
			  .queryParam("userName","TestCCSUser")
			  .when().post("Security/passwordresetrequest")
			  
			  //Assert the status code and log the response
			  .then().log().all().assertThat().statusCode(200);
		   	
	}
	
	@Test
	//Test case ID 0010 - Verify password reset request send fail scenario.
	public void PasswordResetRequestFail() {
		  
		//Provide the base URL
		RestAssured.baseURI ="https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";

			  given().header("Content-Type","application/json")
			  
			  //Send an invalid user name as a query parameter in the URL
			  .queryParam("userName","InvalidTestCCSUser")
			  .when().post("Security/passwordresetrquestfail")
			  
			  //Assert the status code and log the response
			  .then().log().all().assertThat().statusCode(401);
		   	
	}
	
	@Test
	//Test case ID 0011 - Verify password reset successful scenario.
	public void PasswordResetSuccess() {
		
		//Provide the base URL
		RestAssured.baseURI = "https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
		Map<String,String> resetpassword = new HashMap<String, String>();
		
		//Add user name, verification code and password to the request body
		resetpassword.put("UserName", "TestCCSUser");
		resetpassword.put("Code", "TestVerificationcode");
		resetpassword.put("Password", "TestCCSUser@123");
		given()
		.contentType("application/json")
		.body(resetpassword)
		
		//Assert the status code and log the response
		.when().post("Security/resetpassword").then().log().all()
		.statusCode(200);
	}
	
	@Test
	//Test case ID 0012 - Verify password reset fail scenario.
	public void PasswordResetFail() {
		
		//Provide the base URL
		RestAssured.baseURI = "https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
		Map<String,String> resetpassword = new HashMap<String, String>();
		
		//Add user name, invalid verification code and password to the request body
		resetpassword.put("UserName", "TestCCSUser");
		resetpassword.put("Code", "TestInvalidCode");
		resetpassword.put("Password", "TestCCSUser@123");
		given()
		.contentType("application/json")
		.body(resetpassword)
		
		//Assert the status code and log the response
		.when().post("Security/resetpasswordfail").then().log().all()
		.statusCode(401);
	}
	
	
	

}
