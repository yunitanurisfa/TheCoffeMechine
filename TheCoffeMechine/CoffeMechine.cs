using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private Milk milk;

        public CoffeMechine(CoffePowder powder, WaterGalon galon, Milk milk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.milk = milk;
        }

        public String makeCappucino()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if (!this.milk.isAvailable())
            {
                return "Sorry, the milk is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            this.milk.makeOneCup();
            return "Yey! your Cappucino is ready";
        }

        public String checkAvailability()
        {
            return $"the water : {this.waterGalon.getVolume()}, the milk : {this.milk.getVolume()} and the coffe powder : {this.coffePowder.getNetto()}";
        }
    }
}
