using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ZooApp.Models;
using ZooApp.ViewModel;

namespace ZooApp.Services
{
    public class FoodService
    {



        ZooContext db = new ZooContext();


        public List<ViewFood> GetAll()
        {



            List<Food> foods = db.Foods.ToList();

            List<ViewFood> viewFoods = new List<ViewFood>();

            foreach (Food food in foods)
            {

                ViewFood viewFood = new ViewFood(food);
               


                viewFoods.Add(viewFood);

            }

            return viewFoods;

        }


        public object Get(int id)
        {

            var food = db.Foods.Find(id);
            return new ViewFood(food);




        }

        public bool Save(Food food)
        {
            db.Foods.Add(food);
            db.SaveChanges();

            return true;
        }

        public bool Update(Food food)
        {
            db.Entry(food).State = EntityState.Modified;
            db.SaveChanges();
            return true;

        }

        public bool Delete(int id)
        {
            try
            {
                var food = db.Foods.Find(id);
                db.Foods.Remove(food);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
            
        }



        public Food GetDBModel(int id)
        {
            var food = db.Foods.Find(id);

            return food;
        }


    }
}
