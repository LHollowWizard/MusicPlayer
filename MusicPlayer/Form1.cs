using System;
using System.Security;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayerForm : Form
    {


        public MusicPlayerForm()
        {
            InitializeComponent();
            var musicDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            openFileDialog.InitialDirectory = musicDirectory;
            openFileDialog.Filter = "Music Files(*.mp3;*.wav ;*.wma;*.asf;*.mp4;*.mpg;*.mpa;*.zpl)|*.mp3;*.wav;*.wma;*.asf;*.mp4;*.mpg ;*.mpa;*.zpl";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Choose a music";
            openFileDialog.RestoreDirectory = false;
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach(string filePath in openFileDialog.FileNames)
                {
                    try
                    {
                        Player.URL += filePath;
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                                        "Error message: " + ex.Message + "\n\n" +
                                        "Details (send to Support):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Could not load the sound - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot play the sound " + filePath.Substring(filePath.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
