import org.testng.annotations.Test;
import static io.restassured.RestAssured.*;
import io.restassured.RestAssured;
import io.restassured.response.Response;
import io.restassured.specification.RequestSpecification;
import static io.restassured.matcher.RestAssuredMatchers.*;
import static org.hamcrest.Matchers.*;
import java.util.HashMap;
import java.util.Map;
import io.restassured.authentication.PreemptiveBasicAuthScheme;

public class Test_ChangePassword {
	
	@Test
	//Test case ID 0007 - Verify the successfully changing password scenario.
	public void ChangePasswordSuccess() {
		
		//Provide the base URL
		RestAssured.baseURI = "https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
		Map<String,String> password = new HashMap<String, String>();
		//Provide valid parameters in the request body
		password.put("newPassword", "TestCCSUserPW123");
		password.put("oldPassword", "TestCCSUserPW");
		password.put("accessToken", "TestToken3452");

		given()
		.contentType("application/json")
		.body(password)
		
		//Assert the status code and log the response
		.when().post("/Security/changepassword").then().log().all()
		.statusCode(200);
	}
	
	@Test
	//Test case ID 0008 - Verify Change Password failure scenario.
	public void ChangePasswordFail() {
		
		//Provide the base URL
		RestAssured.baseURI = "https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
		Map<String,String> password = new HashMap<String, String>();
		
		//Provide parameters in the request body with incorrect information
		password.put("newPassword", "TestCCSUser");
		password.put("oldPassword", "InvalidTestPW");
		password.put("accessToken", "6788");

		given()
		.contentType("application/json")
		.body(password)
		
		//Assert the status code and log the response
		.when().post("/Security/changepasswordfail").then().log().all()
		.statusCode(401);
	}

}
