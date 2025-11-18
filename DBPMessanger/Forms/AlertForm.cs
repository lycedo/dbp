using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBPMessanger.Forms
{
    public partial class AlertForm : Form
    {
        public AlertForm(string name, string message)
        {
            InitializeComponent();


            // 폼이 표시되기 전에 위치 설정
            Load += (s, e) =>
            {
                labelName.Text = name;
                labelMessage.Text = message;

                var screen = Screen.PrimaryScreen!.WorkingArea;
                Location = new Point(
                    screen.Right - Width - 10,
                    screen.Bottom - Height - 10
                );
            };

            // 폼이 완전히 표시된 후 타이머 시작
            Shown += (s, e) =>
            {
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 3000;
                timer.Tick += (sender, args) =>
                {
                    timer.Stop();
                    timer.Dispose();
                    this.Close();
                };
                timer.Start();
            };
        }
    }
}
