namespace Online_shop_web_app.Models.Entities;


public class Checkout
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int ProductQuantity { get; set; }
    public int PaymentId { get; set; }


}

