
namespace MusicPlayerTest
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.Btn_Close = new FontAwesome.Sharp.IconButton();
            this.Btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.Btn_Maximize = new FontAwesome.Sharp.IconButton();
            this.Pnl_Title = new System.Windows.Forms.Panel();
            this.Pnl_Botton = new System.Windows.Forms.Panel();
            this.Pnl_Center = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Lbl_AlbumName = new System.Windows.Forms.Label();
            this.Lbl_ArtistName = new System.Windows.Forms.Label();
            this.Lbl_SongName = new System.Windows.Forms.Label();
            this.Pic_CoverAlbum = new System.Windows.Forms.PictureBox();
            this.Pnl_Title.SuspendLayout();
            this.Pnl_Center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_CoverAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Btn_Close.IconColor = System.Drawing.Color.White;
            this.Btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Close.IconSize = 25;
            this.Btn_Close.Location = new System.Drawing.Point(771, 6);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(25, 25);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimize.FlatAppearance.BorderSize = 0;
            this.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Btn_Minimize.IconColor = System.Drawing.Color.White;
            this.Btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Minimize.IconSize = 25;
            this.Btn_Minimize.Location = new System.Drawing.Point(709, 6);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(25, 25);
            this.Btn_Minimize.TabIndex = 2;
            this.Btn_Minimize.UseVisualStyleBackColor = true;
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // Btn_Maximize
            // 
            this.Btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maximize.FlatAppearance.BorderSize = 0;
            this.Btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.Btn_Maximize.IconColor = System.Drawing.Color.White;
            this.Btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Maximize.IconSize = 25;
            this.Btn_Maximize.Location = new System.Drawing.Point(740, 6);
            this.Btn_Maximize.Name = "Btn_Maximize";
            this.Btn_Maximize.Size = new System.Drawing.Size(25, 25);
            this.Btn_Maximize.TabIndex = 1;
            this.Btn_Maximize.UseVisualStyleBackColor = true;
            this.Btn_Maximize.Click += new System.EventHandler(this.Btn_Maximize_Click);
            // 
            // Pnl_Title
            // 
            this.Pnl_Title.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Pnl_Title.Controls.Add(this.Btn_Maximize);
            this.Pnl_Title.Controls.Add(this.Btn_Minimize);
            this.Pnl_Title.Controls.Add(this.Btn_Close);
            this.Pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Title.Name = "Pnl_Title";
            this.Pnl_Title.Size = new System.Drawing.Size(800, 35);
            this.Pnl_Title.TabIndex = 1;
            this.Pnl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Title_MouseDown);
            // 
            // Pnl_Botton
            // 
            this.Pnl_Botton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Pnl_Botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Botton.Location = new System.Drawing.Point(0, 580);
            this.Pnl_Botton.Name = "Pnl_Botton";
            this.Pnl_Botton.Size = new System.Drawing.Size(800, 20);
            this.Pnl_Botton.TabIndex = 2;
            // 
            // Pnl_Center
            // 
            this.Pnl_Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.Pnl_Center.Controls.Add(this.Lbl_AlbumName);
            this.Pnl_Center.Controls.Add(this.Lbl_ArtistName);
            this.Pnl_Center.Controls.Add(this.Lbl_SongName);
            this.Pnl_Center.Controls.Add(this.Pic_CoverAlbum);
            this.Pnl_Center.Controls.Add(this.axWindowsMediaPlayer1);
            this.Pnl_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Center.Location = new System.Drawing.Point(0, 35);
            this.Pnl_Center.Name = "Pnl_Center";
            this.Pnl_Center.Size = new System.Drawing.Size(800, 545);
            this.Pnl_Center.TabIndex = 3;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(800, 545);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // Lbl_AlbumName
            // 
            this.Lbl_AlbumName.AutoSize = true;
            this.Lbl_AlbumName.BackColor = System.Drawing.Color.Black;
            this.Lbl_AlbumName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_AlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AlbumName.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_AlbumName.Location = new System.Drawing.Point(207, 107);
            this.Lbl_AlbumName.Name = "Lbl_AlbumName";
            this.Lbl_AlbumName.Size = new System.Drawing.Size(46, 18);
            this.Lbl_AlbumName.TabIndex = 3;
            this.Lbl_AlbumName.Text = "label1";
            // 
            // Lbl_ArtistName
            // 
            this.Lbl_ArtistName.AutoSize = true;
            this.Lbl_ArtistName.BackColor = System.Drawing.Color.Black;
            this.Lbl_ArtistName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_ArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ArtistName.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_ArtistName.Location = new System.Drawing.Point(207, 68);
            this.Lbl_ArtistName.Name = "Lbl_ArtistName";
            this.Lbl_ArtistName.Size = new System.Drawing.Size(46, 18);
            this.Lbl_ArtistName.TabIndex = 2;
            this.Lbl_ArtistName.Text = "label1";
            // 
            // Lbl_SongName
            // 
            this.Lbl_SongName.AutoSize = true;
            this.Lbl_SongName.BackColor = System.Drawing.Color.Black;
            this.Lbl_SongName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_SongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SongName.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_SongName.Location = new System.Drawing.Point(207, 28);
            this.Lbl_SongName.Name = "Lbl_SongName";
            this.Lbl_SongName.Size = new System.Drawing.Size(57, 20);
            this.Lbl_SongName.TabIndex = 1;
            this.Lbl_SongName.Text = "label1";
            // 
            // Pic_CoverAlbum
            // 
            this.Pic_CoverAlbum.Image = global::MusicPlayerTest.Properties.Resources.cover;
            this.Pic_CoverAlbum.Location = new System.Drawing.Point(21, 17);
            this.Pic_CoverAlbum.Name = "Pic_CoverAlbum";
            this.Pic_CoverAlbum.Size = new System.Drawing.Size(180, 180);
            this.Pic_CoverAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_CoverAlbum.TabIndex = 0;
            this.Pic_CoverAlbum.TabStop = false;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Pnl_Center);
            this.Controls.Add(this.Pnl_Botton);
            this.Controls.Add(this.Pnl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.Pnl_Title.ResumeLayout(false);
            this.Pnl_Center.ResumeLayout(false);
            this.Pnl_Center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_CoverAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton Btn_Close;
        private FontAwesome.Sharp.IconButton Btn_Minimize;
        private FontAwesome.Sharp.IconButton Btn_Maximize;
        private System.Windows.Forms.Panel Pnl_Title;
        private System.Windows.Forms.Panel Pnl_Botton;
        private System.Windows.Forms.Panel Pnl_Center;
        private System.Windows.Forms.Label Lbl_SongName;
        private System.Windows.Forms.PictureBox Pic_CoverAlbum;
        private System.Windows.Forms.Label Lbl_AlbumName;
        private System.Windows.Forms.Label Lbl_ArtistName;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

