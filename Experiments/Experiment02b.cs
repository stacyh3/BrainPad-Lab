using System;
using Microsoft.SPOT;

namespace HelloBrainPad
{
    public class Program
    {
        public static void Main()
        {
            // Did you figure out how to fix the last experiment?

            // Let's try a loop!
            while (BrainPad.Looping)
            {
                BrainPad.LightBulb.TurnOn();
                BrainPad.Wait.Seconds(4);
                BrainPad.LightBulb.TurnOff();
                BrainPad.Wait.Seconds(4);
            }
						

        }
    }
}
