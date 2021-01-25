import org.json.JSONObject;
import org.testng.Assert;
import org.testng.annotations.Test;
import static io.restassured.RestAssured.*;
import io.restassured.RestAssured;
import io.restassured.response.Response;
import io.restassured.response.ResponseBody;
import io.restassured.specification.RequestSpecification;
import static io.restassured.matcher.RestAssuredMatchers.*;
import static org.hamcrest.Matchers.*;
import java.util.HashMap;
import java.util.Map;


public class Test_PasswordReset {
	
	//@Test
	//Test case ID 0009 - Verify password reset request send successfully scenario.
	public void PasswordResetRequestSuccess() {
	   
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
	//Test case ID 0010 - Verify password reset request send fail scenario.
	public void PasswordResetRequestFail() {
		  
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
        RequestSpecification request = RestAssured.given();
        
        String user = "ghdaj@yopmail.com";

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
	
	//@Test
	//Test case ID 0011 - Verify password reset successful scenario.
	public void PasswordResetSuccess() {
		
		//Provide the base URL
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
		Map<String,String> resetpassword = new HashMap<String, String>();
		
		//Add user name, verification code and password to the request body
		resetpassword.put("userName", "kawshi1@yopmail.com");
		resetpassword.put("verificationCode", "153696");
		resetpassword.put("newPassword", "Kawshi@1234");
		given()
		.contentType("application/json")
		.body(resetpassword)
		
		//Assert the status code and log the response
		.when().post("security/passwordreset").then().log().all()
		.statusCode(200);
	}
	
	//@Test
	//Test case ID 0012 - Verify password reset fail scenario.
	public void PasswordResetFail() {
		
		//Provide the base URL
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
		Map<String,String> resetpassword = new HashMap<String, String>();
		
		//Add user name, invalid verification code and password to the request body
		resetpassword.put("userName", "TestCCSUser");
		resetpassword.put("verificationCode", "TestInvalidCode");
		resetpassword.put("newPassword", "TestCCSUser@123");
		given()
		.contentType("application/json")
		.body(resetpassword)
		
		//Assert the status code and log the response
		.when().post("Security/resetpassword").then().log().all()
		.statusCode(401);
	}
	
	
	

}
