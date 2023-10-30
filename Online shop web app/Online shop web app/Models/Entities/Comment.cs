namespace Online_shop_web_app.Models.Entities;

public class Comment
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int UserId { get; set; }

}
