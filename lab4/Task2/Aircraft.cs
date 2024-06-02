using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }
        private CommandCentre _commandCentre;

        public Aircraft(string name, CommandCentre commandCentre)
        {
            this.Name = name;
            this._commandCentre = commandCentre;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is landing.");
            _commandCentre.RequestToLand(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is taking off.");
            _commandCentre.RequestToTakeOff(this);
        }
    }
}
