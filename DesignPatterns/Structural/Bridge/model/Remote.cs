namespace DesignPatterns.Structural.Bridge.model
{
    public class Remote
    {
        private Device _Device;

        public Remote(Device device)
        {
            _Device = device;
        }

        public void TogglePower()
        {
            if (_Device.isEnable() )
            {
                _Device.Disable();
            }
            else
            {
                _Device.Enable();
            }
            
        }

        public void VolumeDown()
        {
            _Device.SetVolume(_Device.GetVolume() - 1);
        }

        public void VolumeUp()
        {
            _Device.SetVolume(_Device.GetVolume() + 1);
        }

        public void ChannelDown()
        {
            _Device.SetChannel(_Device.GetChannel() - 1);
        }

        public void ChannelUp()
        {
            _Device.SetChannel(_Device.GetChannel() + 1);
        }

        public override string ToString()
        {
            return $"Volume: {_Device.GetVolume()}\n" +
                   $"Channel: {_Device.GetChannel()}\n" +
                   $"Enable: {_Device.isEnable()}\n";
        }

    }
}
