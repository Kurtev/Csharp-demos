using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikHomework1
{
    public class Battery
    {
        private BatteryType batType;
        private double? lifeIdle;
        private double? lifeTalk;
        private const string BATERRY = null;


        public Battery()
        {

        }
        public Battery(string batModel, double batLifeIdle, double batLifeTalk, BatteryType type)
        {

            this.BatteryModel = batModel;
            this.BatteryLifeIdle = batLifeIdle;
            this.BatteryLifeTalk = batLifeTalk;
            this.batType = type;
        }
        public Battery(string batModel, BatteryType type)
        {

            this.BatteryModel = batModel;
            this.batType = type;
        }
        public Battery(double batLifeIdle, double batLifeTalk)
        {

            this.BatteryLifeIdle = batLifeIdle;
            this.BatteryLifeTalk = batLifeTalk;
        }

        public string BatteryModel { get; private set; }

        public double? BatteryLifeIdle
        {
            get { return this.lifeIdle; }

            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Battery life must be greater than 0");
                else this.lifeIdle = value;
            }

        }
        public double? BatteryLifeTalk
        {
            get { return this.lifeTalk; }

            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Battery life must be greater than 0");
                else this.lifeTalk = value;
            }
        }

        public override string ToString()
        {
            return "\nBattery Model: " + this.BatteryModel + " " +"\nLife Idle: "+ this.BatteryLifeIdle + " " +"\nLife Talk: "+ this.BatteryLifeTalk;
        }
    }
}
