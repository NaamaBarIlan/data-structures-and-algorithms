using System;

namespace AnimalShelter
{
    public class AnimalShelter
    {
        Queue dogQueue = new Queue();
        Queue catQueue = new Queue();

        // enqueue(animal)  adds animal to the shelter. animal can be either a dog or a cat object.

        public static Queue Enqueue(Animal animal)
        {
            Queue shelter = new Queue();

            if (shelter.Front == null)
            {
                shelter.Front = animal;
            }

            shelter.Rear = animal;

            return shelter;
        }


        // dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.
    }
}
