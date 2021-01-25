package stepDefinations;

import static io.restassured.RestAssured.given;

import java.io.IOException;
import static org.junit.Assert.*;
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;
import io.restassured.builder.ResponseSpecBuilder;
import io.restassured.http.ContentType;
import io.restassured.response.Response;
import io.restassured.specification.RequestSpecification;
import io.restassured.specification.ResponseSpecification;
import resources.APIResources;
import resources.TestDataBuild;
import resources.Utils;

public class LoginStep extends Utils {
	RequestSpecification res;
	ResponseSpecification resspec;
	Response response;
	TestDataBuild data =new TestDataBuild();
	static String place_id;
	

	
	@Given("Login user with {string}  {string}")
	public void login_user_with(String userName, String password) throws IOException {
		res=given().spec(requestSpecification()).contentType("application/json").body(data.loginPayLoad(userName,password));
		System.out.println("Response"+res.toString());
	}


	@When("user calls {string} with {string} http request")
	public void user_calls_with_http_request(String resource, String method) {
		APIResources resourceAPI=APIResources.valueOf(resource);
		System.out.println("resource"+resourceAPI.getResource());
	
		resspec =new ResponseSpecBuilder().expectStatusCode(200).expectContentType(ContentType.JSON).build();
		
		if(method.equalsIgnoreCase("POST"))
		 response =res.when().post(resourceAPI.getResource());
		else if(method.equalsIgnoreCase("GET"))
			 response =res.when().get(resourceAPI.getResource());
	}
	@Then("the API call got success with status code {int}")
	public void the_api_call_got_success_with_status_code(int int1) {
		assertEquals(int1,response.getStatusCode());
	}
	
}


