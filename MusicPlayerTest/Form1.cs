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

namespace MusicPlayerTest
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();

            Lbl_SongName.Text = "...";
            Lbl_ArtistName.Text = "...";
            Lbl_AlbumName.Text = "...";

            Txt_AtistName.Text = "Artist Name";
            Txt_SongName.Text = "Song Name";
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

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
            var ArtistName = iTunesResult.iTunesReturn(Txt_AtistName.Text);
            //var SongName = Txt_SongName.Text;

            Music.Root myDeserializedClass = JsonConvert.DeserializeObject<Music.Root>(ArtistName);


            //Music.DesSerializedUnit(JsonResponse);

            //var response = from musicList in myDeserializedClass.results select new { ArtistName = myDeserializedClass.results, SongName =  trackName, AlbumName = collectionName};
            if (myDeserializedClass.results.Count == 0)
            {
                MessageBox.Show("Nenhum item encontrado");
                Txt_AtistName.Clear();
                Txt_AtistName.Focus();
                Lbl_AlbumName.Text = "...";
                Lbl_SongName.Text = "...";
                Lbl_ArtistName.Text = "...";
                Pic_CoverAlbum.Image = Image.FromFile("C:\\Users\\JoãoBatistadeSousaCa\\source\\repos\\MusicPlayerTest\\MusicPlayerTest\\Images\\cover.jpg");
            }
            else
            {
                foreach (var item in myDeserializedClass.results)
                {
                    var request = WebRequest.Create(item.artworkUrl100);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        Pic_CoverAlbum.Image = Image.FromStream(stream);
                    }

                    Lbl_SongName.Text = item.trackName;
                    Lbl_ArtistName.Text = item.artistName;
                    Lbl_AlbumName.Text = item.collectionName;
                }
            }
            
                //Lbl_Result.Text = myDeserializedClass.results.ToString();
        }

        private void Txt_AtistName_Enter(object sender, EventArgs e)
        {
            if (Txt_AtistName.Text == "Artist Name")
            {
                Txt_AtistName.Text = "";
            }
        }

        private void Txt_SongName_Enter(object sender, EventArgs e)
        {
            if (Txt_SongName.Text == "Song Name")
            {
                Txt_SongName.Text = "";
            }
        }
    }
}
