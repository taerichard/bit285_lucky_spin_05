using System;
using System.ComponentModel.DataAnnotations;

namespace LuckySpin.Models
{
    public class Player
    {
        //TODO: Include two annotations for FirstName
        // one that makes it Required (no empty strings)
        // and another that sets its Display prompt to "Your First Name"
        [Required(ErrorMessage ="Please enter your Name")]
        [Display(Prompt = "FirstName", Description ="Your First Name")]
        //[Display(Name = "FirstName", Prompt ="Please enter your Name")]
        public string FirstName { get; set; }
        //TODO: Include one annotation for LufckyNumber 
        // one that limits its Range between 1 and 9
        [Range(1, 9, ErrorMessage ="Choose a number")]  
        public int LuckyNumber { get; set; }
    }
} 