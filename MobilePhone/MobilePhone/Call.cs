using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TelerikHomework1
{
    public class Call
    {
        private DateTime Time;
        private string  numberDialed;
        private int callDuration;

        public Call(DateTime dateTime, string dialedNumber , int durationCall)
            : base()
        {
            this.Date = dateTime;
            this.DialedNumber = dialedNumber;
            this.CallDuration = durationCall;
        }

        public DateTime Date
        {
            get
            {
                if (this.Time.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.Time;
            }
            private set
            {
                this.Time = value;
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.numberDialed;
            }
            private set
            {
                string pattern = @"(^[\d+]{13}$)|(^[0-9]{10}$)";
                if (Regex.IsMatch(value, pattern))
                {
                this.numberDialed = value;
                }
                else
                    throw new ArgumentException("Invalid number");
            }
        }

        public int CallDuration
        {
            get
            {
                return this.callDuration;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Duration can`t be less than zero");
                else 
                this.callDuration = value;
            }
        }

     
    }
}


