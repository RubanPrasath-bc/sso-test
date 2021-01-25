package cucumber.Options;



import org.junit.runner.RunWith;



import io.cucumber.junit.Cucumber;
import io.cucumber.junit.CucumberOptions;




@RunWith(Cucumber.class)
/*
 * @CucumberOptions(features="src/test/java/features", plugin =
 * {"com.cucumber.listener.ExtentCucumberFormatter:target/cucumber-reports/report.html"
 * }, glue= {"stepDefinations"})
 */

@CucumberOptions(features = "src/test/java/features"
,glue = { "stepDefinations" }
,tags = "@LogoutAPI"
)


public class TestRunner {
	
}


