using System;
using System.Device.Gpio;
using System.Diagnostics;
using System.Threading;

namespace ChickenDoor
{
    public class Program
    {
        #region Hardware
        private static GpioPin _endStopOpen;
        private static GpioPin _endStopClosed;

        #endregion

        public static void Main()
        {
            var gpioController = new GpioController();

            #region Map Pins
            _endStopClosed = gpioController.OpenPin(13, PinMode.Input);
            _endStopOpen = gpioController.OpenPin(12, PinMode.Input);
            #endregion

            #region Map Events
            _endStopOpen.ValueChanged += _endStopOpen_ValueChanged;
            _endStopClosed.ValueChanged += _endStopClosed_ValueChanged;
            #endregion


            Debug.WriteLine("Chicken Door is active!");

            Thread.Sleep(Timeout.Infinite);

            // Browse our samples repository: https://github.com/nanoframework/samples
            // Check our documentation online: https://docs.nanoframework.net/
            // Join our lively Discord community: https://discord.gg/gCyBu8T
        }

        #region Methods
        private static void Open()
        {

        }

        private static void Close()
        {

        }

        private static void GetTime()
        {
            //TODO: Get the date/time from the internet
        }

        private static void GetSunriseSunset(DateTime dateTime)
        {
            //TODO: Get the sunrise and sunset for this date from internet
        }
        #endregion

        #region Event Methods
        private static void _endStopClosed_ValueChanged(object sender, PinValueChangedEventArgs e)
        {
            Debug.WriteLine("Chicken Door Status: CLOSED!");
        }

        private static void _endStopOpen_ValueChanged(object sender, PinValueChangedEventArgs e)
        {
            Debug.WriteLine("Chicken Door Status: WIDE OPEN!");
        }
        #endregion
    }
}
