using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }

        public void RequestToLand(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == null)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                    runway.IsBusyWithAircraft = aircraft;
                    runway.HighLightRed();
                    return;
                }
            }
            Console.WriteLine($"Could not land, all runways are busy.");
        }

        public void RequestToTakeOff(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == aircraft)
                {
                    runway.IsBusyWithAircraft = null;
                    runway.HighLightGreen();
                    Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
                    return;
                }
            }
            Console.WriteLine($"Could not take off, no runway found for Aircraft {aircraft.Name}.");
        }
    }
}
