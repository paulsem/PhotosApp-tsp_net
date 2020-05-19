namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.imageDetails = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.anotimpBox = new System.Windows.Forms.TextBox();
            this.PersoaneBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detailsBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adaugaDetalii = new System.Windows.Forms.Button();
            this.dirBrowse = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog4 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog5 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog6 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.searchView = new System.Windows.Forms.ListBox();
            this.panelImages = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.updateDetalii = new System.Windows.Forms.Button();
            this.videoBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBrowse
            // 
            this.imageBrowse.Location = new System.Drawing.Point(12, 12);
            this.imageBrowse.Name = "imageBrowse";
            this.imageBrowse.Size = new System.Drawing.Size(85, 24);
            this.imageBrowse.TabIndex = 1;
            this.imageBrowse.Text = "Imagine";
            this.imageBrowse.UseVisualStyleBackColor = true;
            this.imageBrowse.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1007, 518);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Tag = "path";
            this.textBox1.Visible = false;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(869, 25);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(339, 22);
            this.searchText.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1214, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(90, 32);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // imageDetails
            // 
            this.imageDetails.Location = new System.Drawing.Point(545, 22);
            this.imageDetails.Name = "imageDetails";
            this.imageDetails.Size = new System.Drawing.Size(273, 34);
            this.imageDetails.TabIndex = 6;
            this.imageDetails.Text = "Image Details";
            this.imageDetails.UseVisualStyleBackColor = true;
            this.imageDetails.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(545, 77);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(273, 22);
            this.textBoxPath.TabIndex = 7;
             // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(545, 115);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(273, 22);
            this.locationBox.TabIndex = 8;
            // 
            // anotimpBox
            // 
            this.anotimpBox.Location = new System.Drawing.Point(545, 157);
            this.anotimpBox.Name = "anotimpBox";
            this.anotimpBox.Size = new System.Drawing.Size(273, 22);
            this.anotimpBox.TabIndex = 9;
            // 
            // PersoaneBox
            // 
            this.PersoaneBox.Location = new System.Drawing.Point(545, 240);
            this.PersoaneBox.Name = "PersoaneBox";
            this.PersoaneBox.Size = new System.Drawing.Size(273, 22);
            this.PersoaneBox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 404);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // detailsBox
            // 
            this.detailsBox.FormattingEnabled = true;
            this.detailsBox.ItemHeight = 16;
            this.detailsBox.Location = new System.Drawing.Point(12, 487);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(424, 148);
            this.detailsBox.TabIndex = 13;
            this.detailsBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Locatie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Anotimp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Persoane";
            // 
            // adaugaDetalii
            // 
            this.adaugaDetalii.Location = new System.Drawing.Point(545, 294);
            this.adaugaDetalii.Name = "adaugaDetalii";
            this.adaugaDetalii.Size = new System.Drawing.Size(76, 46);
            this.adaugaDetalii.TabIndex = 19;
            this.adaugaDetalii.Text = "Adauga detalii";
            this.adaugaDetalii.UseVisualStyleBackColor = true;
            this.adaugaDetalii.Click += new System.EventHandler(this.button5_Click);
            // 
            // dirBrowse
            // 
            this.dirBrowse.Location = new System.Drawing.Point(194, 12);
            this.dirBrowse.Name = "dirBrowse";
            this.dirBrowse.Size = new System.Drawing.Size(85, 24);
            this.dirBrowse.TabIndex = 20;
            this.dirBrowse.Text = "Director";
            this.dirBrowse.UseVisualStyleBackColor = true;
            this.dirBrowse.Click += new System.EventHandler(this.button6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(545, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // searchView
            // 
            this.searchView.FormattingEnabled = true;
            this.searchView.ItemHeight = 16;
            this.searchView.Location = new System.Drawing.Point(869, 53);
            this.searchView.Name = "searchView";
            this.searchView.Size = new System.Drawing.Size(435, 52);
            this.searchView.TabIndex = 22;
            // 
            // panelImages
            // 
            this.panelImages.Location = new System.Drawing.Point(869, 111);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(435, 373);
            this.panelImages.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(745, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 46);
            this.button2.TabIndex = 25;
            this.button2.Text = "Sterge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // updateDetalii
            // 
            this.updateDetalii.Location = new System.Drawing.Point(648, 294);
            this.updateDetalii.Name = "updateDetalii";
            this.updateDetalii.Size = new System.Drawing.Size(70, 46);
            this.updateDetalii.TabIndex = 26;
            this.updateDetalii.Text = "Update detalii";
            this.updateDetalii.UseVisualStyleBackColor = true;
            this.updateDetalii.Click += new System.EventHandler(this.updateDetalii_Click);
            // 
            // videoBrowse
            // 
            this.videoBrowse.Location = new System.Drawing.Point(103, 12);
            this.videoBrowse.Name = "videoBrowse";
            this.videoBrowse.Size = new System.Drawing.Size(85, 24);
            this.videoBrowse.TabIndex = 27;
            this.videoBrowse.Text = "Video";
            this.videoBrowse.UseVisualStyleBackColor = true;
            this.videoBrowse.Click += new System.EventHandler(this.videoBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 674);
            this.Controls.Add(this.videoBrowse);
            this.Controls.Add(this.updateDetalii);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelImages);
            this.Controls.Add(this.searchView);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dirBrowse);
            this.Controls.Add(this.adaugaDetalii);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.PersoaneBox);
            this.Controls.Add(this.anotimpBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.imageDetails);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imageBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button imageBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button imageDetails;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox anotimpBox;
        private System.Windows.Forms.TextBox PersoaneBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox detailsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button adaugaDetalii;
        private System.Windows.Forms.Button dirBrowse;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox searchView;
        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button updateDetalii;
        private System.Windows.Forms.Button videoBrowse;
    }
}

