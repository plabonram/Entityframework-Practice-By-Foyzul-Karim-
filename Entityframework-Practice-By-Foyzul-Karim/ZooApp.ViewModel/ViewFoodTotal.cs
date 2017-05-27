using ZooApp.Models;

namespace ZooApp.ViewModel
{
    public class ViewFoodTotal
    {

        public ViewFoodTotal(AnimalFood animalFood)
        {

            FoodName = animalFood.Food.Name;
            FoodPrice = animalFood.Food.Price;
            TotalQuantity = animalFood.Animal.Quantity * animalFood.Quantity;
            TotalPrice = TotalQuantity * FoodPrice;

        }

        public double TotalQuantity { get; private set; }

        public double TotalPrice { get; set; }



        public double FoodPrice { get; set; }

        public string FoodName { get; set; }
    }
}
