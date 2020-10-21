namespace MacroWeb.Models
{
    public class LikedComment
    {
        public int LikedCommentId {get; set;}
        public int UserId {get; set;}
        public User UserWhoLiked {get; set;}
        public int CommentId {get; set;}
        public Message ThisLikedComment {get; set;}
    }
}
