namespace Backend_intro;

public class ServiceProvider
{
    public static void GetDeliveryPoint(string[] freightCompanies)
    {
        if (freightCompanies.Contains("PostNord"))
        {
            HttpClient client = new HttpClient();
            var servicePoint = client.GetAsync("api2.postnord.com/rest/businesslocation");

        }
        if (freightCompanies.Contains("UPS"))
        {
            HttpClient client = new HttpClient();
            var servicePoint = client.GetAsync("api2.postnord.com/rest/businesslocation");
        }
    }
}