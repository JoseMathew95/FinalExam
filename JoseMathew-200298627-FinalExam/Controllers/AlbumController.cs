using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JoseMathew_200298627_FinalExam.Models;


// Jose Mathew
// modifid 18/08/2016
// 200298627
// creates controller for Album
namespace JoseMathew_200298627_FinalExam.Controllers
{
    public class AlbumController : Controller
    {
        MVCMusicStoreContext storeDB = new MVCMusicStoreContext();
        // GET: Genre
        public ActionResult Index()
        {
            List<Album> genres = storeDB.Albums.ToList();

            return View(genres);
        }
    }
}