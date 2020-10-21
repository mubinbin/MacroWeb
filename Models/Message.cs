using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace MacroWeb.Models
{ 
    public class Message 
    {
        [Key]
        public int MessageId {get; set;}
        // one to many user
        public int UserId {get; set;}
        public User Creator {get; set;}

        public bool IsRetweet {get; set;} = false;

        [Required(ErrorMessage="Message cannot be blank!")]
        [MinLength(5, ErrorMessage="{0} must be at least {1} characters")]
        public string MessageContent {get; set;}
        
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy)")]
        public DateTime CreatedAt {get; set;} = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy)")]
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        
        // one to many comment
        public List<Comment> CommentsForMessage {get; set;}

        // many to many users (like)
        public List<LikedMessage> UsersLikedThisMessage {get; set;}

        // many to many users (retweet)
        public List<Retweet> UsersRetweeted {get; set;}

        [NotMapped]
        [BindProperty]
        public Message new_message {get; set;}
    }
}
