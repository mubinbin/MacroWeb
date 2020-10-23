using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MacroWeb.Models
{ 
    public class Comment 
    {
        [Key]
        public int CommentId {get; set;}
        // one to many user
        public int UserId {get; set;}
        public User Creator {get; set;}

        // one to many massage
        public int MessageId {get; set;}
        public Message OfMessage {get; set;}

        [Required(ErrorMessage="This field is required")]
        [MinLength(5, ErrorMessage="{0} must be at least {1} characters")]
        public string CommentContent {get; set;}
        
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy)")]
        public DateTime CreatedAt {get; set;} = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy)")]
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        // many to many users
        public List<LikedComment> UserLikedThisComment{get; set;}
    }
}
