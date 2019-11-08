using System;
using System.ComponentModel.DataAnnotations;


namespace Naruto.Models
{
    public class Ninjutsu
    {
        [Key]
        public int NinjutsuId {get;set;}
        public int NinjaId {get;set;}
        public Ninja ThatNinja {get;set;}
        public int JutsuId {get;set;}
        public Jutsu ThatJutsu {get;set;}
    }
}