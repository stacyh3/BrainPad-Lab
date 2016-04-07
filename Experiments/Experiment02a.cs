using System;
using Microsoft.SPOT;

namespace HelloBrainPad
{
    public class Program
    {
        public static void Main()
        {
            // Now let's make the light blink.

            BrainPad.LightBulb.TurnOn();
            BrainPad.Wait.Seconds(4);
            BrainPad.LightBulb.TurnOff();
            BrainPad.Wait.Seconds(4);
        }
    }
}
