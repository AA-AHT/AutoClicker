﻿namespace AutoClicker
{
	partial class UserControl1
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.selectButton = new System.Windows.Forms.Button();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.yPos = new System.Windows.Forms.NumericUpDown();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.xPos = new System.Windows.Forms.NumericUpDown();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.deleteButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.yPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xPos)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectButton
			// 
			this.selectButton.Location = new System.Drawing.Point(330, 3);
			this.selectButton.Name = "selectButton";
			this.selectButton.Size = new System.Drawing.Size(48, 23);
			this.selectButton.TabIndex = 8;
			this.selectButton.Text = "Select";
			this.selectButton.UseVisualStyleBackColor = true;
			this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
			this.selectButton.MouseHover += new System.EventHandler(this.selectButton_MouseHover);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(226, 3);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(42, 17);
			this.radioButton2.TabIndex = 6;
			this.radioButton2.Text = "Mid";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.AllCheckBoxes_CheckedChanged);
			this.radioButton2.Click += new System.EventHandler(this.AllCheckBoxes_CheckedChanged);
			this.radioButton2.MouseHover += new System.EventHandler(this.radioButton2_MouseHover);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(274, 3);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(50, 17);
			this.radioButton3.TabIndex = 7;
			this.radioButton3.Text = "Right";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.AllCheckBoxes_CheckedChanged);
			this.radioButton3.Click += new System.EventHandler(this.AllCheckBoxes_CheckedChanged);
			this.radioButton3.MouseHover += new System.EventHandler(this.radioButton3_MouseHover);
			// 
			// yPos
			// 
			this.yPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.yPos.Location = new System.Drawing.Point(114, 3);
			this.yPos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.yPos.Name = "yPos";
			this.yPos.Size = new System.Drawing.Size(57, 16);
			this.yPos.TabIndex = 3;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(177, 3);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(43, 17);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Left";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton3_MouseHover);
			this.radioButton1.Click += new System.EventHandler(this.AllCheckBoxes_CheckedChanged);
			this.radioButton1.MouseHover += new System.EventHandler(this.radioButton1_MouseHover);
			// 
			// xPos
			// 
			this.xPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.xPos.Location = new System.Drawing.Point(27, 3);
			this.xPos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.xPos.Name = "xPos";
			this.xPos.Size = new System.Drawing.Size(57, 16);
			this.xPos.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.xPos);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.yPos);
			this.flowLayoutPanel1.Controls.Add(this.radioButton1);
			this.flowLayoutPanel1.Controls.Add(this.radioButton2);
			this.flowLayoutPanel1.Controls.Add(this.radioButton3);
			this.flowLayoutPanel1.Controls.Add(this.selectButton);
			this.flowLayoutPanel1.Controls.Add(this.deleteButton);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(413, 30);
			this.flowLayoutPanel1.TabIndex = 2;
			this.flowLayoutPanel1.WrapContents = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "X";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(90, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Y";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// deleteButton
			// 
			this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.deleteButton.ForeColor = System.Drawing.Color.Red;
			this.deleteButton.Location = new System.Drawing.Point(384, 3);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(16, 23);
			this.deleteButton.TabIndex = 11;
			this.deleteButton.Text = "X";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			this.deleteButton.MouseHover += new System.EventHandler(this.deleteButton_MouseHover);
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(416, 33);
			((System.ComponentModel.ISupportInitialize)(this.yPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xPos)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		public System.Windows.Forms.Button selectButton;
		public System.Windows.Forms.RadioButton radioButton2;
		public System.Windows.Forms.RadioButton radioButton3;
		public System.Windows.Forms.NumericUpDown yPos;
		public System.Windows.Forms.RadioButton radioButton1;
		public System.Windows.Forms.NumericUpDown xPos;
		private System.Windows.Forms.Button deleteButton;
	}
}