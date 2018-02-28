using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace snooker
{
    public partial class MainForm : Form
    {
        private Timer _timer;

        private DateTime _startTime = DateTime.MinValue;
        private TimeSpan _currentElapsedTime = TimeSpan.Zero;
        private TimeSpan _totalElapsedTime = TimeSpan.Zero;

        private bool _timerRunning = false;


        private bool tableOne = true,tableTwo= true,tableThree=true,tableFour = true;
        public MainForm()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(_timer_Tick);
        }
        void _timer_Tick(object sender, EventArgs e)
        {

            var timeSinceStartTime = DateTime.Now - _startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);
            _currentElapsedTime = timeSinceStartTime + _totalElapsedTime;
            TimeTableOne.Text = timeSinceStartTime.ToString();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            
            if (this.tableOne == true) {
                GameStart();
                btnTableOne.Text = "Stop";
                this.tableOne = false;
            }
            else
            {
                GameStop();
                btnTableOne.Text = "Start";
            }

        }

        public void GameStart()
        {
            if (!_timerRunning)
            {
                // Set the start time to Now
                _startTime = DateTime.Now;

                // Store the total elapsed time so far
                _totalElapsedTime = _currentElapsedTime;

                _timer.Start();
                _timerRunning = true;
            }

        }

        public void GameStop()
        {
            if (_timerRunning)
            {
                _timer.Stop();
                _timerRunning = false;
            }
        }

    }
}
