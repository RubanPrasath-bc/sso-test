import org.testng.Assert;
import org.testng.annotations.Test;

import com.mongodb.util.JSON;

import static io.restassured.RestAssured.*;
import io.restassured.RestAssured;
import io.restassured.http.ContentType;
import io.restassured.response.Response;
import io.restassured.response.ResponseBody;
import io.restassured.specification.RequestSpecification;
import static io.restassured.matcher.RestAssuredMatchers.*;
import static org.hamcrest.Matchers.*;

import java.util.HashMap;
import java.util.Map;

import org.json.JSONException;
import org.json.JSONObject;


public class Test_Logout {
	
       @Test	
     //Test case ID 0003 - Verify the successfully logout scenario.
	   public void LogoutSuccessful()
	   {
    	   RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
           RequestSpecification request = RestAssured.given();
           
           String user = "CCSUserTest1@yopmail.com";

           JSONObject requestParams = new JSONObject();
           request.body(
                   
        		   "\""+user+"\""
           );

           // Add a header stating the Request body is a JSON
           request.header("Content-Type", "application/json");

           Response response = request.post("/security/logout");

           // Retrieve the body of the Response
           ResponseBody body = response.getBody();

           int statusCode = response.getStatusCode();
           System.out.println("The status code recieved: " + statusCode);

           //Assert Response
           Assert.assertEquals(statusCode, 200);

           System.out.println("Response body: " + response.body().asString());
    	   
	   }
	  
       @Test
       //Test case ID 0004 - Verify the logout fail scenario.
	   public void LogoutFail()
	   {
    	   RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
           RequestSpecification request = RestAssured.given();
           
           String user = "fsfsd@yopmail.com";

           JSONObject requestParams = new JSONObject();
           request.body(
                   
        		   "\""+user+"\""
           );

           // Add a header stating the Request body is a JSON
           request.header("Content-Type", "application/json");

           Response response = request.post("/security/logout");

           // Retrieve the body of the Response
           ResponseBody body = response.getBody();

           int statusCode = response.getStatusCode();
           System.out.println("The status code recieved: " + statusCode);

           //Assert Response
           Assert.assertEquals(statusCode, 400);

           System.out.println("Response body: " + response.body().asString());
    	  
	   }
	  
}
