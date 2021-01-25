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
	
	//@Test
	//Test case ID 0007 - Verify the successfully changing password scenario.
	public void ChangePasswordSuccess() {
		
		//Provide the base URL
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
		Map<String,String> password = new HashMap<String, String>();
		//Provide valid parameters in the request body
		password.put("accessToken", "eyJraWQiOiJoSllOdlwvVmR5dFo1dXZaQU4zaFNRQ3luWDR1YzZoeEJuOVdKM3JoOEZZMD0iLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiJhMTE2MWE1MC0wNjcxLTQ3ZDAtOTA5NC0yYWI3M2FkNjk3MjkiLCJldmVudF9pZCI6IjE5ZGNiM2VkLThmM2YtNGQyZC04YjIwLTZkNjczY2UyZDA3MiIsInRva2VuX3VzZSI6ImFjY2VzcyIsInNjb3BlIjoiYXdzLmNvZ25pdG8uc2lnbmluLnVzZXIuYWRtaW4iLCJhdXRoX3RpbWUiOjE2MTEwMzMwMTgsImlzcyI6Imh0dHBzOlwvXC9jb2duaXRvLWlkcC5ldS13ZXN0LTIuYW1hem9uYXdzLmNvbVwvZXUtd2VzdC0yX2Y5OGVrQkJqaiIsImV4cCI6MTYxMTAzNjYxOCwiaWF0IjoxNjExMDMzMDE4LCJqdGkiOiJkNGEyZTA0Ni1lZjFhLTRmZmQtYWQyYS1jMWE2NDY1YTE3YzgiLCJjbGllbnRfaWQiOiIydWEwN2FlYmpkM2w1ZmgzMzNkdXRtNnMyaiIsInVzZXJuYW1lIjoia2F3c2hpMUB5b3BtYWlsLmNvbSJ9.hCkvpYrL5jiu0awpj5mRX-SonZOmOe3VYb-OT2kxJYz46vO7AMa_0GGyBkmstb_gG2wct8X8YOwBhI8UKEVkdMea2k_opf4APHCuaaVk-6Ci4OyYx6rE67B-h1oe6XXBcoqvZmQ_VXcoYhqV_9bPb5b601eV06t4Uxp8Qg-8OarF3yFR8xKKMs1BkzMxN7XfoRub7rjEvoH6g_SWJr3zwk_d04YLLojdxff7h-uUDNne03m3pH_BMBQnQNKMxsvWOpWYqDSF5c4W7bQ5TCgjni_6DObcwuyYTDiWh0bvSJWUd7QrCS_eS7mIP3y4yWayMydlnA3TDLBdF-kx92YjJg");
		password.put("newPassword", "Kawshi@123");
		password.put("oldPassword", "Ayeshma@123");

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
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
		Map<String,String> password = new HashMap<String, String>();
		
		//Provide parameters in the request body with incorrect information
		password.put("accessToken", "6788");
		password.put("newPassword", "TestCCSUser");
		password.put("oldPassword", "InvalidTestPW");
		

		given()
		.contentType("application/json")
		.body(password)
		
		//Assert the status code and log the response
		.when().post("/Security/changepassword").then().log().all()
		.statusCode(400);
	}

}
