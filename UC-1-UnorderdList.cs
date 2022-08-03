using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresAndAlgorithms
{
    internal class UC_1_UnorderdList
    {
        List<string> dinosaurs = new List<string>();

        Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

        dinosaurs.Add("Tyrannosaurus");
        dinosaurs.Add("Amargasaurus");
        dinosaurs.Add("Mamenchisaurus");
        dinosaurs.Add("Deinonychus");
        dinosaurs.Add("Compsognathus");
        Console.WriteLine();
        foreach(string dinosaur in dinosaurs)
        {
             Console.WriteLine(dinosaur);
        }
        Shows accessing the list using the Item property.
        Console.WriteLine("\ndinosaurs[3]: {0}", dinosaurs[3]);

        Console.WriteLine("\nRemove(\"Compsognathus\")");
          dinosaurs.Remove("Compsognathus");
          Console.WriteLine();
    }
}
