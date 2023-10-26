namespace Online_shop_web_app.Models.Entities;

public class Payment
{
        
    public int CreditCardNumber { get; set; }      
    public int Cvv2 { get; set; }
    public int secondPasword { get; set; }
    public int Id { get; set; }
    public int CheckoutId { get; set; }   
    public int ExpirationMonth { get; set; }
    public int ExpirationYear { get; set; }
    public int Password { get; set; }


}
