namespace MacroWeb.Models
{
    public class Retweet
    {
        public int RetweetId {get; set;}
        public int UserId {get; set;}
        public User UserRetweet {get; set;}
        public int MessageId {get; set;}
        public Message RetweetedMessage {get; set;}
    }
}