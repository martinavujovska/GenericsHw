using GenericsHomework.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework
{
    public class PetStore<T> where T : Pet
    {
        public List<T> pets = new List<T>();

        public void PrintPets()
        {
            foreach (T pet in pets)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }
        public void BuyPet(string name)
        {
            T pet = pets.Single(x => x.Name == name);
            if (pet == null)
            {
                Console.WriteLine($"We don't have that animal, sry. ");

            }
            pets.Remove(pet);
            Console.WriteLine($"You have successfully bought {pet.Name}.");
        }
    }
}


