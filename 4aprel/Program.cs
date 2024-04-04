namespace _4aprel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot pasha = new Parrot();
            Shark akula = new Shark();
            Eagle eagle = new Eagle();
            Animal[] animals = { pasha, akula, eagle };
            foreach (Animal animal in animals)
            {
                animal.Eat();
            }

            //pasha.Eat();
            //akula.Eat();
            //pasha.Fly();
            //eagle.Fly();
            //eagle.Eat();
            
        }
    }
}
