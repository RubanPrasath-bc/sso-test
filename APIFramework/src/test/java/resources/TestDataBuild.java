package resources;

import java.util.HashMap;
import java.util.Map;

public class TestDataBuild {

	
	
	public Map<String, Object> loginPayLoad(String userName, String userPassword)
	{
		 Map<String,Object> login = new HashMap<String, Object>();
			//Provide valid parameters in the request body
		    login.put("userName", userName);
		    login.put("userPassword", userPassword);
		
		return login;
	
	}
	
	public String logoutPayLoad(String userName)
	{
				
		return "\""+userName+"\"";
	}
	
}
