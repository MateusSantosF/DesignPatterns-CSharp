namespace DesignPatterns.Structural.Bridge
{
    public interface Device
    {
        bool isEnable();

        void Enable();

        void Disable();

        int GetVolume();

        void SetVolume(int volume);

        int GetChannel();

        void SetChannel(int chanel);

    }
}
