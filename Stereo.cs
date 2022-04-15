namespace HeadFirstCommandPatternSample
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("The stereo is on");
        }

        public void Off()
        {
            Console.WriteLine("The stereo is off");
        }

        public void SetCD()
        {
            Console.WriteLine("A cd putted inside the stereo");
        }

        public void SetVolume(ushort volume)
        {
            Console.WriteLine($"The stereo's volume is {volume}");
        }
    }
}
