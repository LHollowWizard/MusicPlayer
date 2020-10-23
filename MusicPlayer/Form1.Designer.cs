namespace MusicPlayer
{
    partial class MusicPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerForm));
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Browse = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(2, -16);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(715, 295);
            this.Player.TabIndex = 0;
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.Gray;
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Browse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Browse.Location = new System.Drawing.Point(4, 285);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(137, 45);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Gray;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(576, 285);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(137, 45);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Gray;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Stop.Location = new System.Drawing.Point(433, 285);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(137, 45);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Gray;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Pause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pause.Location = new System.Drawing.Point(290, 285);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(137, 45);
            this.Pause.TabIndex = 5;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Gray;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Play.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Play.Location = new System.Drawing.Point(147, 285);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(137, 45);
            this.Play.TabIndex = 6;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 247);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.TabIndex = 7;
            // 
            // MusicPlayerForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(715, 338);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MusicPlayerForm";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBox1;
    }
}

