using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CognitiveServices.Models.Image;

namespace ExplorerVision
{
    public interface ITextToSpeech
    {
        void Speak(string text);
       
    }
}
