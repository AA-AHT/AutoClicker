using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoClicker
{
	public partial class UserControl1 : UserControl
	{
		public string buttonChecked = "Left";
		public UserControl1()
		{
			InitializeComponent();
		}

		private void selectButton_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(selectButton, "Click a mouse button to set values automatically.");
		}

		private void radioButton3_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(radioButton3, "Right button");
		}

		private void radioButton2_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(radioButton2, "Middle button");
		}

		private void radioButton1_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(radioButton1, "Left button");
		}

		private void AllCheckBoxes_CheckedChanged(object sender, EventArgs e)
		{
			buttonChecked = ((RadioButton)sender).Text;
		}

		private void deleteButton_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(deleteButton, "Delete this click event");
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		public static IntPtr mouseHookID = IntPtr.Zero;
		private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
		{
			if (nCode >= 0)
			{
				// Read mouse information
				var mouseInfo = (Mouse.MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(Mouse.MSLLHOOKSTRUCT));

				switch ((int)wParam)
				{
					case Mouse.WM_LBUTTONDOWN:
						xPos.Value = mouseInfo.pt.x;
						yPos.Value = mouseInfo.pt.y;
						radioButton1.Checked = true;
						Mouse.UnHook(mouseHookID);
						break;
					case Mouse.WM_MBUTTONDOWN:
						xPos.Value = mouseInfo.pt.x;
						yPos.Value = mouseInfo.pt.y;
						radioButton2.Checked = true;
						Mouse.UnHook(mouseHookID);
						break;
					case Mouse.WM_RBUTTONDOWN:
						xPos.Value = mouseInfo.pt.x;
						yPos.Value = mouseInfo.pt.y;
						radioButton3.Checked = true;
						Mouse.UnHook(mouseHookID);
						break;
				}
				
			}
			return Mouse.CallNextHookEx(mouseHookID, nCode, wParam, lParam);
		}

		private void selectButton_Click(object sender, EventArgs e)
		{
			mouseHookID = Mouse.SetHook(HookCallback);
		}
	}
}
