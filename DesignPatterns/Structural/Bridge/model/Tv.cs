namespace DesignPatterns.Structural.Bridge.model
{
    public class Tv:Device
    {
        public int Volume { get; set; }

        public int Channel { get; set; }

        public bool HasEnable { get; set; }

        public Tv() { }

        public Tv(int volume, int chanel, bool hasEnable)
        {
            Volume = volume;
            Channel = chanel;
            HasEnable = hasEnable;
        }

        public void Disable()
        {
            HasEnable = false;
        }

        public void Enable()
        {
            HasEnable |= true;
        }

        public int GetChannel()
        {
            return Channel;
        }

        public int GetVolume()
        {
            return Volume;
        }

        public bool isEnable()
        {
            return HasEnable;
        }

        public void SetChannel(int channel)
        {
            Channel = channel;
        }

        public void SetVolume(int volume)
        {
            Volume = volume;
        }
    }
}
