namespace SendSpaceDownloader
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.gbEnterLink = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtEnterLink = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbDownload = new System.Windows.Forms.GroupBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtDirectLink = new System.Windows.Forms.TextBox();
            this.lblDirectLink = new System.Windows.Forms.Label();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbDownloader = new System.Windows.Forms.GroupBox();
            this.gbProgress = new System.Windows.Forms.GroupBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbFilesDownloaded = new System.Windows.Forms.GroupBox();
            this.lbFilesDownloaded = new System.Windows.Forms.ListBox();
            this.lvFilesDownloaded = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoadFileDownloaded = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshDownloads = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pbAbout = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbEnterLink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbDownload.SuspendLayout();
            this.gbInformation.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbDownloader.SuspendLayout();
            this.gbProgress.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbFilesDownloaded.SuspendLayout();
            this.cmsOpciones.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tabPage1);
            this.tcPrincipal.Controls.Add(this.tabPage2);
            this.tcPrincipal.Controls.Add(this.tabPage3);
            this.tcPrincipal.Controls.Add(this.tabPage4);
            this.tcPrincipal.Controls.Add(this.tabPage5);
            this.tcPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(451, 266);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCopyRight);
            this.tabPage1.Controls.Add(this.gbEnterLink);
            this.tabPage1.Controls.Add(this.pbLogo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(443, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Index";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.Location = new System.Drawing.Point(64, 195);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(295, 20);
            this.lblCopyRight.TabIndex = 2;
            this.lblCopyRight.Text = "© Ismael Heredia , Argentina , 2014";
            this.lblCopyRight.Click += new System.EventHandler(this.lblCopyRight_Click);
            // 
            // gbEnterLink
            // 
            this.gbEnterLink.Controls.Add(this.btnCheck);
            this.gbEnterLink.Controls.Add(this.txtEnterLink);
            this.gbEnterLink.Location = new System.Drawing.Point(19, 114);
            this.gbEnterLink.Name = "gbEnterLink";
            this.gbEnterLink.Size = new System.Drawing.Size(406, 57);
            this.gbEnterLink.TabIndex = 1;
            this.gbEnterLink.TabStop = false;
            this.gbEnterLink.Text = "Enter Link";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(315, 20);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtEnterLink
            // 
            this.txtEnterLink.Location = new System.Drawing.Point(22, 20);
            this.txtEnterLink.Name = "txtEnterLink";
            this.txtEnterLink.Size = new System.Drawing.Size(287, 20);
            this.txtEnterLink.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(19, 18);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(406, 75);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbDownload);
            this.tabPage2.Controls.Add(this.gbInformation);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(443, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbDownload
            // 
            this.gbDownload.Controls.Add(this.btnDownload);
            this.gbDownload.Location = new System.Drawing.Point(117, 168);
            this.gbDownload.Name = "gbDownload";
            this.gbDownload.Size = new System.Drawing.Size(200, 51);
            this.gbDownload.TabIndex = 1;
            this.gbDownload.TabStop = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(17, 15);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(167, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.btnCopy);
            this.gbInformation.Controls.Add(this.txtDirectLink);
            this.gbInformation.Controls.Add(this.lblDirectLink);
            this.gbInformation.Controls.Add(this.txtFileSize);
            this.gbInformation.Controls.Add(this.lblFileSize);
            this.gbInformation.Controls.Add(this.txtFilename);
            this.gbInformation.Controls.Add(this.lblFilename);
            this.gbInformation.Location = new System.Drawing.Point(19, 16);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(403, 137);
            this.gbInformation.TabIndex = 0;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Information";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(331, 95);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(57, 23);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtDirectLink
            // 
            this.txtDirectLink.Location = new System.Drawing.Point(111, 97);
            this.txtDirectLink.Name = "txtDirectLink";
            this.txtDirectLink.ReadOnly = true;
            this.txtDirectLink.Size = new System.Drawing.Size(214, 20);
            this.txtDirectLink.TabIndex = 5;
            // 
            // lblDirectLink
            // 
            this.lblDirectLink.AutoSize = true;
            this.lblDirectLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectLink.Location = new System.Drawing.Point(17, 98);
            this.lblDirectLink.Name = "lblDirectLink";
            this.lblDirectLink.Size = new System.Drawing.Size(88, 15);
            this.lblDirectLink.TabIndex = 4;
            this.lblDirectLink.Text = "Direct Link : ";
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(110, 62);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.ReadOnly = true;
            this.txtFileSize.Size = new System.Drawing.Size(80, 20);
            this.txtFileSize.TabIndex = 3;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.Location = new System.Drawing.Point(29, 63);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(75, 15);
            this.lblFileSize.TabIndex = 2;
            this.lblFileSize.Text = "File Size : ";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(110, 29);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(215, 20);
            this.txtFilename.TabIndex = 1;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(25, 30);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(79, 15);
            this.lblFilename.TabIndex = 0;
            this.lblFilename.Text = "Filename : ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbDownloader);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(443, 240);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Downloader";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbDownloader
            // 
            this.gbDownloader.Controls.Add(this.gbProgress);
            this.gbDownloader.Location = new System.Drawing.Point(21, 38);
            this.gbDownloader.Name = "gbDownloader";
            this.gbDownloader.Size = new System.Drawing.Size(401, 157);
            this.gbDownloader.TabIndex = 0;
            this.gbDownloader.TabStop = false;
            this.gbDownloader.Text = "Downloader";
            // 
            // gbProgress
            // 
            this.gbProgress.Controls.Add(this.pbProgress);
            this.gbProgress.Location = new System.Drawing.Point(26, 43);
            this.gbProgress.Name = "gbProgress";
            this.gbProgress.Size = new System.Drawing.Size(345, 75);
            this.gbProgress.TabIndex = 0;
            this.gbProgress.TabStop = false;
            this.gbProgress.Text = "Progress";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(23, 29);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(302, 23);
            this.pbProgress.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gbFilesDownloaded);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(443, 240);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Files Downloaded";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbFilesDownloaded
            // 
            this.gbFilesDownloaded.Controls.Add(this.lbFilesDownloaded);
            this.gbFilesDownloaded.Controls.Add(this.lvFilesDownloaded);
            this.gbFilesDownloaded.Location = new System.Drawing.Point(20, 21);
            this.gbFilesDownloaded.Name = "gbFilesDownloaded";
            this.gbFilesDownloaded.Size = new System.Drawing.Size(396, 197);
            this.gbFilesDownloaded.TabIndex = 0;
            this.gbFilesDownloaded.TabStop = false;
            this.gbFilesDownloaded.Text = "Files Downloaded";
            // 
            // lbFilesDownloaded
            // 
            this.lbFilesDownloaded.FormattingEnabled = true;
            this.lbFilesDownloaded.Location = new System.Drawing.Point(258, 70);
            this.lbFilesDownloaded.Name = "lbFilesDownloaded";
            this.lbFilesDownloaded.Size = new System.Drawing.Size(120, 95);
            this.lbFilesDownloaded.TabIndex = 1;
            this.lbFilesDownloaded.Visible = false;
            // 
            // lvFilesDownloaded
            // 
            this.lvFilesDownloaded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvFilesDownloaded.ContextMenuStrip = this.cmsOpciones;
            this.lvFilesDownloaded.FullRowSelect = true;
            this.lvFilesDownloaded.Location = new System.Drawing.Point(28, 33);
            this.lvFilesDownloaded.Name = "lvFilesDownloaded";
            this.lvFilesDownloaded.Size = new System.Drawing.Size(350, 142);
            this.lvFilesDownloaded.TabIndex = 0;
            this.lvFilesDownloaded.UseCompatibleStateImageBehavior = false;
            this.lvFilesDownloaded.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Creation Data";
            this.columnHeader2.Width = 169;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFileDownloaded,
            this.RefreshDownloads});
            this.cmsOpciones.Name = "contextMenuStrip1";
            this.cmsOpciones.Size = new System.Drawing.Size(114, 48);
            // 
            // LoadFileDownloaded
            // 
            this.LoadFileDownloaded.Name = "LoadFileDownloaded";
            this.LoadFileDownloaded.Size = new System.Drawing.Size(113, 22);
            this.LoadFileDownloaded.Text = "Load";
            this.LoadFileDownloaded.Click += new System.EventHandler(this.LoadFileDownloaded_Click);
            // 
            // RefreshDownloads
            // 
            this.RefreshDownloads.Name = "RefreshDownloads";
            this.RefreshDownloads.Size = new System.Drawing.Size(113, 22);
            this.RefreshDownloads.Text = "Refresh";
            this.RefreshDownloads.Click += new System.EventHandler(this.RefreshDownloads_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gbAbout);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(443, 240);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.lblAbout);
            this.gbAbout.Controls.Add(this.pbAbout);
            this.gbAbout.Location = new System.Drawing.Point(23, 20);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Size = new System.Drawing.Size(404, 201);
            this.gbAbout.TabIndex = 0;
            this.gbAbout.TabStop = false;
            this.gbAbout.Text = "About";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(201, 69);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(197, 65);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "SendSpace Downloader\r\nVersion 0.4\r\nWritten By Ismael Heredia\r\nContact : ismael_he" +
    "redia[at]hotmail[com]\r\nWeb : ismaelheredia123.wordpress.com";
            // 
            // pbAbout
            // 
            this.pbAbout.Image = ((System.Drawing.Image)(resources.GetObject("pbAbout.Image")));
            this.pbAbout.Location = new System.Drawing.Point(19, 28);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(176, 153);
            this.pbAbout.TabIndex = 0;
            this.pbAbout.TabStop = false;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.status.Location = new System.Drawing.Point(0, 291);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(470, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 313);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = " - SendSpace Downloader 0.3 - © Ismael Heredia , Argentina , 2014 -";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbEnterLink.ResumeLayout(false);
            this.gbEnterLink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbDownload.ResumeLayout(false);
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbDownloader.ResumeLayout(false);
            this.gbProgress.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.gbFilesDownloaded.ResumeLayout(false);
            this.cmsOpciones.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbEnterLink;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtEnterLink;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.TextBox txtDirectLink;
        private System.Windows.Forms.Label lblDirectLink;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox gbDownloader;
        private System.Windows.Forms.GroupBox gbProgress;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.GroupBox gbFilesDownloaded;
        private System.Windows.Forms.ListView lvFilesDownloaded;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.PictureBox pbAbout;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem RefreshDownloads;
        private System.Windows.Forms.ListBox lbFilesDownloaded;
        private System.Windows.Forms.ToolStripMenuItem LoadFileDownloaded;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.GroupBox gbDownload;
        private System.Windows.Forms.Button btnDownload;
    }
}

