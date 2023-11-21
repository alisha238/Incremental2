// using System;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc;

// namespace dotnetapp.Models{
//     public class AppliDbcontext: Dbcontext{

//         public virtual DbSet<Player> Players{get; set;}

//         public AppliDbcontext(){}
//         public AppliDbcontext(DbContextOptions< AppliDbcontext> options):base(options){

//         }
//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
//             if(!optionsBuilder.IsConfigured){
//                 optionsBuilder.UseSqlServer("");
//             }
//         }

//     }
// }