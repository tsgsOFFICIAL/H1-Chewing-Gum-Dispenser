using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Chewing_Gum_Dispenser
{
    public class Dispenser
    {
        #region Fields
        private bool full;
        private byte fillAmount;
        private byte amount;
        private byte blueberryGums;
        private byte blackberryGums;
        private byte tuttifruttiGums;
        private byte orangeGums;
        private byte strawberryGums;
        private byte appleGums;
        private byte blueberryPercent;
        private byte blackberryPercent;
        private byte tuttiFruttiPercent;
        private byte orangePercent;
        private byte strawberryPercent;
        private byte applePercent;
        private string flavor;
        #endregion

        #region Properties
        /// <summary>
        /// The amount of chewing gum balls left in the machine
        /// </summary>
        public byte Amount
        {
            get
            {
                return amount;
            }
        }
        /// <summary>
        /// Return false if the machine is empty
        /// </summary>
        public bool Full
        {
            get
            {
                return full;
            }
        }
        #endregion

        #region Constructors
        public Dispenser(byte amount, byte blueberryPercent, byte blackberryPercent, byte tuttiFruttiPercent, byte orangePercent, byte strawberryPercent, byte applePercent)
        {
            full = true;
            this.fillAmount = amount;
            this.amount = amount;
            this.blueberryPercent = blueberryPercent;
            this.blackberryPercent = blackberryPercent;
            this.tuttiFruttiPercent = tuttiFruttiPercent;
            this.orangePercent = orangePercent;
            this.strawberryPercent = strawberryPercent;
            this.applePercent = applePercent;

            Refill();
        }
        #endregion

        #region Methods
        public string Draw()
        {
            Random random = new Random();
            flavor = "";
            while (flavor.Equals("") && amount > 0)
            {
                int temp = random.Next(0, 6 + 1);
                switch (temp)
                {
                    case 0:
                        if (blueberryGums > 0)
                        {
                            flavor = "blueberry";
                            blueberryGums--;
                        }
                        break;
                    case 1:
                        if (blackberryGums > 0)
                        {
                            flavor = "blackberry";
                            blackberryGums--;
                        }
                        break;
                    case 2:
                        if (tuttifruttiGums > 0)
                        {
                            flavor = "tutti frutti";
                            tuttifruttiGums--;
                        }
                        break;
                    case 3:
                        if (orangeGums > 0)
                        {
                            flavor = "orange";
                            orangeGums--;
                        }
                        break;
                    case 4:
                        if (strawberryGums > 0)
                        {
                            flavor = "strawberry";
                            strawberryGums--;
                        }
                        break;
                    case 5:
                        if (appleGums > 0)
                        {
                            flavor = "apple";
                            appleGums--;
                        }
                        break;
                }
            }

            if (amount > 0)
            {
                amount--;
                return $"Here ya go, ma boi, you got a chewing gum with {flavor} flavor!";
            }
            else
            {
                full = false;
                return "You've emptied the machine, you little bastard!";
            }
        }

        public void Refill()
        {
            full = true;
            amount = fillAmount;
            blueberryGums = (byte)((double)amount / 100 * (double)blueberryPercent);
            blackberryGums = (byte)((double)amount / 100 * (double)blackberryPercent);
            tuttifruttiGums = (byte)((double)amount / 100 * (double)tuttiFruttiPercent);
            orangeGums = (byte)((double)amount / 100 * (double)orangePercent);
            strawberryGums = (byte)((double)amount / 100 * (double)strawberryPercent);
            appleGums = (byte)((double)amount / 100 * (double)applePercent);

            int counter = 0;
            while (blueberryGums + blackberryGums + tuttifruttiGums + orangeGums + strawberryGums + appleGums < amount)
            {
                switch (counter)
                {
                    case 0:
                        blueberryGums++;
                        break;
                    case 1:
                        blackberryGums++;
                        break;
                    case 2:
                        tuttifruttiGums++;
                        break;
                    case 3:
                        orangeGums++;
                        break;
                    case 4:
                        strawberryGums++;
                        break;
                    case 5:
                        appleGums++;
                        break;
                }
            }
        }
        #endregion
    }
}
