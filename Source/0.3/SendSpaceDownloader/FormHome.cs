// SendSpace Downloader 0.3
// © Ismael Heredia , Argentina , 2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Media;

namespace SendSpaceDownloader
{
    public partial class FormHome : Form
    {
        WebClient downloader;
        Stopwatch chaunow = new Stopwatch();  

        public FormHome()
        {
            InitializeComponent();
        }

        private void ahivoy(object sender, DownloadProgressChangedEventArgs e)
        {
            string velocidad = string.Format("{0} kb/s", (e.BytesReceived / 1024d / chaunow.Elapsed.TotalSeconds).ToString("0.00"));
            string porcentaje = e.ProgressPercentage.ToString() + "%";
            string cantidad = string.Format("{0} MB's / {1} MB's", (e.BytesReceived / 1024d / 1024d).ToString("0.00"), (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));

            toolStripStatusLabel1.Text = " [+] Speed :  " + velocidad + "  [+] Percentage : " + porcentaje + "  [+] Size : " + cantidad;
            this.Refresh();

            pbProgress.Value = e.ProgressPercentage;

        }

        private void termine(object sender, AsyncCompletedEventArgs e)
        {
            chaunow.Reset();

            if (e.Cancelled == true)
            {
                MessageBox.Show("Canceled");
            }
            else
            {
                MessageBox.Show("Downloaded");
                SoundPlayer sound1 = new SoundPlayer(SendSpaceDownloader.Properties.Resources.scanfin);
                sound1.Play();
            }

            pbProgress.Value = 0;

            toolStripStatusLabel1.Text = "[+] Finished";
            this.Refresh();

            get_files();

        }

        public void get_files()
        {

            lvFilesDownloaded.Items.Clear();
            lbFilesDownloaded.Items.Clear();

            string[] archivos = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string archivo in archivos)
            {
                lbFilesDownloaded.Items.Add(archivo);
                FileInfo basename = new FileInfo(archivo);
                string nombre = basename.Name;

                ListViewItem agregar = new ListViewItem();
                agregar.Text = nombre;
                FileInfo info = new FileInfo(nombre);
                DateTime cuando = info.CreationTime;
                agregar.SubItems.Add(Convert.ToString(cuando));

                lvFilesDownloaded.Items.Add(agregar);
            }

            gbFilesDownloaded.Text = "Files Downloaded [" + lbFilesDownloaded.Items.Count + "]";

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(SendSpaceDownloader.Properties.Resources.click);
            sound1.Play();

            string codigofuente = "";

            txtFilename.Text = "";
            txtFileSize.Text = "";
            txtDirectLink.Text = "";

            WebClient web = new WebClient();
            web.Headers["User-Agent"] = "Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14";

            toolStripStatusLabel1.Text = "[+] Getting Information ...";
            this.Refresh();

            codigofuente = web.DownloadString(txtEnterLink.Text);

            Match search1 = Regex.Match(codigofuente, "<h2 class=\"bgray\"><b>(.*)</b></h2>", RegexOptions.IgnoreCase);
            if (search1.Success)
            {
                string name = search1.Groups[1].Value;
                txtFilename.Text = name;
            }

            Match search2 = Regex.Match(codigofuente, "<b>File Size:</b>(.*)</div>", RegexOptions.IgnoreCase);
            if (search2.Success)
            {
                string filesize = search2.Groups[1].Value;
                filesize = filesize.Replace(" ", "");
                txtFileSize.Text = filesize;
            }

            Match search3 = Regex.Match(codigofuente, "\"download_button\" href=\"(.*)\" onclick=\"runad", RegexOptions.IgnoreCase);
            if (search3.Success)
            {
                string link = search3.Groups[1].Value;
                txtDirectLink.Text = link;
            }

            SoundPlayer sound2 = new SoundPlayer(SendSpaceDownloader.Properties.Resources.scanfin);
            sound2.Play();

            toolStripStatusLabel1.Text = "[+] Finished";
            this.Refresh();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sound1 = new SoundPlayer(SendSpaceDownloader.Properties.Resources.click);
                sound1.Play();
                Clipboard.Clear();
                Clipboard.SetText(txtDirectLink.Text);
            }
            catch
            {
                //
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(SendSpaceDownloader.Properties.Resources.click);
            sound1.Play();

            if (txtDirectLink.Text == "")
            {
                MessageBox.Show("Error");
            }
            else
            {
                string bajar = txtDirectLink.Text;

                var url = new Uri(bajar);
                downloader = new WebClient();
                downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(termine);
                downloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ahivoy);
                chaunow.Start();
                Uri urisplit = new Uri(bajar);
                string archivo = urisplit.AbsolutePath;
                FileInfo parte = new FileInfo(archivo);
                archivo = parte.Name;

                try
                {
                    downloader.DownloadFileAsync(url, archivo);
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void lblCopyRight_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ismaelheredia123.wordpress.com");
        }

        private void LoadFileDownloaded_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(SendSpaceDownloader.Properties.Resources.click);
            sound1.Play();

            if (lbFilesDownloaded.Items.Count == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {

                string ponecarajo = lbFilesDownloaded.Items[lvFilesDownloaded.FocusedItem.Index].ToString();
                System.Diagnostics.Process.Start(ponecarajo);
            }
        }

        private void RefreshDownloads_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(SendSpaceDownloader.Properties.Resources.click);
            sound1.Play();
            get_files();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(SendSpaceDownloader.Properties.Resources.formcreate);
            sound1.Play();

            if (!Directory.Exists("downloads"))
            {
                System.IO.Directory.CreateDirectory("downloads");
                Directory.SetCurrentDirectory("downloads");
            }
            else
            {
                Directory.SetCurrentDirectory("downloads");
            }

            get_files();
        }

    }
}
