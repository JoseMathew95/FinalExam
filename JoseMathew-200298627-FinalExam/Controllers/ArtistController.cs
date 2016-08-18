using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JoseMathew_200298627_FinalExam.Models;


// Jose Mathew
// modifid 18/08/2016
// 200298627
// creates controller for Artist
namespace JoseMathew_200298627_FinalExam.Controllers
{
    public class ArtistController : Controller
    {
        MVCMusicStoreContext storeDB = new MVCMusicStoreContext();
        // GET: Genre
        public ActionResult Index()
        {
            List<Artist> genres = storeDB.Artists.ToList();

            return View(genres);
        }
    }
}