using PetDoor;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        DogDoor door = new DogDoor();
        door.SetAllowedBarks(new Bark("rowlf"));
        door.SetAllowedBarks(new Bark("rooowlf"));
        door.SetAllowedBarks(new Bark("rawlf"));
        door.SetAllowedBarks(new Bark("woof"));
        BarkRecognizer recognizer = new BarkRecognizer(door);
        Remote remote = new Remote(door);

        //Console.WriteLine("Fido barks to go outside...");
        //remote.pressButton();
        //Console.WriteLine("\nFido has gone outside...");
        //Thread.Sleep(10000);
        //if (!door.isOpen())
        //{
        //    Console.WriteLine("Oh no, Fido is stuck outside");
        //    Console.WriteLine("Fido barks to come back inside...");
        //    remote.pressButton();
        //}
        //Console.WriteLine("\nFido's all done");
        //Console.WriteLine("\nFido's back inside...");
        //Thread.Sleep(10000);

        //Console.WriteLine("Fido starts barking...");
        //recognizer.recognize("Woof");
        //Console.WriteLine("\nFido has gone outside...");
        //Thread.Sleep(10000);
        //Console.WriteLine("Another dog comes and bark 'Rowlf");
        //recognizer.recognize("Rowlf");
        //Thread.Sleep(10000);
        //Console.WriteLine("\nFido's all done");
        //if (!door.isOpen())
        //{
        //    Console.WriteLine("Oh no, Fido is stuck outside");
        //    Console.WriteLine("Fido starts barking...");
        //    recognizer.recognize("Woof");
        //}
        //Console.WriteLine("\nFido's back inside...");
        //Thread.Sleep(10000);

        Console.WriteLine("Bruce starts barking...");
        recognizer.recognize(new Bark("Rowlf"));
        Console.WriteLine("\nBruce has gone outside...");
        Thread.Sleep(10000);
        Console.WriteLine("\nBruce's all done");
        Bark smallDogBark = new Bark("Yip");
        Console.WriteLine("A small dog starts barking");
        recognizer.recognize(smallDogBark);
        Thread.Sleep(10000);
        if (!door.isOpen())
        {
            Console.WriteLine("Oh no, Bruce is stuck outside");
            Console.WriteLine("Bruce starts barking...");
            recognizer.recognize(new Bark("rawlf"));
        }
        Console.WriteLine("\nBruce's back inside...");
        Thread.Sleep(10000);
    }
}