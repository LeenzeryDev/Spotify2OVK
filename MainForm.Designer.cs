namespace Spotify2OVK
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logoutButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.song = new System.Windows.Forms.TextBox();
            this.songChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(12, 53);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(96, 39);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "выход";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(256, 53);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 39);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "запуск";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // song
            // 
            this.song.Location = new System.Drawing.Point(12, 12);
            this.song.Name = "song";
            this.song.PlaceholderText = "Тут будет трек";
            this.song.ReadOnly = true;
            this.song.Size = new System.Drawing.Size(340, 35);
            this.song.TabIndex = 2;
            // 
            // songChecker
            // 
            this.songChecker.Tick += new System.EventHandler(this.songChecker_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(364, 105);
            this.Controls.Add(this.song);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.logoutButton);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "Spotify2OVK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button logoutButton;
        private Button startButton;
        private TextBox song;
        private System.Windows.Forms.Timer songChecker;
    }
}