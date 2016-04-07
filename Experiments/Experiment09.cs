using System;


namespace HelloBrainPad
{
    public class Program
    {
        public static void Main()
        {
            while (BrainPad.Looping)
            {
                // Now let's learn to read from the BrainPad sensors and use a different output.

                var celcius = BrainPad.TemperatureSensor.ReadTemperature();

                BrainPad.Display.DrawText(0, 0, "Temperature = " + celcius.ToString("F2"), BrainPad.Color.White);

                BrainPad.TrafficLight.TurnOffAllLights();

                if (celcius > 22)
                {
                    BrainPad.TrafficLight.TurnRedLightOn();
                }
                else if(celcius > 21)
                {
                    BrainPad.TrafficLight.TurnYellowLightOn();
                }
                else
                {
                    BrainPad.TrafficLight.TurnGreenLightOn();
                }

            }
        }

    }
}
