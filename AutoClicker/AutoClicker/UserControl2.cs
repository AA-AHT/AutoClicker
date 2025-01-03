using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AutoClicker
{
	public partial class UserControl2 : UserControl
	{
		public UserControl2()
		{
			InitializeComponent();
		}

		private void deleteButton_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(deleteButton, "Delete this wait event");
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void label2_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(label2, "1 second is equal to 1000 millisecond");
		}
	}
}
