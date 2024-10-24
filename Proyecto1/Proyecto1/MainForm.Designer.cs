/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 23/10/2024
 * Time: 17:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(111, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOMBRE";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(448, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "APELLIDO1";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(111, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "APELLIDO2";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(111, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "DIRECCION";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(448, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "TELEFONO";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(111, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(218, 22);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(448, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(218, 22);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(111, 137);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(218, 22);
			this.textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(111, 207);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(218, 22);
			this.textBox4.TabIndex = 8;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(448, 207);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(218, 22);
			this.textBox5.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(448, 272);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(191, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "FECHA DE NACIMIENTO";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(117, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "SEMESTRE";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Semestre 1",
			"Semestre 2",
			"Semestre 3",
			"Semestre 4",
			"Semestre 5",
			"Semestre 6"});
			this.comboBox1.Location = new System.Drawing.Point(111, 300);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(218, 24);
			this.comboBox1.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(196, 395);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(161, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "LIMPIAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(427, 395);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(161, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "GUARDAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(448, 298);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 18;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 495);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Proyecto1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
