// Models/Player.cs
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations.Schema;



namespace dotnetapp.Models
{
    [Index("Id", IsUnique= true)]
    public class Player{
        [Required]
    public int Id{get; set;}

    [Required(ErrorMessage ="Name is required.")]
    public string Name{ get; set;}

    [ForeignKey("Team")]
    public int TeamId{get; set;}
    public int Age{get; set;}
    public string Category{get; set;}

    [Range(1, int.MaxValue,ErrorMessage= "Bidding amount must be greater than 0.")]
    public decimal BiddingAmount{get; set;}

    //public Team Team{get; set;}

    }
}


