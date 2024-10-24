/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 23/10/2024
 * Time: 20:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto1
{
	partial class RFC
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnmostrar;
		
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
			this.btnmostrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(34, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOMBRE";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(34, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(233, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(34, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "RFC";
			// 
			// btnmostrar
			// 
			this.btnmostrar.Location = new System.Drawing.Point(173, 259);
			this.btnmostrar.Name = "btnmostrar";
			this.btnmostrar.Size = new System.Drawing.Size(75, 23);
			this.btnmostrar.TabIndex = 4;
			this.btnmostrar.Text = "Mostrar";
			this.btnmostrar.UseVisualStyleBackColor = true;
			this.btnmostrar.Click += new System.EventHandler(this.BtnmostrarClick);
			// 
			// RFC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 371);
			this.Controls.Add(this.btnmostrar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "RFC";
			this.Text = "RFC";
			this.ResumeLayout(false);

		}
	}
}
