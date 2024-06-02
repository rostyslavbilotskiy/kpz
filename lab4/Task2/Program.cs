using System;
using System.Collections.Generic;
using Task2;

class Program
{
    static void Main()
    {
        var runway1 = new Runway();
        var runway2 = new Runway();

        var commandCentre = new CommandCentre(
            new Runway[] { runway1, runway2 },
            new Aircraft[] { }
        );

        var aircraft1 = new Aircraft("Aircraft1", commandCentre);
        var aircraft2 = new Aircraft("Aircraft2", commandCentre);

        aircraft1.Land();
        aircraft2.Land();
        aircraft1.TakeOff();
        aircraft2.Land();
    }
}
