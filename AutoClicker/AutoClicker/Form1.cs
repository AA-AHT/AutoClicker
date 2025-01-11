using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using static AutoClicker.Mouse;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace AutoClicker
{
	
	public partial class Form1 : Form
	{
		Clicker clicker = null;
		Thread clickerThread = null;

		

		// AutoClicker state
		

		public Form1()
		{
			InitializeComponent();
			timer1.Start();
		}
		private void addClick_Click(object sender, EventArgs e)
		{
			var panel = new UserControl1();
			flowLayoutPanel1.Controls.Add(panel);
		}

		private void addWait_Click(object sender, EventArgs e)
		{
			var panel = new UserControl2();
			flowLayoutPanel1.Controls.Add(panel);
		}
		private void readyCheckbox_Click(object sender, EventArgs e)
		{
			if ( ((CheckBox)sender).Checked == true)
			{
				Ready();
			}
			else
			{
				Restore();
			}
		}

		public void Ready()
		{
			clicker = new Clicker();
			foreach (Control i in flowLayoutPanel1.Controls)
			{
				if (i is UserControl1)
				{
					int xPos = (int)((UserControl1)i).xPos.Value;
					int yPos = (int)((UserControl1)i).yPos.Value;
					Point pnt = new Point(xPos, yPos);
					clicker.processName.Add("Mouse Click");
					clicker.clickCoordianete.Add(pnt);
					clicker.clickButton.Add(((UserControl1)i).buttonChecked);
					clicker.clickDouble.Add(((UserControl1)i).doubleCheckBox.Checked);

					//MessageBox.Show($"{((UserControl1)i).buttonChecked} button click: X:{xPos} Y:{yPos}");
				}
				else if (i is UserControl2)
				{
					int milliSecond = (int)((UserControl2)i).waitValue.Value;
					clicker.processName.Add("Wait");
					clicker.waitMillisecond.Add(milliSecond);
					//MessageBox.Show($"Wait {milliSecond} millisecond");
				}
				i.Enabled = false;
			}
			addClick.Enabled = false;
			addWait.Enabled = false;
			menuStrip1.Enabled = false;
			toolStripStatusLabel1.Text = "Press F6 to Activate";



			clickerThread = new Thread(clicker.ClickThread);
			clickerThread.Start();
			keybHookID = Keyboard.SetHook(KeybHookCallback);
		}

		public void Restore()
		{
			foreach (Control i in flowLayoutPanel1.Controls)
			{
				i.Enabled = true;
			}
			addClick.Enabled = true;
			addWait.Enabled = true;
			menuStrip1.Enabled = true;
			toolStripStatusLabel1.Text = "Press Ready Button";
			clickerThread?.Abort();
			clicker = null;
			Keyboard.UnHook(keybHookID);
			keybHookID = IntPtr.Zero;
		}
		

		

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			clickerThread?.Abort();

			Keyboard.UnHook(keybHookID);

			base.OnFormClosing(e);
		}


		private static IntPtr keybHookID = IntPtr.Zero;
		public IntPtr KeybHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
		{
			if (nCode >= 0 && wParam == (IntPtr)Keyboard.WM_KEYUP)
			{
				int vkCode = Marshal.ReadInt32(lParam);
				if (readyCheckbox.Checked == true)
				{
					if (vkCode == 0x75) // F6
					{
						clicker.isClicking = !clicker.isClicking;
						statusStrip1.Invoke(new Action(() =>
						{
							toolStripStatusLabel1.Text = "Press F6 to " +
							(clicker.isClicking ? "Deactivate" : "Activate");
						}));
					}
				}
			}
			return Keyboard.CallNextHookEx(keybHookID, nCode, wParam, lParam);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel2.Text = $"     X:{Cursor.Position.X}  Y:{Cursor.Position.Y}";
			if(flowLayoutPanel1.Controls.Count <= 0 && readyCheckbox.Enabled == true)
			{
				saveToolStripMenuItem.Enabled = false;
				readyCheckbox.Enabled = false;
			}
			else if(flowLayoutPanel1.Controls.Count > 0 && readyCheckbox.Enabled == false)
			{
				saveToolStripMenuItem.Enabled = true;
				readyCheckbox.Enabled = true;
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Autoclicker from AHT");
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Autoclicker Script File|*.autoclicker";
			ofd.Title = "Load script from file";
			ofd.RestoreDirectory = true;
			ofd.InitialDirectory = Directory.GetCurrentDirectory();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				flowLayoutPanel1.Controls.Clear();
				System.IO.FileStream fs = (System.IO.FileStream)ofd.OpenFile();
				var sr = new StreamReader(fs);

				string line;
				while ((line = sr.ReadLine()) != null)
				{
					if (!string.IsNullOrEmpty(line))
					{
						char[] separators = new char[] { ' ', ',' };
						string[] subs = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
						switch (subs[0])
						{
							case "MouseClick":
								if (subs.GetLength(0) == 4)
								{
									UserControl1 userControl1 = new UserControl1();
									userControl1.xPos.Value = int.Parse(subs[1]);
									userControl1.yPos.Value = int.Parse(subs[2]);
									switch (subs[3])
									{
										case "Left":
											userControl1.radioButton1.Checked = true;
											break;
										case "Mid":
											userControl1.radioButton2.Checked = true;
											break;
										case "Right":
											userControl1.radioButton3.Checked = true;
											break;
									}
									flowLayoutPanel1.Controls.Add(userControl1);
								}
								break;
							case "Wait":
								if (subs.GetLength(0) == 2)
								{
									UserControl2 userControl2 = new UserControl2();
									userControl2.waitValue.Value = int.Parse(subs[1]);
									flowLayoutPanel1.Controls.Add(userControl2);
								}
								break;
						}
					}

				}
				sr.Close();
				fs.Close();
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Displays a SaveFileDialog so the user can save the Image
			// assigned to Button2.
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "Autoclicker Script File|*.autoclicker";
			saveFileDialog1.Title = "Save script to file";
			saveFileDialog1.FileName = "*.autoclicker";
			saveFileDialog1.RestoreDirectory = true;
			saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

			// If the file name is not an empty string open it for saving.
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				
				// Saves the Image via a FileStream created by the OpenFile method.
				System.IO.FileStream fs =
					(System.IO.FileStream)saveFileDialog1.OpenFile();
				// Saves the Image in the appropriate ImageFormat based upon the
				// File type selected in the dialog box.
				// NOTE that the FilterIndex property is one-based.
				foreach(UserControl i in flowLayoutPanel1.Controls)
				{
					if (i is UserControl1)
					{
						var text = $"MouseClick, {((UserControl1)i).xPos.Value}, {((UserControl1)i).yPos.Value}, {((UserControl1)i).buttonChecked}\r\n";
						byte[] writeArr = Encoding.UTF8.GetBytes(text);
						fs.Write(writeArr, 0, text.Length);
					}
					if (i is UserControl2)
					{
						var text = $"Wait, {((UserControl2)i).waitValue.Value}\r\n";
						byte[] writeArr = Encoding.UTF8.GetBytes(text);
						fs.Write(writeArr, 0, text.Length);
					}
				}

				fs.Close();
			}
		}
	}


	public class Clicker
	{
		public List<string> processName = new List<string>(); // "Mouse Click" or "Wait"
		public List<int> waitMillisecond = new List<int>();
		public List<Point> clickCoordianete = new List<Point>();
		public List<string> clickButton = new List<string>();
		public List<bool> clickDouble = new List<bool>();
		public bool isClicking = false;
		public void ClickThread()
		{
			while (true)
			{
				if (isClicking == true)
				{
					for (int i = 0, j = 0; i < processName.Count; i++)
					{
						switch (processName.ElementAt(i))
						{
							case "Mouse Click":
								Mouse.DoClick(clickCoordianete.ElementAt(j).X,
										clickCoordianete.ElementAt(j).Y,
										clickButton.ElementAt(j),
										clickDouble.ElementAt(j));
								j++;
								break;
							case "Wait":
								Thread.Sleep(waitMillisecond.ElementAt(i - j));
								break;
						}

					}
				}
				else
				{
					Thread.Sleep(1);
				}
			}
		}

	}


	public static class Mouse
	{
		public static IntPtr SetHook(WinAPI.LowLevelProc proc)
		{
			return WinAPI.SetWindowsHookEx(WH_MOUSE_LL, proc, IntPtr.Zero, 0);
		}
		public static bool UnHook(IntPtr hhk)
		{
			return WinAPI.UnhookWindowsHookEx(hhk);
		}
		public static void DoClick(int dx, int dy, string button, bool _double)
		{
			if(WinAPI.SetCursorPos(dx, dy) == false)
			{
				MessageBox.Show("Error: " + Marshal.GetLastWin32Error());
			}
			for (int i = _double?1:0; i >= 0; i--)
			{
				switch (button)
				{
					case "Left":
						WinAPI.mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE, dx, dy, 0, 0);
						WinAPI.mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE, dx, dy, 0, 0);
						break;
					case "Mid":
						WinAPI.mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_ABSOLUTE, dx, dy, 0, 0);
						WinAPI.mouse_event(MOUSEEVENTF_MIDDLEUP | MOUSEEVENTF_ABSOLUTE, dx, dy, 0, 0);
						break;
					case "Right":
						WinAPI.mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_ABSOLUTE, dx, dy, 0, 0);
						WinAPI.mouse_event(MOUSEEVENTF_RIGHTUP | MOUSEEVENTF_ABSOLUTE, dx, dy, 0, 0);
						break;
				}
			}
		}

		public const int WH_MOUSE_LL = 14;
		public const int WM_LBUTTONDOWN = 0x0201;
		public const int WM_LBUTTONUP = 0x0202;
		public const int WM_RBUTTONDOWN = 0x0204;
		public const int WM_RBUTTONUP = 0x0205;
		public const int WM_MBUTTONDOWN = 0x0207;
		public const int WM_MBUTTONUP = 0x0208;
		public const int WM_MOUSEMOVE = 0x0200;
		public const int WM_MOUSEWHEEL = 0x020A;
		public const int MOUSEEVENTF_MOVE = 0x0001;
		public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
		public const int MOUSEEVENTF_LEFTUP = 0x0004;
		public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
		public const int MOUSEEVENTF_RIGHTUP = 0x0010;
		public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
		public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
		public const int MOUSEEVENTF_WHEEL = 0x0800;
		public const int MOUSEEVENTF_ABSOLUTE = 0x8000;

		[StructLayout(LayoutKind.Sequential)]
		public struct POINT
		{
			public int x;
			public int y;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct MSLLHOOKSTRUCT
		{
			public POINT pt;
			public uint mouseData;
			public uint flags;
			public uint time;
			public IntPtr dwExtraInfo;
		}
		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
	}


	public static class Keyboard
	{
		public static IntPtr SetHook(WinAPI.LowLevelProc proc)
		{
			return WinAPI.SetWindowsHookEx(WH_KEYBOARD_LL, proc, IntPtr.Zero, 0);
		}

		public static bool UnHook(IntPtr hhk)
		{
			return WinAPI.UnhookWindowsHookEx(hhk);
		}


		public const int WH_KEYBOARD_LL = 13;
		public const int WM_KEYDOWN = 0x0100;
		public const int WM_KEYUP = 0x0101;

		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
	}
}
