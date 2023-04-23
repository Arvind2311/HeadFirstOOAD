using rick.guitar;
using Type = rick.guitar.Type;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        initializeInventory(inventory);

        GuitarSpec whatErinLikes = new GuitarSpec(Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, 6);

        List<Guitar> guitars = inventory.search(whatErinLikes);

        if (guitars.Count > 0)
        {
            Console.WriteLine("Erin you might like this: ");
            foreach(Guitar guitar in guitars)
            {
                string msg = $"{guitar.Price} {guitar.SerialNumber} {guitar.GuitarSpec.ToString()}";
                Console.WriteLine(msg);
            }
        }
    }

    static void initializeInventory(Inventory inventory)
    {
        inventory.addGuitar("V95693", 1499.95, Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, 6);
        inventory.addGuitar("V95121", 1549.95, Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, 6);
        inventory.addGuitar("V95122", 1299.99, Builder.Fender, "Classic", Type.Acoustic, Wood.Mahogany, Wood.Mahogany, 6);
        inventory.addGuitar("V95124", 1199.99, Builder.Fender, "Classic", Type.Acoustic, Wood.Maple, Wood.Maple, 6);
        inventory.addGuitar("V95125", 899.99, Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, 4);
        inventory.addGuitar("V95126", 1399.99, Builder.Fender, "Classic", Type.Acoustic, Wood.Cocobolo, Wood.Cocobolo, 6);
    }
}