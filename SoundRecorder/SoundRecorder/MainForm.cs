//-----------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="MainForm.cs" company="UnMedioStudio">Open Source</copyright>
//-----------------------------------------------------------------------

/// <summary>
/// Sound Recorder
/// </summary>
namespace SoundRecorder
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    /// <summary>Main Form of the program.</summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        /// <summary>The record</summary>
        private bool record;

        /// <summary>The timer</summary>
        private int timer;

        /// <summary>Initializes a new instance of the <see cref="MainForm"/> class.</summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>Send string.</summary>
        /// <param name="mciComando">The mci command.</param>
        /// <param name="mciRetorno">The mci return.</param>
        /// <param name="mciRetornoLeng">The return length.</param>
        /// <param name="callBack">The call back.</param>
        /// <returns>Return none</returns>
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string mciComando, string mciRetorno, int mciRetornoLeng, int callBack);

        /// <summary>Handles the Click event of the button1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.record)
            {
                this.record = false;
                this.Recording.Visible = true;
                this.timer1.Enabled = true;
                this.StartRecord.Image = Properties.Resources.recordIdle;
                mciSendString("open new type waveaudio alias Som", null, 0, 0);
                mciSendString("record Som", null, 0, 0);
            }
            else 
            {
                this.record = true;
                this.Recording.Visible = false;
                this.timer1.Enabled = false;
                this.timerLabel.Text = "00:00:00";
                this.StartRecord.Image = Properties.Resources.record;

                mciSendString("pause Som", null, 0, 0);
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "mp3|*.mp3";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    mciSendString("save Som " + save.FileName, null, 0, 0);
                    mciSendString("close Som", null, 0, 0);
                }
            }
        }

        /// <summary>Handles the Load event of the MainForm control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Recording.Visible = false;
            this.StartRecord.Image = Properties.Resources.record;
            this.record = true;
        }

        /// <summary>Handles the Tick event of the timer1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.timer += 1;
            this.timerLabel.Text = TimeSpan.FromSeconds(this.timer).ToString();
        }
    }
}
