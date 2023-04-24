using System.ComponentModel.DataAnnotations.Schema;
using RickGuitar;
using Type = RickGuitar.Type;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        initializeInventory(inventory);

        Dictionary<string, string> whatErinLikes = new Dictionary<string, string>();
        whatErinLikes.Add("builder", Builder.Fender.ToString());
        whatErinLikes.Add("model", "Stratocaster");
        whatErinLikes.Add("type", Type.Electric.ToString());
        whatErinLikes.Add("backWood", Wood.Alder.ToString());
        whatErinLikes.Add("topWood", Wood.Alder.ToString());
        whatErinLikes.Add("numStrings", "6");

        List<Instrument> guitars = inventory.search(new InstrumentSpec(whatErinLikes));

        if (guitars.Count > 0)
        {
            Console.WriteLine("Erin you might like this: ");
            foreach(var guitar in guitars)
            {
                string msg = $"{guitar.Price} {guitar.SerialNumber} {guitar.Spec.ToString()}";
                Console.WriteLine(msg);
            }
        }

        Dictionary<string, string> whatJaneLikes = new Dictionary<string, string>
        {
            {"builder", Builder.Fender.ToString()},
            {"model", "Stratocaster"},
            {"type", Type.Electric.ToString()},
            {"topWood", Wood.Alder.ToString()},
            {"backWood", Wood.Alder.ToString()},
            {"style", Style.F.ToString()}
        };


        List<Instrument> mandolins = inventory.search(new InstrumentSpec(whatJaneLikes));

        if (mandolins.Count > 0)
        {
            Console.WriteLine("Jane you might like this: ");
            foreach (var mandolin in mandolins)
            {
                string msg = $"{mandolin.Price} {mandolin.SerialNumber} {mandolin.Spec.ToString()}";
                Console.WriteLine(msg);
            }
        }
    }

    static void initializeInventory(Inventory inventory)
    {
        // Add guitars
        inventory.addInstrument("V95693", 1499.95, new InstrumentSpec(new Dictionary<string, string>
    {
        {"instrumentType", Type.Electric.ToString()},
        {"builder", Builder.Collings.ToString()},
        {"model", "Stratocaster"},
        {"numStrings", "6"},
        {"topWood", Wood.Alder.ToString()},
        {"backWood", Wood.Alder.ToString()}
    }));

        inventory.addInstrument("V95121", 1549.95, new InstrumentSpec(new Dictionary<string, string>
    {
        {"instrumentType", Type.Electric.ToString()},
        {"builder", Builder.Martin.ToString()},
        {"model", "Stratocaster"},
        {"numStrings", "6"},
        {"topWood", Wood.Alder.ToString()},
        {"backWood", Wood.Alder.ToString()}
    }));

        inventory.addInstrument("V95122", 1299.99, new InstrumentSpec(new Dictionary<string, string>
    {
        {"instrumentType", Type.Acoustic.ToString()},
        {"builder", Builder.Fender.ToString()},
        {"model", "Classic"},
        {"numStrings", "6"},
        {"topWood", Wood.Mahogany.ToString()},
        {"backWood", Wood.Mahogany.ToString()}
    }));

        inventory.addInstrument("V95124", 1199.99, new InstrumentSpec(new Dictionary<string, string> { { "instrumentType", Type.Acoustic.ToString() }, { "builder", Builder.Fender.ToString() }, { "model", "Classic" }, { "numStrings", "6" }, { "topWood", Wood.Maple.ToString() }, { "backWood", Wood.Maple.ToString() } }));

        inventory.addInstrument("V95125", 899.99, new InstrumentSpec(new Dictionary<string, string>
    {
        {"instrumentType", Type.Electric.ToString()},
        {"builder", Builder.Gibson.ToString()},
        {"model", "Stratocaster"},
        {"numStrings", "4"},
        {"topWood", Wood.Alder.ToString()},
        {"backWood", Wood.Alder.ToString()}
    }));

        inventory.addInstrument("V95126", 1399.99, new InstrumentSpec(new Dictionary<string, string> { { "instrumentType", Type.Acoustic.ToString() }, { "builder", Builder.Gibson.ToString() }, { "model", "Classic" }, { "numStrings", "6" }, { "topWood", Wood.Cocobolo.ToString() }, { "backWood", Wood.Cocobolo.ToString() } }));

        // Add mandolins
        inventory.addInstrument("V95694", 1499.95, new InstrumentSpec(new Dictionary<string, string>
    {
        {"instrumentType", Type.Acoustic.ToString()},
        {"builder", Builder.Gibson.ToString()},
        {"model", "F5-G"},
        {"type", "Mandolin"},
        {"topWood", Wood.Maple.ToString()},
        {"backWood", Wood.Maple.ToString()},
        {"style", Style.A.ToString()}
    }));

        // Add banjos
        inventory.addInstrument("V95694", 2945.95, new InstrumentSpec(new Dictionary<string, string>
    {
        {"instrumentType", Type.Acoustic.ToString()},
        {"builder", Builder.Gibson.ToString()},
        {"model", "RB-3"},
        {"type", "Banjo"},
        {"topWood", Wood.Maple.ToString()},
        {"backWood", Wood.Maple.ToString()}
    }));
    }

}