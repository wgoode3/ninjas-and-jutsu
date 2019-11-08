using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Naruto.Models
{
    public class Jutsu
    {
        [Key]
        public int JutsuId {get;set;}
        [Required (ErrorMessage = "Your Jutsu Technique needs a name!")]
        public string TechniqueName {get;set;}
        public List<Ninjutsu> JutsuUsers {get;set;}
    }
}