using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Controllers
{
    public class PlayerController: Controller
    {
        private readonly ApplicationDbContext context;

        public PlayerController(ApplicationDbContext _context){
            context = _context;
        }

       [Route("")]
        public IActionResult Index(){
            var data = context.Players.ToList();
            return View(data);
        }

       public IActionResult Display(int Id)
 
   {
       var data = context.Players.Find(Id);
       return View(data);
   }
 

        public IActionResult Edit ( int Id){
            var data = context.Players.Find(Id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Player e){
            Player pla = context.Players.Find(e.Id);
            pla.Name= e.Name;
            pla.Age = e.Age;
            pla.Category= e.Category;

            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("create")]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Player p){
            if (ModelState.IsValid){
            context.Players.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
            
            }
            return View(p);
        }

        public IActionResult Delete(int Id){
            var data = context.Players.Find(Id);
            return View(data);

        }

        public IActionResult Delete(Player p)
         {
               Player player=context.Players.Find(p.Id);
               context.Players.Remove(player);
               context.SaveChanges();
               return RedirectToAction("Index");
         }

        [HttpPost]
        public IActionResult DeleteConfirmed (int Id){
            Player pla = context.Players.Find(Id);
            context.Players.Remove(pla);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}



// using System;
// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using System.ComponentModel.DataAnnotations.Schema;
// using dotnetapp.Models;
 
// namespace dotnetapp.Controllers;
//    public class PlayerController : Controller
//    {
//        private static List<Player>Players = new List<Player>{new Player{Id=1,Name="Siddhi",Age=21,Category="Fielder",BiddingAmount=29167}};
//        private readonly ApplicationDbContext context;
 
//        public PlayerController(ApplicationDbContext _context)
//        {
//            context = _context;
//        }
 
//     [Route("")]
//    public IActionResult Index()
 
//    {
//        var data = context.Players.ToList();
//        return View(data);
//    }
 
//    public IActionResult Display(int Id)
 
//    {
//        var data = context.Players.Find(Id);
//        return View(data);
//    }
 
 
//    [Route("create")]
 
//    public IActionResult Create()
//    {
//        return View();
//    }
//    [HttpPost]
//    [Route("create")]
//    public IActionResult Create(Player play)
//    {
 
//            context.Players.Add(play);
//            context.SaveChanges();  
//            return RedirectToAction("Index");
      
//    }
//    public IActionResult Edit(int Id)
//    {
//        var data = context.Players.Find(Id);
//        return View(data);
//    }
//    [HttpPost]
//    public IActionResult Edit(Player play)
//    {
      
//            Player player = context.Players.Find(play.Id);                                      
//            player.Name = play.Name;
//            player.Age = play.Age;
//            player.Category = play.Category;
//            player.BiddingAmount=play.BiddingAmount;
          
//            context.SaveChanges();
//            return RedirectToAction("Index");
//    }
 
//   public IActionResult Delete(int id)
//        {
//            var data = context.Players.Find(id);
//            return View(data);
//        }
//        [HttpPost]
//        public IActionResult Delete(Player p)
//        {
//                Player player=context.Players.Find(p.Id);
//                context.Players.Remove(player);
//                context.SaveChanges();
//                return RedirectToAction("Index");
//        }
 
// // public IActionResult Delete(int id)
// //         {
// //             var data = context.Players.Find(id);
// //             return View(data);
// //         }
//        [HttpPost]
//        public IActionResult DeleteConfirmed(int id)
//        {
//                var ps = context.Players.Find(id);
//                context.Players.Remove(ps);
//                context.SaveChanges();
//                return RedirectToAction("Index");
//        }
 
 
//    }