using MusicPlayerTest.Uteis;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;


namespace MusicPlayerTest
{

    public partial class Form_Principal : Form
    {
        private System.Timers.Timer aTimer;
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form_Principal()
        {
            InitializeComponent();

            Lbl_SongName.Text = "...";
            Lbl_ArtistName.Text = "...";
            Lbl_AlbumName.Text = "...";
        }
        private void Form_Principal_Load(object sender, EventArgs e)
        {
            SongInfoLoad();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Pnl_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
                private void SongInfoLoad()
        {
            var StreamUrl = "brasilhits.com";

            var jsonResponse = StreamingReturn.iTunesReturn(StreamUrl);

            Streaming.Root myStreamReturn = JsonConvert.DeserializeObject<Streaming.Root>(jsonResponse);

            foreach (var item in myStreamReturn.icestats.source)
            {
                var musicReturn = iTunesResult.iTunesReturn(item.title, "");

                Music.Root myDeserializedClass = JsonConvert.DeserializeObject<Music.Root>(musicReturn);

                foreach (var music in myDeserializedClass.results)
                {
                    Lbl_SongName.Text = music.trackName;
                    Lbl_ArtistName.Text = music.artistName;
                    Lbl_AlbumName.Text = music.collectionName;
                    var request = WebRequest.Create(music.artworkUrl100.Replace("100x100", "350x350"));
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        Pic_CoverAlbum.Image = Image.FromStream(stream);

                    }

                }
            }
        }
    }
}
