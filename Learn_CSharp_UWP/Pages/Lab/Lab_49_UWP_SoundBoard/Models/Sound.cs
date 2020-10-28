using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_UWP.Pages.Lab.Lab_49_UWP_SoundBoard.Models
{
    public class Sound
    {
        public String Name { get; set; }
        public SoundCategory Category { get; set; }
        public String AudioFile { get; set; }
        public String ImageFile { get; set; }

        public Sound(string name, SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = String.Format("/Assets/SoundBoard/Audio/{0}/{1}.wav", category, name);
            ImageFile = String.Format("/Assets/SoundBoard/Images/{0}/{1}.png", category, name);
        }
    }

    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
}
