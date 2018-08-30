using System;

namespace DefineOOP
{
    class Program
    {
        static void Main()
        {
            string inputModel = Console.ReadLine();
            string inputManufucturer = Console.ReadLine();
            int inputPrice = int.Parse(Console.ReadLine());
            string inputOwner = Console.ReadLine();
            string inputBatteryModel = Console.ReadLine();
            int inputBatteryHoursIdle = int.Parse(Console.ReadLine());
            int inputBatteryHoursTalk = int.Parse(Console.ReadLine());
            int inputDisplaySize = int.Parse(Console.ReadLine());
            int inputDisplayNumColors = int.Parse(Console.ReadLine());

            MobilePhone gsmOne = new MobilePhone(inputModel, inputManufucturer, inputPrice,
                inputOwner, inputBatteryModel,
                inputBatteryHoursIdle, inputBatteryHoursTalk, inputDisplaySize,
                inputDisplayNumColors);

            BatteryCharacteristics.BatteryType one = BatteryCharacteristics.BatteryType.Li_ION;

            IPhone4S IphoneOne = new IPhone4S("Mitizaro");
            IphoneOne.PrintIphone4S();            
            gsmOne.PrintMobilePhone();

            GSMtest gsms = new GSMtest();
            GSMtest.PrintGSMtest();
        }
    }
}
