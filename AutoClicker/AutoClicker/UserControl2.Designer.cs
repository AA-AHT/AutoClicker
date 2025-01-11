namespace AutoClicker
{
	partial class UserControl2
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.waitValue = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.downButton = new System.Windows.Forms.Button();
			this.upButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.waitValue)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.waitValue);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.downButton);
			this.flowLayoutPanel1.Controls.Add(this.upButton);
			this.flowLayoutPanel1.Controls.Add(this.deleteButton);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 30);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Wait";
			// 
			// waitValue
			// 
			this.waitValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.waitValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.waitValue.CausesValidation = false;
			this.waitValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.waitValue.Location = new System.Drawing.Point(38, 6);
			this.waitValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.waitValue.Name = "waitValue";
			this.waitValue.Size = new System.Drawing.Size(66, 16);
			this.waitValue.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(110, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "millisecond";
			this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
			// 
			// downButton
			// 
			this.downButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.downButton.Image = global::AutoClicker.Properties.Resources.arrow_Down_16xLG;
			this.downButton.Location = new System.Drawing.Point(174, 3);
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(17, 23);
			this.downButton.TabIndex = 15;
			this.downButton.UseVisualStyleBackColor = true;
			this.downButton.Click += new System.EventHandler(this.downButton_Click);
			// 
			// upButton
			// 
			this.upButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.upButton.Image = global::AutoClicker.Properties.Resources.arrow_Up_16xLG;
			this.upButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.upButton.Location = new System.Drawing.Point(197, 3);
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(17, 23);
			this.upButton.TabIndex = 14;
			this.upButton.UseVisualStyleBackColor = true;
			this.upButton.Click += new System.EventHandler(this.upButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.deleteButton.ForeColor = System.Drawing.Color.Red;
			this.deleteButton.Location = new System.Drawing.Point(220, 3);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(16, 23);
			this.deleteButton.TabIndex = 10;
			this.deleteButton.Text = "X";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			this.deleteButton.MouseHover += new System.EventHandler(this.deleteButton_MouseHover);
			// 
			// UserControl2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "UserControl2";
			this.Size = new System.Drawing.Size(247, 31);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.waitValue)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		public System.Windows.Forms.NumericUpDown waitValue;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ToolTip toolTip1;
		public System.Windows.Forms.Button downButton;
		public System.Windows.Forms.Button upButton;
	}
}
