using Generics.Classes;
using GenericsHomework;
using GenericsHomework.Classes;
using GenericsHomework.Enums;
using GenericsHomework.Classes;

Cat Tosho = new Cat("Tosho", 1, GenericsHomework.Enums.Type.Cat, 9, true);
Cat Ganymede = new Cat("Ganymede", 11, GenericsHomework.Enums.Type.Cat, 7, false);

Dog Nela = new Dog("Nela", 7, GenericsHomework.Enums.Type.Dog, true, "Dog food");
Dog Oskar = new Dog("Oskar", 5, GenericsHomework.Enums.Type.Dog, false, "Meat");

Fish Orange = new Fish("Orange", 2, GenericsHomework.Enums.Type.Fish, "Gold", "large");
Fish Bobby = new Fish("Bobby", 10, GenericsHomework.Enums.Type.Fish, "Grey", "extra large");


PetStore<Fish> FishStore = new PetStore<Fish>();
PetStore<Dog> DogStore = new PetStore<Dog>();
PetStore<Cat> CatStore = new PetStore<Cat>();
PetStore<Pet> WholeStore = new PetStore<Pet>();

List<Fish> FishList = new List<Fish> { Orange, Bobby };
List<Dog> DogList = new List<Dog> { Nela, Oskar };
List<Cat> CatList = new List<Cat> { Tosho, Ganymede };
List<Pet> PetList = new List<Pet> { Tosho, Ganymede, Nela, Oskar, Orange, Bobby };

FishStore.pets.Add(Orange);
FishStore.pets.Add(Bobby);
DogStore.pets.Add(Nela);
DogStore.pets.Add(Oskar);
CatStore.pets.Add(Tosho);
CatStore.pets.Add(Ganymede);

Console.WriteLine("Dogs:");
DogStore.PrintPets();
Console.WriteLine("Cats:");
CatStore.PrintPets();
Console.WriteLine("Fish:");
FishStore.PrintPets();



DogStore.BuyPet(Oskar.Name);
CatStore.BuyPet(Ganymede.Name);



