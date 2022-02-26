using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liscuter
{
    internal class Transcoding
    {
        public static string ToMP3(string file)
        {
            string tomp3code = $"ffmpeg -i {file} temp.mp3";
            return tomp3code;
        }
    }
}
