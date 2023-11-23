namespace OnlineShop.Domain.Entities;

public class Payment
{
    public int Id { get; set; }
    public int CreditCardNumber { get; set; }      
    public int Cvv2 { get; set; }   
    public int Expiration { get; set; }
    public int Password { get; set; }


}
