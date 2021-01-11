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


public class Test_UserRegistration {
	
	@Test
	//Test case ID 0005 - Verify user registration success scenario.
    public void UserRegistrationSuccess() {
        
		     //Provide the base URL
			 RestAssured.baseURI ="https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
			 RequestSpecification request = RestAssured.given();
			 
			 //Create a JSON object with all the parameters
			 JSONObject register = new JSONObject();
			    try {
			    	register.put("userId", "TestCCSUser123"); 
			    	register.put("email", "TestCCS@yopmail.com");
			    	register.put("firstName", "TestCCSFirstName");
			    	register.put("lastName", "TestCCSLastName");					 
			    	register.put("role",  "Admin");
			    	register.put("groups", "[1,2]");
			    } 
			    catch ( JSONException e) {}
			    
			    //Pass the JSON object to the request body
			    request.body(register.toString());
			 
		        given().header("Content-Type","application/json")
		        .when().post("Security/register")
		        
		        //Assert the status code and log the response
		        .then().log().all().assertThat().statusCode(200);

		}
        
	@Test
	//Test case ID 0006 - Verify user registration fail scenario.
    public void UserRegistrationFail() {
        
		    //Provide the base URL
			 RestAssured.baseURI ="https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
			 RequestSpecification request = RestAssured.given();
			 
			//Create a JSON object with all the parameters with invalid information
			 JSONObject register = new JSONObject();
			    try {
			    	register.put("userId", ""); 
			    	register.put("email", "");
			    	register.put("firstName", "TestCCSFirstName");
			    	register.put("lastName", "TestCCSLastName");					 
			    	register.put("role",  "Admin");
			    	register.put("groups", "[1,2]");
			    	
			    } 
			    catch ( JSONException e) {}
			    
			    //Pass the JSON object to the request body
			    request.body(register.toString());
			 
		        given().header("Content-Type","application/json")
		        .when().post("Security/registerfail")
		        
		        //Assert the status code and log the response
		        .then().log().all().assertThat().statusCode(400);

		}

}
