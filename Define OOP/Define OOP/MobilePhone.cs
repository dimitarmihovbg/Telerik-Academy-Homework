using System;

namespace DefineOOP
{
    public class MobilePhone
    {
        private string model;
        private string manufucturer;
        private int price;
        private string owner;
        private BatteryCharacteristics battery;
        private DisplayCharacteristics display;

        public MobilePhone(string model, string manufucturer, int price,
            string owner, string batteryModel, int batteryHoursIdle, int batteryHoursTalk,
            int displaySize, int displayNumColors)
        {
            this.model = model;
            this.manufucturer = manufucturer;
            this.price = price;
            this.owner = owner;
            this.battery = new BatteryCharacteristics(batteryModel, batteryHoursIdle, batteryHoursTalk);
            this.display = new DisplayCharacteristics(displaySize, displayNumColors);

        }
        public void PrintMobilePhone()
        {
            Console.WriteLine("The Model is: " + model);
            Console.WriteLine("The Manufucturer is: " + manufucturer);
            Console.WriteLine("The Price is: " + price);
            Console.WriteLine(owner + "Owns this");
            Console.WriteLine("Battery Model is: " + this.battery.Model);
            Console.WriteLine("HoursIDLE of Battey are: " + this.battery.HoursIdle);
            Console.WriteLine("Hours talk of Battery are: " + this.battery.HoursTalk);
            Console.WriteLine("Display's size is" + display.Size);
            Console.WriteLine("Number of Colors on Display are: " + display.NumColors);
        }
    }
}
