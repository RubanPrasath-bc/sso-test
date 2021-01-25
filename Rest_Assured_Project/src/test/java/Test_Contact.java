import org.testng.Assert;
import org.testng.annotations.Test;
import static io.restassured.RestAssured.*;
import io.restassured.RestAssured;
import io.restassured.response.Response;
import io.restassured.specification.RequestSpecification;
import static io.restassured.matcher.RestAssuredMatchers.*;
import static org.hamcrest.Matchers.*;

import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

public class Test_Contact {
	
	public void CreateContact() {
		
       RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";

       //Provide valid details in the request body
        Map<String,Object> contact = new HashMap<String, Object>();
		//Provide valid parameters in the request body
        contact.put("contactId", 1234);
	    contact.put("partyId", 2345);
	    contact.put("organisationId", 3345);
	    contact.put("name", "CCSUser");
	    contact.put("email", "CCSUserTest1@yopmail.com");
	    contact.put("teamName", "CCS Test Team");
	    contact.put("phoneNumber", "5426743174");
	    contact.put("contactType", 1);
	    
         given()
		.contentType("application/json")
		.body(contact)
		
		//Assert the status code and log the response
		.when().post("/contact").then().log().all()
		.statusCode(200);

		
	}
	
	public void CreateContactFail() {
		
	       RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";

	       //Provide valid details in the request body
	        Map<String,Object> contact = new HashMap<String, Object>();
			//Provide parameters without the required parameter contact Type in the request body
	        contact.put("contactId", 1234);
		    contact.put("partyId", 2345);
		    contact.put("organisationId", 3345);
		    contact.put("name", "CCSUser");
		    contact.put("email", "CCSUserTest1@yopmail.com");
		    contact.put("teamName", "CCS Test Team");
		    contact.put("phoneNumber", "5426743174");
		    
	         given()
			.contentType("application/json")
			.body(contact)
			
			//Assert the status code and log the response
			.when().post("/contact").then().log().all()
			.statusCode(400);

			
		}
	
	public void UpdateContact() {
		
		int contactid = 432;
		
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";

	       
        Map<String,Object> contact = new HashMap<String, Object>();
		//Provide valid parameters in the request body      
	    contact.put("phoneNumber", "6786875889");
	    contact.put("contactType", 1);
	    
         given()
		.contentType("application/json")
		.body(contact)
		
		//Assert the status code and log the response
		.when().put("/contact" + contactid).then().log().all()
		.statusCode(200);
						
	}
	
public void UpdateContactFail() {
		
	    //assign invalid user id
		int contactid = 25;
		
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";

	       
        Map<String,Object> contact = new HashMap<String, Object>();
		//Provide valid parameters in the request body      
	    contact.put("phoneNumber", "6786875889");
	    contact.put("contactType", 1);
	    
         given()
		.contentType("application/json")
		.body(contact)
		
		//Assert the status code and log the response
		.when().put("/contact" + contactid).then().log().all()
		.statusCode(400);
						
	}
	
	
	public void getContact()
	{
		
		
        int contactid = 432;
		
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
		 given()
			.contentType("application/json")
			
			//Assert the status code and log the response
			.when().get("/contact" + contactid).then().log().all()
			.statusCode(200);
				
	}
	
	public void getContactFail()
	{
		
		//Provide an invalid contactID
        int contactid = 432;
		
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
		 given()
			.contentType("application/json")
			
			//Assert the status code and log the response
			.when().get("/contact" + contactid).then().log().all()
			.statusCode(400);
				
	}
	
	public void deleteContact() 
	{
		
		int contactid = 432;
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
		RequestSpecification request = RestAssured.given();
		// Add a header stating the Request body is a JSON
		 request.header("Content-Type", "application/json"); 
		 
		       // Delete the request and check the response
		 Response response = request.delete("/contact/"+ contactid); 
		 
		 int statusCode = response.getStatusCode();
		 System.out.println(response.asString());
		 Assert.assertEquals(statusCode, 200);
		
		
		
	}
	
	public void deleteContactFail() 
	{
	
		//Provide an invalid contactID
		int contactid = 555;
		RestAssured.baseURI = "https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
		RequestSpecification request = RestAssured.given();
		
		// Add a header stating the Request body is a JSON
		 request.header("Content-Type", "application/json"); 
		 
		 // Delete the request and check the response
		 Response response = request.delete("/contact/"+ contactid); 
		 
		 int statusCode = response.getStatusCode();
		 System.out.println(response.asString());
		 Assert.assertEquals(statusCode, 200);
		
		
		
	}

}
