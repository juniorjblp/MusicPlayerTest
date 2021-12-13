using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerTest.Uteis
{
    class Streaming
    {
        public class Source
        {
            public string audio_info { get; set; }
            public int bitrate { get; set; }
            public string genre { get; set; }

            [JsonProperty("ice-bitrate")]
            public int IceBitrate { get; set; }

            [JsonProperty("ice-channels")]
            public int IceChannels { get; set; }

            [JsonProperty("ice-samplerate")]
            public int IceSamplerate { get; set; }
            public int listener_peak { get; set; }
            public int listeners { get; set; }
            public string listenurl { get; set; }
            public string server_description { get; set; }
            public string server_name { get; set; }
            public string server_type { get; set; }
            public string server_url { get; set; }
            public string stream_start { get; set; }
            public DateTime stream_start_iso8601 { get; set; }
            public string title { get; set; }
            public object dummy { get; set; }
        }

        public class Icestats
        {
            public string admin { get; set; }
            public string host { get; set; }
            public string location { get; set; }
            public string server_id { get; set; }
            public string server_start { get; set; }
            public DateTime server_start_iso8601 { get; set; }
            public List<Source> source { get; set; }
        }

        public class Root
        {
            public Icestats icestats { get; set; }
        }
    }
}
