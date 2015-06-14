using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TelerikHomework1
{
    public class GSM
    {
        private const double CALL_PRICE = 0.37;

        private Battery battery;
        private Display display;
        private decimal? price;
        private double totalDuration = 0;
        private decimal totalPrice = 0;

        private List<Call> numbersCalled = new List<Call>();


        public GSM(string gsmModel, string gsmManufacturer)
        {
            this.Model = gsmModel;
            this.Manufacturer = gsmManufacturer;
        }

        public GSM(string gsmModel, string gsmManufacturer, Display gsmDisplay, Battery gsmBattery)
            : this(gsmModel, gsmManufacturer)
        {
            this.Display = gsmDisplay;
            this.Battery = gsmBattery;
        }

        public GSM(string gsmModel, string gsmManufacturer, Display Display)
            : this(gsmModel, gsmManufacturer)
        {
            this.Display = Display;
        }

        public GSM(string gsmModel, string gsmManufacturer, Battery gsmBattery)
            : this(gsmModel, gsmManufacturer)
        {
            this.Battery = gsmBattery;
        }

        public GSM(string gsmModel, string gsmManufacturer, Display gsmDisplay, Battery gsmBattery, decimal Price, string Owner)
            : this(gsmModel, gsmManufacturer)
        {
            this.Display = gsmDisplay;
            this.Battery = gsmBattery;
            this.Price = Price;
            this.Owner = Owner;
        }

        public string Model { get; private set; }
        public string Manufacturer { get; private set; }

        public decimal? Price
        {
            get { return this.price; }

            set
            {
                if (value > 0) this.price = value;

                else throw new ArgumentException("Price must be positive");
            }
        }

        public string Owner { get; set; }

        public Battery Battery
        {
            get { return this.battery; }
            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get { return this.display; }
            private set
            {
                this.display = value;
            }
        }

        public void AddCall(Call Call)
        {
            numbersCalled.Add(Call);
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.numbersCalled);
            }
        }

        public void DeleteCall(int Call)
        {
            numbersCalled.RemoveAt(Call);
        }

        public void RemoveCallHistory()
        {
            numbersCalled.Clear();
        }

        public decimal CallsCost(List<Call> CalledNumbers)
        {

           foreach (Call calls in CalledNumbers)
           {
               totalDuration += calls.CallDuration;
           }
           totalDuration = totalDuration / 60;
           totalPrice = (decimal)(totalDuration * CALL_PRICE);
           return totalPrice;
        }

        public override string ToString()
        {
            return "\nModel: "+this.Model + " " +"\nManufacturer: "+ this.Manufacturer + " " + this.Battery + " " + this.Display+
                                              " "+"\nOwner: " +this.Owner+" "+"\nPrice: " +this.Price;
        }
    }
}
