using RickGuitar;
using Type = RickGuitar.Type;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        initializeInventory(inventory);

        GuitarSpec whatErinLikes = new GuitarSpec(Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, 6);

        List<Instrument> guitars = inventory.search(whatErinLikes);

        if (guitars.Count > 0)
        {
            Console.WriteLine("Erin you might like this: ");
            foreach(Guitar guitar in guitars)
            {
                string msg = $"{guitar.Price} {guitar.SerialNumber} {guitar.Spec.ToString()}";
                Console.WriteLine(msg);
            }
        }

        MandolinSpec whatJaneLikes = new MandolinSpec(Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, Style.F);

        List<Instrument> mandolins = inventory.search(whatJaneLikes);

        if (mandolins.Count > 0)
        {
            Console.WriteLine("Jane you might like this: ");
            foreach (Mandolin mandolin in mandolins)
            {
                string msg = $"{mandolin.Price} {mandolin.SerialNumber} {mandolin.Spec.ToString()}";
                Console.WriteLine(msg);
            }
        }
    }

    static void initializeInventory(Inventory inventory)
    {
        // Add guitars
        inventory.addInstrument("V95693", 1499.95, new GuitarSpec(Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, 6));
        inventory.addInstrument("V95121", 1549.95, new GuitarSpec(Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, 6));
        inventory.addInstrument("V95122", 1299.99, new GuitarSpec(Builder.Fender, "Classic", Type.Acoustic, Wood.Mahogany, Wood.Mahogany, 6));
        inventory.addInstrument("V95124", 1199.99, new GuitarSpec(Builder.Fender, "Classic", Type.Acoustic, Wood.Maple, Wood.Maple, 6));
        inventory.addInstrument("V95125", 899.99, new GuitarSpec(Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, 4));
        inventory.addInstrument("V95126", 1399.99, new GuitarSpec(Builder.Fender, "Classic", Type.Acoustic, Wood.Cocobolo, Wood.Cocobolo, 6));

        // Add mandolins
        inventory.addInstrument("V95694", 1499.95, new MandolinSpec(Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, Style.A));
        inventory.addInstrument("V95195", 1549.95, new MandolinSpec(Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, Style.F));
        inventory.addInstrument("V95196", 1299.99, new MandolinSpec(Builder.Fender, "Classic", Type.Acoustic, Wood.Mahogany, Wood.Mahogany, Style.A));
        inventory.addInstrument("V95197", 1199.99, new MandolinSpec(Builder.Fender, "Classic", Type.Acoustic, Wood.Maple, Wood.Maple, Style.F));
        inventory.addInstrument("V95198", 899.99, new MandolinSpec(Builder.Fender, "Stratocaster", Type.Electric, Wood.Alder, Wood.Alder, Style.F));
        inventory.addInstrument("V95199", 1399.99, new MandolinSpec(Builder.Fender, "Classic", Type.Acoustic, Wood.Cocobolo, Wood.Cocobolo, Style.A));
    }
}