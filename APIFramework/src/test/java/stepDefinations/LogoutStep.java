package stepDefinations;

import static io.restassured.RestAssured.given;
import static org.junit.Assert.assertEquals;

import java.io.IOException;

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

public class LogoutStep extends Utils {
	
	RequestSpecification res;
	ResponseSpecification resspec;
	Response response;
	TestDataBuild data =new TestDataBuild();
	
	@Given("Logout user with {string}")
	public void logout_user_with(String userName) throws IOException {
		res=given().spec(requestSpecification()).contentType("application/json").body(data.logoutPayLoad(userName));
		System.out.println("Response"+res.toString());
		
		
		}
	
	@When("user1 calls {string} with {string} http request")
	public void user1_calls_with_http_request(String resource, String method) {
		APIResources resourceAPI=APIResources.valueOf(resource);
		System.out.println("resource"+resourceAPI.getResource());
	
		resspec =new ResponseSpecBuilder().expectStatusCode(200).expectContentType(ContentType.JSON).build();
		
		if(method.equalsIgnoreCase("POST"))
		 response =res.when().post(resourceAPI.getResource());
		else if(method.equalsIgnoreCase("GET"))
			 response =res.when().get(resourceAPI.getResource());
	}
	@Then("the API call1 got success with status code {int}")
	public void the_api_call1_got_success_with_status_code(int int1) {
		assertEquals(int1,response.getStatusCode());
	}

}
