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


public class Test_PasswordChallenge {
	
	
	@Test
	//Test case ID 00013 - Verify the password challenge success scenario.
	public void PasswordChallengeSuccess() {
		
		//Provide the base URL
		RestAssured.baseURI = "https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
		Map<String,String> password = new HashMap<String, String>();
		//Provide valid parameters in the request body
		password.put("userName", "TestCCSUser");
		password.put("sessionID", "56262");
		password.put("newPassword", "TestCCSUser@123");

		given()
		.contentType("application/json")
		.body(password)
		
		//Assert the status code and log the response
		.when().post("/Security/passwordchallange").then().log().all()
		.statusCode(200);
	}
	
	@Test
	//Test case ID 00014 - Verify the password challenge fail scenario.
	public void PasswordChallengeFail() {
		
		//Provide the base URL
		RestAssured.baseURI = "https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
		Map<String,String> password = new HashMap<String, String>();
		//Provide invalid parameters in the request body
		password.put("userName", "InvalidTestCCSUser");
		password.put("sessionID", "56262");
		password.put("newPassword", "TestCCSUseri@123");

		given()
		.contentType("application/json")
		.body(password)
		
		//Assert the status code and log the response
		.when().post("/security/passwordchallengefail").then().log().all()
		.statusCode(401);
	}

}
