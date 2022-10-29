﻿using _02._AnimalDoctor.Models;
using _02._AnimalDoctor.Models.Interfaces;
using System;

namespace _02._AnimalDoctor
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinic clinic = new Clinic();
            Cat cat = new Cat("003","Pufi", "01/10/2019");
            clinic.AddAnimal(cat);
            IAnimal myCat = clinic.GetAnimal("002");
            Console.WriteLine(cat);
            IChip chip = new Chip();
            chip.InstallChip("001", cat);
            cat.SetChip(chip);

            IOwner ceco = new Owner("Ceco", "Rad", "08545");
            ceco.AddAnimal(cat);
            cat.SetOwner(ceco);
            Console.WriteLine();
            Console.WriteLine(cat);
            Console.WriteLine(ceco);
        }
    }
}
