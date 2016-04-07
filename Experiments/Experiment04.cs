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
                BrainPad.LightBulb.SetColor(BrainPad.Color.Red);
                BrainPad.LightBulb.TurnOn();
                BrainPad.Wait.Seconds(4);
                BrainPad.LightBulb.TurnOff();
                BrainPad.Wait.Seconds(4);

                BrainPad.LightBulb.SetColor(BrainPad.Color.Yellow);
                BrainPad.LightBulb.TurnOn();
                BrainPad.Wait.Seconds(4);
                BrainPad.LightBulb.TurnOff();
                BrainPad.Wait.Seconds(4);

                BrainPad.LightBulb.SetColor(BrainPad.Color.Green);
                BrainPad.LightBulb.TurnOn();
                BrainPad.Wait.Seconds(4);
                BrainPad.LightBulb.TurnOff();
                BrainPad.Wait.Seconds(4);

            }

        }
    }
}
