using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateAndTimePicker
{
    public partial class DTPicker : Form
    {

        public string SelectedDate { get; set; } 
        public string SelectedTime { get; set; }

        public DTPicker(string greeting = "Please pick a date and time.")
        {
            InitializeComponent();

            lblCustomMessage.Text = greeting;

            datePicker.Value = DateTime.Today;
            TimePicker.Value = DateTime.Now;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SelectedDate = datePicker.Value.ToString("MM-dd-yyyy");
            SelectedTime = TimePicker.Value.ToString("HH:mm");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            this.SelectedDate = datePicker.Value.ToString("MM-dd-yyyy");
            this.SelectedTime = TimePicker.Value.ToString("HH:mm");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }


    }
}
