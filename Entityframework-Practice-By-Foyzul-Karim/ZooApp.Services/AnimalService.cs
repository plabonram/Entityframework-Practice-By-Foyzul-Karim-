using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ZooApp.Models;
using ZooApp.ViewModel;

namespace ZooApp.Services
{
    public class AnimalService
    {
        ZooContext db = new ZooContext();


        public List<ViewAnimal> GetAll()
        {



            List<Animal> animals = db.Animals.ToList();

            List<ViewAnimal> viewAnimals = new List<ViewAnimal>();

            foreach (Animal animal in animals)
            {

                ViewAnimal viewAnimal = new ViewAnimal(animal);



                viewAnimals.Add(viewAnimal);

            }

            return viewAnimals;

        }


        public object Get(int id)
        {

            var animal = db.Animals.Find(id);
            return new ViewAnimal(animal);




        }

        public bool Save(Animal animal)
        {
            db.Animals.Add(animal);
            db.SaveChanges();

            return true;
        }

        public bool Update(Animal animal)
        {
            db.Entry(animal).State = EntityState.Modified;
            db.SaveChanges();
            return true;

        }

        public void Delete(int id)
        {
            Animal animal = db.Animals.Find(id);
            db.Animals.Remove(animal);
            db.SaveChanges();
        }


        public Animal GetDbModel(int id)
        {
            var animal = db.Animals.Find(id);

            return animal;
        }
    }
}
