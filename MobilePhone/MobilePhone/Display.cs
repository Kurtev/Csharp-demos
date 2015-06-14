using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikHomework1
{
    public class Display
    {
        private double? displayHeight;
        private double? displayWidth;
        private long? displayColors;

        public Display()
        {

        }

        public Display(double height, double width, long numberOfColors)
        {
            this.Height = height;
            this.Width = width;
            this.NumberOfColors = numberOfColors;
        }

        public double? Height
        {
            get { return this.displayHeight; }
            private set
            {
                if (displayHeight  < 2)
                {
                    throw new ArgumentException("Display height must greater than 2.");
                }

                this.displayHeight= value;
            }
        }

        public double? Width
        {
            get { return this.displayWidth; }
            private set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Display width mmust greater than 2.");
                }

                this.displayWidth = value;
            }
        }

        public long? NumberOfColors
        {
            get { return displayColors; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Display colors must be at least zero.");
                }

                this.displayColors = value;
            }
        }
        public override string ToString()
        {
            return "\nDisplay Width: " + this.Width + " " + "\nDisplay Heigh :" + this.Height + " " + "\nDisplay Colors: " + this.NumberOfColors;
        }
    }
}
