namespace MacroWeb.Models
{
    public class LikedMessage
    {
        public int LikedMessageId {get; set;}
        public int UserId {get; set;}
        public User UserWhoLiked {get; set;}
        public int MessageId {get; set;}
        public Message ThisLikedMessage {get; set;}
    }
}
