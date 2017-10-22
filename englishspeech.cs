using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
namespace WindowsFormsApp1
{
    class englishspeech
    {
        SpeechSynthesizer howtoname = new SpeechSynthesizer();
        public void speak()
        {
            howtoname.SpeakAsync(Form1.finals);
        }
    }
}
