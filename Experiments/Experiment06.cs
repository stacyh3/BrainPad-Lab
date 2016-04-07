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

                var x = BrainPad.Accelerometer.ReadX();
                var y = BrainPad.Accelerometer.ReadY();
                var z = BrainPad.Accelerometer.ReadZ();


                BrainPad.Display.DrawText(0, 0, "x = " + x.ToString("F2"), BrainPad.Color.White);
                BrainPad.Display.DrawText(0, 16, "y = " + y.ToString("F2"), BrainPad.Color.White);
                BrainPad.Display.DrawText(0, 32, "z = " + z.ToString("F2"), BrainPad.Color.White);

                BrainPad.Buzzer.PlayFrequency((int)(Math.Abs(y) * 1000));
                BrainPad.Wait.Milliseconds(Math.Abs(x) * 50 + 150);
            }
        }

    }
}
