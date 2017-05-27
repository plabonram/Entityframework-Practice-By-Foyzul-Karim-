using System.Web.Mvc;
using ZooApp.Models;
using ZooApp.Services;

namespace ZooApp.MVCclient.Controllers
{
    public class FoodController : Controller
    {
        FoodService service = new FoodService();
        public ActionResult Index()
        {
            var viewfood = service.GetAll();
            return View(viewfood);
        }

        //
        // GET: /Food/Details/5
        public ActionResult Details(int id)
        {
            var food = service.Get(id);

            return View(food);
        }

        //
        // GET: /Food/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Food/Create
        [HttpPost]
        public ActionResult Create(Food food)
        {
            try
            {
                // TODO: Add insert logic here
                bool saved = service.Save(food);

                if (saved)
                {
                    return RedirectToAction("Index");
                }

                return View(food);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Food/Edit/5
        public ActionResult Edit(int id)
        {

            Food food = service.GetDBModel(id);

            return View(food);
        }

        //
        // POST: /Food/Edit/5
        [HttpPost]
        public ActionResult Edit(Food food)
        {
            try
            {
                // TODO: Add update logic here
                bool updated = service.Update(food);

                if (updated)
                {
                    return RedirectToAction("Index");

                }

                return View(food);

            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Food/Delete/5
        public ActionResult Delete(int id)
        {

            Food food = service.GetDBModel(id);
            return View(food);
        }

        //
        // POST: /Food/Delete/5
        [HttpPost]
        public ActionResult Delete(Food food)
        {
            try
            {
                bool deleted = service.Delete(food.Id);

                if (deleted)
                {
                    return RedirectToAction("Index");
                }
                return View();

            }
            catch
            {
                return View();
            }
        }
    }
}
