using System.Threading;
using ArduinoDriver.SerialProtocol;
using ArduinoUploader.Hardware;

namespace ArduinoDriver
{
    class ChipTuneLoader
    {
        private const ArduinoModel AttachedArduino = ArduinoModel.UnoR3;

        private const int DigitalPinBuzzer = 8;

        private const int C4 = 262;
        private const int C5 = 523;
        private const int D4 = 294;
        private const int E4 = 330;
        private const int F4 = 349;
        private const int G4 = 392;

        private static readonly int[] melody =
        {
            D4, E4, F4, F4, G4, E4, D4, C4, 0, 0, D4, D4, E4, F4, D4, C4, C5, 0, C5, G4
        };

        private const int slider = 0;

        private const int quarter = 250 + slider;
        private const int eighth = 125 + slider;
        private const int sixteenth = 63 + slider;
        private const int dottedEighth = 188 + slider;

        private static readonly int[] tempo =
        {
            eighth, eighth, eighth, eighth, eighth, dottedEighth, sixteenth, quarter * 3,
            quarter, eighth, eighth, eighth, eighth, eighth, quarter,
            eighth, eighth, eighth, eighth, quarter * 2  
        };

        public static void Sing()
        {
            using (var driver = new ArduinoDriver(AttachedArduino, "COM5", true))
            {
                for (var i = 0; i < melody.Length; i++)
                {
                    var noteDuration = tempo[i];
                    driver.Send(new ToneRequest(DigitalPinBuzzer, (ushort)melody[i], (uint)noteDuration));
                    Thread.Sleep((int)(noteDuration * 1.40));
                    driver.Send(new NoToneRequest(DigitalPinBuzzer));
                }
            }
        }
    }
}

