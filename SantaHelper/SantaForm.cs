using System;
using System.Media;
using System.Windows.Forms;
using SantaHelper.Properties;

namespace SantaHelper
{
    public partial class SantaForm : Form
    {
        private SoundPlayer _player;
        private bool _isMute;
        public SantaForm()
        {
            InitializeComponent();
            _isMute = false;
            _player = new SoundPlayer(Resources.background_music);
            _player.PlayLooping();
        }

        private void numberOfKidsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            kidNumber.Text = numberOfKidsTrackBar.Value.ToString();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            SantaGifts santaGifts = new SantaGifts();
            string[] input = giftsTextBox.Text.Split(',');
            string[] result = santaGifts.Distribute(input, numberOfKidsTrackBar.Value);

            if (!_isMute)
            {
                PlayHoHoHo();
            }

            var resultForm = new ResultForm();
            resultForm.SetGiftsListFrom(result);
            resultForm.Closed += (s, args) => PlayBackgroundMusic();
            resultForm.Show();
        }

        private void PlayBackgroundMusic()
        {
            _player.Stream = Resources.background_music;
            _player.PlayLooping();
        }

        private void PlayHoHoHo()
        {
            _player.Stream = Resources.hohoho;
            _player.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _isMute = !_isMute;
            if (_isMute)
            {
                pictureBox1.BackgroundImage = Resources.sound_off;
                _player.Stop();
            }
            else
            {
                pictureBox1.BackgroundImage = Resources.sound_on;
                PlayBackgroundMusic();
            }
        }
    }
}