using System;
using Microsoft.SPOT;

namespace HelloBrainPad
{
    public class Program
    {
        public static void Main()
        {
            // What was your soluiton to the red-yellow-green experiment?
            // Do you see a pattern below?
            // How can we turn this pattern into a recipe?

            while (BrainPad.Looping)
            {
                BlinkLightOnce(BrainPad.Color.Red, 4);
                BlinkLightOnce(BrainPad.Color.Yellow, 4);
                BlinkLightOnce(BrainPad.Color.Green, 4);        

            }

        }

        // The thing below if called a function or method. As we talked about, computer
        // languages follow a very specific way of stating things. That's why you see the private static void, etc.
        private static void BlinkLightOnce(BrainPad.Color color, int delay)
        {
            BrainPad.LightBulb.SetColor(color);
            BrainPad.LightBulb.TurnOn();
            BrainPad.Wait.Seconds(delay);
            BrainPad.LightBulb.TurnOff();
            BrainPad.Wait.Seconds(delay);
        }
    }
}
