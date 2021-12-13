using MusicPlayerTest.Uteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Windows.Media;
using System.Media;
using System.Timers;

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

            Txt_AtistName.Text = "Artist Name";
            Txt_SongName.Text = "Song Name";

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

        private void Txt_ArtistName_Leave(object sender, EventArgs e)
        {

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            //var ArtistName = Txt_AtistName.Text;
            //var SongName = Txt_SongName.Text;

            //var jsonResponse = iTunesResult.iTunesReturn(ArtistName, SongName);

            //Music.Root myDeserializedClass = JsonConvert.DeserializeObject<Music.Root>(jsonResponse);

            //if (myDeserializedClass.results.Count == 0)
            //{
            //    MessageBox.Show("Nenhum item encontrado");
            //    Txt_AtistName.Clear();
            //    Txt_AtistName.Focus();
            //    Lbl_AlbumName.Text = "...";
            //    Lbl_SongName.Text = "...";
            //    Lbl_ArtistName.Text = "...";
            //    Pic_CoverAlbum.Image = Properties.Resources.cover;
            //}
            //else
            //{
            //    foreach (var item in myDeserializedClass.results)
            //    {
            //        var request = WebRequest.Create(item.artworkUrl100.Replace("100x100", "350x350"));
            //        using (var response = request.GetResponse())
            //        using (var stream = response.GetResponseStream())
            //        {
            //            Pic_CoverAlbum.Image = Image.FromStream(stream);

            //        }

            //        var requestBack = WebRequest.Create(item.artworkUrl100.Replace("100x100", "1500x1500"));
            //        using (var response = requestBack.GetResponse())
            //        using (var stream = response.GetResponseStream())
            //        {
            //            Pic_BackGround.Image = Image.FromStream(stream);
            //            Pic_BackGround.SizeMode = PictureBoxSizeMode.StretchImage;
            //        }

            //            Lbl_SongName.Text = item.trackName;
            //        Lbl_ArtistName.Text = item.artistName;
            //        Lbl_AlbumName.Text = item.collectionName;
            //    }
            //}



            //var StreamUrl = "brasilhits.com";

            //var jsonResponse = StreamingReturn.iTunesReturn(StreamUrl);

            //Streaming.Root myStreamReturn = JsonConvert.DeserializeObject<Streaming.Root>(jsonResponse);

            //foreach (var item in myStreamReturn.icestats.source)
            //{
            //    var musicReturn = iTunesResult.iTunesReturn(item.title, "");

            //    Music.Root myDeserializedClass = JsonConvert.DeserializeObject<Music.Root>(musicReturn);

            //    foreach (var music in myDeserializedClass.results)
            //    {
            //        Lbl_SongName.Text = music.trackName;
            //        Lbl_ArtistName.Text = music.artistName;
            //        Lbl_AlbumName.Text = music.collectionName;
            //        var request = WebRequest.Create(music.artworkUrl100.Replace("100x100", "350x350"));
            //        using (var response = request.GetResponse())
            //        using (var stream = response.GetResponseStream())
            //        {
            //            Pic_CoverAlbum.Image = Image.FromStream(stream);

            //        }

            //    }
            //}
        }


        private void Txt_SongName_Enter(object sender, EventArgs e)
        {
            if (Txt_SongName.Text == "Song Name")
            {
                Txt_SongName.Text = "";
            }
        }

        private void Txt_AtistName_Enter(object sender, EventArgs e)
        {
            if (Txt_AtistName.Text == "Artist Name")
            {
                Txt_AtistName.Text = "";
            }
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
