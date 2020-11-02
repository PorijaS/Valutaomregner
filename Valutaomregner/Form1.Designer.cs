namespace Valutaomregner
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.amount_text = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.display_txt = new System.Windows.Forms.Label();
			this.conv_btn = new System.Windows.Forms.Button();
			this.clear_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(141, 138);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(144, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(141, 198);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(144, 21);
			this.comboBox2.TabIndex = 0;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// amount_text
			// 
			this.amount_text.Location = new System.Drawing.Point(141, 79);
			this.amount_text.Name = "amount_text";
			this.amount_text.Size = new System.Drawing.Size(144, 20);
			this.amount_text.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter Amount";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Convert From";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(54, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Convert To";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// display_txt
			// 
			this.display_txt.AutoSize = true;
			this.display_txt.Location = new System.Drawing.Point(169, 263);
			this.display_txt.Name = "display_txt";
			this.display_txt.Size = new System.Drawing.Size(0, 13);
			this.display_txt.TabIndex = 5;
			// 
			// conv_btn
			// 
			this.conv_btn.Location = new System.Drawing.Point(141, 288);
			this.conv_btn.Name = "conv_btn";
			this.conv_btn.Size = new System.Drawing.Size(144, 22);
			this.conv_btn.TabIndex = 6;
			this.conv_btn.Text = "Convert";
			this.conv_btn.UseVisualStyleBackColor = true;
			this.conv_btn.Click += new System.EventHandler(this.conv_btn_Click);
			// 
			// clear_btn
			// 
			this.clear_btn.Location = new System.Drawing.Point(141, 317);
			this.clear_btn.Name = "clear_btn";
			this.clear_btn.Size = new System.Drawing.Size(144, 23);
			this.clear_btn.TabIndex = 7;
			this.clear_btn.Text = "Clear";
			this.clear_btn.UseVisualStyleBackColor = true;
			this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(426, 450);
			this.Controls.Add(this.clear_btn);
			this.Controls.Add(this.conv_btn);
			this.Controls.Add(this.display_txt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.amount_text);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.TextBox amount_text;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label display_txt;
		private System.Windows.Forms.Button conv_btn;
		private System.Windows.Forms.Button clear_btn;
	}
}

