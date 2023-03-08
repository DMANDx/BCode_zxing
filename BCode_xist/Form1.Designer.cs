//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using ZXing;
using System.Drawing.Imaging;
using System.IO;

namespace BCode_xist
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class Form1 : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.PropertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.Button2 = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(11, 20);
			this.ComboBox1.Margin = new System.Windows.Forms.Padding(4);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(160, 23);
			this.ComboBox1.TabIndex = 0;
			//
			//GroupBox1
			//
			this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(204));
			this.GroupBox1.ForeColor = System.Drawing.Color.DarkOrange;
			this.GroupBox1.Location = new System.Drawing.Point(8, 8);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.GroupBox1.Size = new System.Drawing.Size(184, 56);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Type of BCode";
			//
			//TextBox1
			//
			this.TextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(204));
			this.TextBox1.Location = new System.Drawing.Point(8, 336);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBox1.Size = new System.Drawing.Size(744, 72);
			this.TextBox1.TabIndex = 3;
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(208, 24);
			this.TextBox2.Multiline = true;
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(160, 36);
			this.TextBox2.TabIndex = 4;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.ForeColor = System.Drawing.Color.DarkOrange;
			this.Label1.Location = new System.Drawing.Point(240, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(100, 16);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Data for BCode";
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(204));
			this.Button1.ForeColor = System.Drawing.Color.DarkOrange;
			this.Button1.Image = (System.Drawing.Image)(resources.GetObject("Button1.Image"));
			this.Button1.Location = new System.Drawing.Point(384, 0);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(88, 48);
			this.Button1.TabIndex = 6;
			this.Button1.Text = "Generate";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//PictureBox1
			//
			this.PictureBox1.Location = new System.Drawing.Point(8, 80);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(464, 240);
			this.PictureBox1.TabIndex = 7;
			this.PictureBox1.TabStop = false;
			//        
			//PropertyGrid1
			//
			this.PropertyGrid1.Location = new System.Drawing.Point(480, 16);
			this.PropertyGrid1.Name = "PropertyGrid1";
			this.PropertyGrid1.Size = new System.Drawing.Size(264, 304);
			this.PropertyGrid1.TabIndex = 9;
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(204));
			this.Button2.ForeColor = System.Drawing.Color.DarkOrange;
			this.Button2.Image = (System.Drawing.Image)(resources.GetObject("Button2.Image"));
			this.Button2.Location = new System.Drawing.Point(384, 48);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(88, 29);
			this.Button2.TabIndex = 10;
			this.Button2.Text = "Save";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float)(8.0), (float)(16.0));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (System.Drawing.Image)(resources.GetObject("$this.BackgroundImage"));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(761, 414);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.PropertyGrid1);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.GroupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(204));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted event handler wireups:
			Button2.Click += new System.EventHandler(Button2_Click);
			Button1.Click += new System.EventHandler(Button1_Click);
			ComboBox1.SelectionChangeCommitted += new System.EventHandler(ComboBox1_SelectionChangeCommitted);
			base.Load += new System.EventHandler(Form1_Load);

		}
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.PropertyGrid PropertyGrid1;
		internal System.Windows.Forms.Button Button2;
	}

} //end of root namespace