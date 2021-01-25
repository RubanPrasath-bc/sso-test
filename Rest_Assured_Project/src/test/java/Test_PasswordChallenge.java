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
	
	
	//@Test
	//Test case ID 00013 - Verify the password challenge success scenario.
	public void PasswordChallengeSuccess() {
		
		//Provide the base URL
		RestAssured.baseURI = "https://ccs-sso-api-agile-ratel-ix.london.cloudapps.digital";
		Map<String,String> password = new HashMap<String, String>();
		//Provide valid parameters in the request body
		password.put("userName", "CCSUserTest1@yopmail.com");
		password.put("sessionID", "AYABeGqGgRrLibBLnxoyZ5RR0ToAHQABAAdTZXJ2aWNlABBDb2duaXRvVXNlclBvb2xzAAEAB2F3cy1rbXMAS2Fybjphd3M6a21zOmV1LXdlc3QtMjo1MDA3OTI3NjA3NTc6a2V5LzBhNjgxMWMyLThjY2YtNDBkMi04NjU0LTExNzM2Y2YyZmM0NQC4AQIBAHhabbs4HXIltQDVjLau9e3yQ6wXeFEvqAUzqqVFIJfwqAF4Qi44LcBPmXBWv98NMV6VAAAAfjB8BgkqhkiG9w0BBwagbzBtAgEAMGgGCSqGSIb3DQEHATAeBglghkgBZQMEAS4wEQQMS6SRIGB1uVeVtX13AgEQgDvGvMClwUUq0J1oqDcGXHzDupAqbRvTwDkDJI6S3TW4qosYoEqqziqVOr2Bl_8tKcDNoO5X4O8IU9B2CwIAAAAADAAAEAAAAAAAAAAAAAAAAAD4DKV9ZX2xWligfyfZRUBz_____wAAAAEAAAAAAAAAAAAAAAEAAADdoEMFo2m_G4XJ1NIDeV6GP-I73F9hnVYHEKH7xgQNSzle_wOF7Xp_PRUMDhW3UuGLRZknXDE9Ll49wzCHEcaLV2aM9BOpwDqjrdI9FLdzLAzBNzdGpmU9BzfOAWHpoilcMLapIqaAPIHkQSFZr0idLQTSY6S5OeksEDfjl3vVEpy5RR5M6hvDHuzztOkR6EmqvlsmzsYWJslWD5XCzAw25cOiggrCAhuFVyOc2E3Pa5-EkcOS5Luj3FoJZwN_-LI4V6_t63DeXBZnoaVGeuHm2PBZt9VCja0JVY5k2yhLM2jcHXplGG9zBAIJRB6R");
		password.put("newPassword", "Ccsuser@123");

		given()
		.contentType("application/json")
		.body(password)
		
		//Assert the status code and log the response
		.when().post("/Security/passwordchallenge").then().log().all()
		.statusCode(200);
	}
	
	@Test
	//Test case ID 00014 - Verify the password challenge fail scenario.
	public void PasswordChallengeFail() {
		
		//Provide the base URL
		RestAssured.baseURI = "https://ccs-sso-api-agile-ratel-ix.london.cloudapps.digital";
		Map<String,String> password = new HashMap<String, String>();
		
		//Provide invalid parameters in the request body
		password.put("userName", "CCSUserTest1@yopmail.com");
		password.put("sessionID", "123gsdvfbfhsvfvdhddffddsdsdasdsdadaadasdasdsdaBAIJRB6R");
		password.put("newPassword", "TestCCSUseri@123");

		given()
		.contentType("application/json")
		.body(password)
		
		//Assert the status code and log the response
		.when().post("/Security/passwordchallenge").then().log().all()
		.statusCode(400);
	}

}
