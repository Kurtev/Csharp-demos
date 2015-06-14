using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikHomework1
{
    class GSMCallHistoryTest
    {
        GSM MobilePhone = new GSM("Galaxy S4", "Samsung", new Display(10, 10, 16000000), new Battery("SE-BD", 240, 150, BatteryType.NiCd),1200,"Pesho");
        private int tempCallDuration = 0;
        private int tempCallPosition = 0;

        public void TestMethod()
        {
            

            MobilePhone.AddCall(new Call(new DateTime(2015, 01, 11), "+359884343436",241));
            MobilePhone.AddCall(new Call(new DateTime(2015, 01, 15), "+359857745245",124));
            MobilePhone.AddCall(new Call(new DateTime(2015, 02, 04), "+359886575546",352));
            MobilePhone.AddCall(new Call(new DateTime(2015, 02, 07),"+359882232322", 45));
            MobilePhone.AddCall(new Call(new DateTime(2015, 03, 24), "+359886575533", 122));
            MobilePhone.AddCall(new Call(new DateTime(2015, 03, 25), "+359882232311", 22));

            Console.WriteLine("\nCall History");
            foreach (Call calls in MobilePhone.CallHistory)
            {
                Console.WriteLine("Number called: "+ calls.DialedNumber + " "+"Date: " + calls.Date + " "+"Duration in sec:" + calls.CallDuration);
            }
          
            Console.WriteLine("\nTotal Call Price {0:C}", MobilePhone.CallsCost(MobilePhone.CallHistory));

            tempCallDuration = MobilePhone.CallHistory[0].CallDuration;

            for(int i=1;i<MobilePhone.CallHistory.Count;i++)
            {
               if(tempCallDuration < MobilePhone.CallHistory[i].CallDuration)
               {
                   tempCallPosition=i;
                   tempCallDuration = MobilePhone.CallHistory[i].CallDuration;
               }
            }

            MobilePhone.DeleteCall(tempCallPosition);

            Console.WriteLine("\nTotal Call Price after removing the longest call {0:C}",MobilePhone.CallsCost(MobilePhone.CallHistory));

            MobilePhone.RemoveCallHistory();

            foreach (Call calls in MobilePhone.CallHistory)
            {
                Console.WriteLine(calls.DialedNumber + " " + calls.Date + " " + calls.CallDuration);
            }

            Console.WriteLine(MobilePhone.ToString());

        }
    }
}
