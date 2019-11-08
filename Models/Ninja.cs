using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Naruto.Models
{
    public class Ninja
    {
        [Key]
        public int NinjaId {get;set;}
        [Required (ErrorMessage = "Your ninja needs a name!")]
        public string Name {get;set;}
        [Required (ErrorMessage = "Your ninja needs a chakra!")]
        [Range (1, 9, ErrorMessage = "Your chakra must be between level 1 and level 9")]
        public int? Chakra {get;set;}
        public List<Ninjutsu> KnownJutsu {get;set;}
    }
}