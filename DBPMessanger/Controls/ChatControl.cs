using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPMessanger.Controls
{
    public partial class ChatControl : UserControl
    {
        public ChatControl(string name, string message, DateTime date, bool isMine, int width)
        {
            InitializeComponent();

            labelMessage.Text = message;
            
            labelTime.Text = date.ToString("HH:mm");

            labelMessage.MaximumSize = new Size((int)(width * 0.7), 0);

            if (isMine)
            {
                labelName.Visible = false;
                tableLayoutPanel1.RowStyles[0].Height = 0;
                tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
                labelMessage.BackColor = Color.Yellow;
            }
            else
            {
                labelName.Text = name;
                labelMessage.BackColor = Color.White;
            }
        }
    }
}
