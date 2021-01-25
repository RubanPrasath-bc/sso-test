package stepDefinations;

import java.io.FileInputStream;
import java.io.IOException;
import java.util.Properties;

import javax.crypto.Cipher;


import io.cucumber.java.Before;

public class Hooks {
	static String baseUrl="https://ccs-sso-api-relaxed-platypus-dx.london.cloudapps.digital";
	static Cipher cipher; 
	@Before("@LoginAPI")
	public static void beforeScenario() throws IOException, Exception
	{		//execute this code only when place id is null
		/*
		 * //write a code that will give you place id KeyGenerator keyGenerator =
		 * KeyGenerator.getInstance("AES"); keyGenerator.init(128); // block size is
		 * 128bits SecretKey secretKey = keyGenerator.generateKey(); cipher =
		 * Cipher.getInstance("AES"); //SunJCE provider AES algorithm, mode(optional)
		 * and padding schema(optional)
		 * 
		 * String plainText = "AES Symmetric Encryption Decryption";
		 * System.out.println("Plain Text Before Encryption: " + plainText);
		 * 
		 * EncryptionDecryptionAES aes = new EncryptionDecryptionAES(); String
		 * encryptedUrl = aes.encrypt(cipher, baseUrl, secretKey);
		 * System.out.println(encryptedUrl);
		 * 
		 * String decryptedUrl = aes.decrypt(cipher, encryptedUrl, secretKey);
		 * System.out.println(decryptedUrl);
		 */
		//LoginStep m =new LoginStep();
		
		

	}
	
	
}
