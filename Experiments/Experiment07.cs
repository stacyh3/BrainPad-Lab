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

				

            }
        }

    }
}
