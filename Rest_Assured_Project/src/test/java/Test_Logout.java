import org.testng.Assert;
import org.testng.annotations.Test;
import static io.restassured.RestAssured.*;
import io.restassured.RestAssured;
import io.restassured.response.Response;
import io.restassured.specification.RequestSpecification;
import static io.restassured.matcher.RestAssuredMatchers.*;
import static org.hamcrest.Matchers.*;

import org.json.JSONException;
import org.json.JSONObject;


public class Test_Logout {
	
       @Test	
     //Test case ID 0003 - Verify the successfully logout scenario.
	   public void LogoutSuccessful()
	   {
		   
    	   //Provide the base URL
		   RestAssured.baseURI ="https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
			 
		   given().header("Content-Type","application/json")
		        
		   //Add user name as the query parameter in the URL
		   .queryParam("userName","TestCCSUser")
		   .when().post("Security/logout")
		        
		   //Assert the status code and log the response
		   .then().log().all().assertThat().statusCode(200);
	   }
	  
       @Test
       //Test case ID 0004 - Verify the logout fail scenario.
	   public void LogoutFail()
	   {
		   
    	   //Provide the base URL
		   RestAssured.baseURI = "https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
	 
		   given().header("Content-Type","application/json")
		   
		   //Add an invalid user name as the query parameter in the URL
	       .queryParam("userName","InvalidTestCCSUser")
	       .when().post("/Security/logoutfail")
	       
	       //Assert the status code and log the response
	       .then().log().all().assertThat().statusCode(401);
	   }
	  
}
