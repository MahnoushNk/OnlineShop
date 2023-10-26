namespace Online_shop_web_app.Models.Entities;


    public class Checkout
    {


        public int Id { get; set; }
        public Person person { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }


    }

