using System;
using Microsoft.SPOT;

namespace HelloBrainPad
{
    public class Program
    {
        public static void Main()
        {
            // Let's try some colors.
            
            // We set the color like this
            BrainPad.LightBulb.SetColor(BrainPad.Color.Red);
            // Why did I do this outside of the loop?

            // What if we did put the "SetColor" inside the loop?
            // What if we want to change the color?
            // Try making the light blink red-yellow-green.

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
