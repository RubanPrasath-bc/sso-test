import io.restassured.RestAssured;
import io.restassured.response.Response;
import io.restassured.specification.RequestSpecification;

import static io.restassured.RestAssured.given;
import static io.restassured.matcher.RestAssuredMatchers.*;
import static org.hamcrest.Matchers.*;

import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

import org.testng.Assert;

public class Test_Organisation {
	
	public void CreateOrganisation() {
		
	       RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";

	       //Provide valid details in the request body
	        Map<String,Object> organisation = new HashMap<String, Object>();
			//Provide valid parameters in the request body
	        organisation.put("organisationId", 456546);
	        organisation.put("organisationUri", "testorg.uk.com");
	        organisation.put("rightToBuy", true);
	        organisation.put("partyId", "56235263");
		 
		    
	         given()
			.contentType("application/json")
			.body(organisation)
			
			//Assert the status code and log the response
			.when().post("/organisation").then().log().all()
			.statusCode(200);

			
		}
		
		public void CreateOrganisationFail() {
			
		       RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
		      
		        Map<String,Object> organisation = new HashMap<String, Object>();
				//Provide parameters without the required parameter values in the request body
		        organisation.put("organisationId", 888);
		        organisation.put("organisationUri", "");
		        organisation.put("rightToBuy", true);
		        organisation.put("partyId", "");
			    
		         given()
				.contentType("application/json")
				.body(organisation)
				
				//Assert the status code and log the response
				.when().post("/organisation").then().log().all()
				.statusCode(400);

				
			}
		
		
		
		public void getOrganisation()
		{
			
			//Provide a valid organization ID 
	        int organisationid = 78999;
			
			RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
			 given()
				.contentType("application/json")
				
				//Assert the status code and log the response
				.when().get("/organisation" + organisationid).then().log().all()
				.statusCode(200);
					
		}
		
		public void getOrganisationFail()
		{
			
			//Provide an invalid organizationID
	        int organisationid = 432;
			
			RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
			 given()
				.contentType("application/json")
				
				//Assert the status code and log the response
				.when().get("/organisation" + organisationid).then().log().all()
				.statusCode(400);
					
		}
		
		public void deleteOrganisation() 
		{
			//Pass a valid organization ID
			int organisationid = 672222;
			
			RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
			RequestSpecification request = RestAssured.given();
			// Add a header stating the Request body is a JSON
			 request.header("Content-Type", "application/json"); 
			 
			 // Try to delete the organization and check the response
			 Response response = request.delete("/organisation"+ organisationid); 
			 
			 int statusCode = response.getStatusCode();
			 System.out.println(response.asString());
			 Assert.assertEquals(statusCode, 200);
			
			
			
		}
		
		public void deleteOrganisationFail() 
		{
		
			//Provide an invalid organization
			int contactid = 555;
			RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
			RequestSpecification request = RestAssured.given();
			
			// Add a header stating the Request body is a JSON
			 request.header("Content-Type", "application/json"); 
			 
			 // Try to delete the organization and check the response
			 Response response = request.delete("/organisation/"+ contactid); 
			 
			 int statusCode = response.getStatusCode();
			 System.out.println(response.asString());
			 Assert.assertEquals(statusCode, 400);
			
			
			
		}

}
