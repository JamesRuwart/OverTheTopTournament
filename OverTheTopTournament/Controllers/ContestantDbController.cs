using Microsoft.AspNetCore.Mvc;
using OverTheTopTournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverTheTopTournament.Controllers
{
    public class ContestantDbController : Controller
    {

        private readonly ContestantDbContext _context;

        public ContestantDbController(ContestantDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //print out alllll the supers
            return View(_context.FirstName.ToList());
        }

       
        [HttpGet]
        public IActionResult AddContestant()
        {
            return View();
        }
        //CREATE A FORM
        [HttpPost]
        public IActionResult AddContestant(Contestant newContestant)
        {
            
            if (ModelState.IsValid)
            {

                _context.FirstName.Add(newContestant);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        public IActionResult DeleteContestant(int id)
        {
            Contestant found = _context.Contestant.Find(id);
                _context.Contestant.Remove(found);
                _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateContestant(int id)
        {
            Contestant found = _context.Contestant.Find(id);
            return View(found);
        }

        [HttpPost]
        public IActionResult UpdateContestant(Contestant updatedContestant)
        {
            Contestant dbContestant = _context.Contestant.Find(updatedContestant.Id);
            if (ModelState.IsValid)
            {
                dbContestant.FirstName = updatedContestant.FirstName;
                dbContestant.LastName = updatedContestant.LastName;

                //when using _context.Update, you need to change the Entry state.
                _context.Entry(dbContestant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(dbContestant);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");

        }
    }
}
