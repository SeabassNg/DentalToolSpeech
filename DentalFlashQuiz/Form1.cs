using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalFlashQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void speak(String s)
        {
            var reader = new SpeechSynthesizer();
            reader.Speak(s);
        }

        private void Object_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                speak((sender as PictureBox).Tag.ToString());
            }
            else
            {
                speak((sender as Label).Tag.ToString());
            }
        }
    }
}
