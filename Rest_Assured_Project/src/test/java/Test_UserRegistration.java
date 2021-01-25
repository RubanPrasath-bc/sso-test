import org.testng.Assert;
import org.testng.annotations.Test;
import static io.restassured.RestAssured.*;
import io.restassured.RestAssured;
import io.restassured.response.Response;
import io.restassured.specification.RequestSpecification;
import static io.restassured.matcher.RestAssuredMatchers.*;
import static org.hamcrest.Matchers.*;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.json.JSONException;
import org.json.JSONObject;


public class Test_UserRegistration {
	
	@Test
	//Test case ID 0005 - Verify user registration success scenario.
    public void UserRegistrationSuccess() {
        
		     //Provide the base URL
			 RestAssured.baseURI ="https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
			 
			 Map<String,Object> register = new HashMap<String, Object>();
			 
			 //Provide valid parameters in the request body
			 register.put("userName", "CCSAdminUser@yopmail.com");
			 register.put("email", "CCSAdminUser@yopmail.com");
			 register.put("firstName", "CCSUser1FirstName");
			 register.put("lastName", "CCSUser1LastName");
			 register.put("role", "Admin");
			 register.put("groups", Arrays.asList("Test"));
				

	             given()
				.contentType("application/json")
				.body(register)
				
				//Assert the status code and log the response
				.when().post("/Security/register").then().log().all()
				.statusCode(200);

		}
        
	@Test
	//Test case ID 0006 - Verify user registration fail scenario.
    public void UserRegistrationFail() {
        
		    //Provide the base URL
			 RestAssured.baseURI ="https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
			 Map<String,Object> registerfail = new HashMap<String, Object>();
			 
			 //Provide valid parameters in the request body
			 registerfail.put("userName", "");
			 registerfail.put("email", "");
			 registerfail.put("firstName", "TestCCSFirstName");
			 registerfail.put("lastName", "TestCCSLastName");
			 registerfail.put("role", "Admin");
			 registerfail.put("groups", Arrays.asList("Test"));
				

	             given()
				.contentType("application/json")
				.body(registerfail)
				
				//Assert the status code and log the response
				.when().post("/Security/register").then().log().all()
				.statusCode(400);


		}
	
	public void getUser()
	
	{
        int userid = 432;
		
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
		given()
		.contentType("application/json")
			
			//Assert the status code and log the response
			.when().get("/user" + userid).then().log().all()
			.statusCode(200);
				
	}
	
	public void getUserFail()
	
	{
		//provide invalid userID 
        int userid = 777;
		
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
		given()
		.contentType("application/json")
			
			//Assert the status code and log the response
			.when().get("/user" + userid).then().log().all()
			.statusCode(400);
				
	}
	
	
	
	
	
	

}
