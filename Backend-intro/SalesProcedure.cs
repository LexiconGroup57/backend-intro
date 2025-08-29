using System.Net.Mail;

namespace Backend_intro;

public class SalesProcedure
{
    public static void SellingStuff(string[] cart, string[] freightCompanies)
    {

        if (!ProductInventory.CheckStock(cart)) return;
        ServiceProvider.GetDeliveryPoint(freightCompanies);
        // IMessage.SalesConfirmation("message");
        return;
    }


    


}