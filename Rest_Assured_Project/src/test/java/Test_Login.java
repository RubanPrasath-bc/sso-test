import org.testng.Assert;
import org.testng.annotations.Test;
import static io.restassured.RestAssured.*;
import io.restassured.RestAssured;
import io.restassured.response.Response;
import io.restassured.specification.RequestSpecification;
import static io.restassured.matcher.RestAssuredMatchers.*;
import static org.hamcrest.Matchers.*;

import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

import io.restassured.authentication.PreemptiveBasicAuthScheme;
public class Test_Login {
	
	@Test

	//Test case ID 0001 - Verify the successfully login scenario.
    public void LoginSuccess() {
        
		//Provide the base URL
        RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
        
        Map<String,Object> login = new HashMap<String, Object>();
		//Provide valid parameters in the request body
	    login.put("userName", "CCSUserTest1@yopmail.com");
	    login.put("userPassword", "Ccsuser@123");
	
         given()
		.contentType("application/json")
		.body(login)
		
		//Assert the status code and log the response
		.when().post("Security/login").then().log().all()
		.statusCode(200);
        
    }
	
	
	@Test
	
	//Test case ID 0002 - Verify the login fail scenario.
    public void LoginFail() {
        
		//Provide the base URL
        RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
        
        Map<String,Object> login = new HashMap<String, Object>();
		//Provide valid parameters in the request body
	    login.put("userName", "ccsuser@yopmail.com");
	    login.put("userPassword", "ghsdajf");
	
         given()
		.contentType("application/json")
		.body(login)
		
		//Assert the status code and log the response
		.when().post("Security/login").then().log().all()
		.statusCode(401);
        
    }
	
	

}
