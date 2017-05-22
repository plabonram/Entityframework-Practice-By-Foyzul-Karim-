using System.Linq;
using System.Web.Mvc;
using ZooApp.Models;
using ZooApp.Services;

namespace ZooApp.MVCclient.Controllers
{
    public class Animal1Controller : Controller
    {
        //
        // GET: /Animal1/
        AnimalService service = new AnimalService();

        public ActionResult Index()
        {

            AnimalService service = new AnimalService();

            var ViewAnimals = service.GetAnimals();

            return View(ViewAnimals);
        }




        public ActionResult Details(int id)
        {

            var animal = service.GetAnimal(id);



            return View(animal);



        }


        [HttpGet]
        public ActionResult Create()
        {





            return View();



        }






        [HttpPost]
        public ActionResult Create(Animal animal)
        {



            bool save = service.Save(animal);

            return RedirectToAction("Index");


        }





        [HttpGet]
        public ActionResult Edit(int id)
        {



            ZooContext db = new ZooContext();

            Animal animal = db.Animals.Single(x => x.Id == id);

            return View(animal);



        }



        [HttpPost]
        public ActionResult Edit(Animal animal)
        {



            bool result = service.Update(animal);

            return RedirectToAction("Index");



        }


        [HttpGet]
        public ActionResult Delete()
        {





            return View();



        }



        [HttpPost]
        public ActionResult Delete(int id)
        {



            service.Delete(id);

            return RedirectToAction("Index");



        }

    }
}