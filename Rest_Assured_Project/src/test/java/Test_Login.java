import org.testng.Assert;
import org.testng.annotations.Test;
import static io.restassured.RestAssured.*;
import io.restassured.RestAssured;
import io.restassured.response.Response;
import io.restassured.specification.RequestSpecification;
import static io.restassured.matcher.RestAssuredMatchers.*;
import static org.hamcrest.Matchers.*;
import io.restassured.authentication.PreemptiveBasicAuthScheme;
public class Test_Login {
	
	@Test
	
	//Test case ID 0001 - Verify the successfully login scenario.
    public void LoginSuccess() {
        
		//Provide the base URL
        RestAssured.baseURI = "https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
        PreemptiveBasicAuthScheme authScheme = new PreemptiveBasicAuthScheme();
        
        //Add valid user name and password to the request body
        authScheme.setUserName("TestCCSUser");
        authScheme.setPassword("TestCCSUser@123");
        RestAssured.authentication = authScheme;

        given().header("Content-Type","application/json")
        .when().post("Security/login")
        
        //Assert the status code and log the response
        .then().log().all().assertThat().statusCode(200);
        
    }
	
	
	@Test
	
	//Test case ID 0002 - Verify the login fail scenario.
    public void LoginFail() {
        
		//Provide the base URL
        RestAssured.baseURI = "https://bed9805a-9b64-4084-8cc9-fad6c6c793c4.mock.pstmn.io";
        PreemptiveBasicAuthScheme authScheme = new PreemptiveBasicAuthScheme();
        
        //Add invalid user name and password to the request body
        authScheme.setUserName("InvalidTestCCSUser");
        authScheme.setPassword("InvalidTestCCSUserPW");
        RestAssured.authentication = authScheme;

        given().header("Content-Type","application/json")
        .when().post("Security/loginfail")
        
        //Assert the status code and log the response
        .then().log().all().assertThat().statusCode(401);
        
    }
	
	

}
