namespace MusicSearchByGenre
{
    partial class mainForm
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
            this.browseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.catalogForFindTextBox = new System.Windows.Forms.TextBox();
            this.findStartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genresTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.artistsTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.albumArtistTextBox = new System.Windows.Forms.TextBox();
            this.durationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.resultListView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.LightGray;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseButton.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseButton.Location = new System.Drawing.Point(538, 43);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(118, 40);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Каталог для поиска";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // catalogForFindTextBox
            // 
            this.catalogForFindTextBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalogForFindTextBox.Location = new System.Drawing.Point(18, 43);
            this.catalogForFindTextBox.Name = "catalogForFindTextBox";
            this.catalogForFindTextBox.Size = new System.Drawing.Size(514, 38);
            this.catalogForFindTextBox.TabIndex = 2;
            // 
            // findStartButton
            // 
            this.findStartButton.BackColor = System.Drawing.Color.LightGreen;
            this.findStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findStartButton.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.findStartButton.Location = new System.Drawing.Point(662, 43);
            this.findStartButton.Name = "findStartButton";
            this.findStartButton.Size = new System.Drawing.Size(118, 40);
            this.findStartButton.TabIndex = 4;
            this.findStartButton.Text = "Find";
            this.findStartButton.UseVisualStyleBackColor = false;
            this.findStartButton.Click += new System.EventHandler(this.findStartButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(768, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Результат поиска";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(768, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Критерии поиска";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genresTextBox
            // 
            this.genresTextBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genresTextBox.Location = new System.Drawing.Point(18, 171);
            this.genresTextBox.Name = "genresTextBox";
            this.genresTextBox.Size = new System.Drawing.Size(198, 38);
            this.genresTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Жанр";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(218, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Год";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearTextBox.Location = new System.Drawing.Point(222, 171);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(150, 38);
            this.yearTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(374, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Исполнители";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artistsTextBox
            // 
            this.artistsTextBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistsTextBox.Location = new System.Drawing.Point(378, 171);
            this.artistsTextBox.Name = "artistsTextBox";
            this.artistsTextBox.Size = new System.Drawing.Size(198, 38);
            this.artistsTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(578, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Альбом";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // albumTextBox
            // 
            this.albumTextBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumTextBox.Location = new System.Drawing.Point(582, 171);
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(198, 38);
            this.albumTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "Исполнитель альбома";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // albumArtistTextBox
            // 
            this.albumArtistTextBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumArtistTextBox.Location = new System.Drawing.Point(18, 247);
            this.albumArtistTextBox.Name = "albumArtistTextBox";
            this.albumArtistTextBox.Size = new System.Drawing.Size(328, 38);
            this.albumArtistTextBox.TabIndex = 16;
            // 
            // durationMaskedTextBox
            // 
            this.durationMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.durationMaskedTextBox.Location = new System.Drawing.Point(356, 247);
            this.durationMaskedTextBox.Mask = "00:00:00";
            this.durationMaskedTextBox.Name = "durationMaskedTextBox";
            this.durationMaskedTextBox.Size = new System.Drawing.Size(163, 38);
            this.durationMaskedTextBox.TabIndex = 18;
            this.durationMaskedTextBox.Text = "000000";
            this.durationMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.durationMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 37);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Больше";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.groupBox1.Location = new System.Drawing.Point(525, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 78);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(129, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 37);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.Text = "Меньше";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(350, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 31);
            this.label9.TabIndex = 21;
            this.label9.Text = "Длительность";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultListView
            // 
            this.resultListView.Font = new System.Drawing.Font("Arial Narrow", 13.8F);
            this.resultListView.Location = new System.Drawing.Point(18, 320);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(762, 356);
            this.resultListView.TabIndex = 24;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.List;
            this.resultListView.DoubleClick += new System.EventHandler(this.resultListBox_DoubleClick);
            // 
            // mainForm
            // 
            this.AcceptButton = this.findStartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(795, 688);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.durationMaskedTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.albumArtistTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.albumTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.artistsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genresTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findStartButton);
            this.Controls.Add(this.catalogForFindTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox catalogForFindTextBox;
        private System.Windows.Forms.Button findStartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox genresTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox artistsTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox albumTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox albumArtistTextBox;
        private System.Windows.Forms.MaskedTextBox durationMaskedTextBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView resultListView;
    }
}

