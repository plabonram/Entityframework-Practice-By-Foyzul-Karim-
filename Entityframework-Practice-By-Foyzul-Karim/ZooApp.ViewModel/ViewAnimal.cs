﻿
using ZooApp.Models;

namespace ZooApp.ViewModel
{
    public class ViewAnimal

    {

        public ViewAnimal(Animal animal)
        {
            Id = animal.Id;
            Name = animal.Name;
            Quantity = animal.Quantity;
            Origin = animal.Origin;
        }

        public int Id { get; set; }

        public string Name { get; set; }



        public string Origin { get; set; }

        public int Quantity { get; set; }

    }
}
