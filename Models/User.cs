using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace MacroWeb.Models
{ 
    public class User 
    { 
        [Key]
        public int UserId {get; set;}
        [Required(ErrorMessage="This field is required")]
        [StringLength(45, MinimumLength=2, ErrorMessage="{0} must be between {2} and {1}")]
        public string Name {get; set;}
        [Required(ErrorMessage="This field is required")]
        [EmailAddress]
        public string Email {get; set;}
        [Required(ErrorMessage="This field is required")]
        [MinLength(8, ErrorMessage="{0} must be at least {1} characters")]
        [DataType(DataType.Password)]
        public string Password {get; set;}
        [Required(ErrorMessage="This field is required")]
        [NotMapped]
        [Display(Name="Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPW {get; set;}
        public string ImagePath { get; set; }
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        // follow or unfllow users many to many
        [InverseProperty("UserFollowed")]
        public List<Connection> Followers { get; set; }

        [InverseProperty("Follower")]
        public List<Connection> UsersFollowed { get; set; }

        [NotMapped]
        [Display(Name="Upload Profile Image")]
        public IFormFile ImageFile { get; set; }

        // one to many Message 
        public List<Message> PostMessages {get; set;}
        // one to many Comment 
        public List<Comment> PostComments {get; set;}

        // liked message or comment many to many
        public List<LikedMessage> LikedMessages {get; set;}
        public List<LikedComment> LikedComments {get; set;}

        [BindProperty]
        [NotMapped]
        public List<int> UsersAreChecked {get; set;}
    }
}