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
	partial class acerca
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelBFBB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		
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
			this.label3 = new System.Windows.Forms.Label();
			this.labelBFBB = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 151);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 69);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOMBRE DEL PROGRAMA\r\nPROYECTO SHARPDEVELOP EN GIT\r\nRFC\r\n";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(27, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(377, 48);
			this.label3.TabIndex = 2;
			this.label3.Text = "CENTRO DE BACHILLERATO TECNOLOGICO \r\nINDUSTRIAL Y DE SERVICIOS\r\n";
			// 
			// labelBFBB
			// 
			this.labelBFBB.Location = new System.Drawing.Point(27, 93);
			this.labelBFBB.Name = "labelBFBB";
			this.labelBFBB.Size = new System.Drawing.Size(322, 58);
			this.labelBFBB.TabIndex = 3;
			this.labelBFBB.Text = "MATERIA\r\nMETODOLOGIAS AGILES\r\nDOCENTE: LUIS GERMAN GUTIERREZ TORRES";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(27, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 40);
			this.label2.TabIndex = 4;
			this.label2.Text = "VERSION\r\n1.4\r\n";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(27, 272);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(306, 51);
			this.label4.TabIndex = 5;
			this.label4.Text = "FECHA DE CREACION\r\n23 DE OCTUBRE DEL 2024\r\n";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(27, 323);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(247, 50);
			this.label5.TabIndex = 6;
			this.label5.Text = "PROGRAMA ELABORADO POR\r\n DULCE MARIA DIEGO CHACON";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(27, 373);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(236, 31);
			this.label6.TabIndex = 7;
			this.label6.Text = "3ero DE PROGRAMACION";
			// 
			// acerca
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 448);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelBFBB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "acerca";
			this.Text = "ACERCA DE..";
			this.ResumeLayout(false);

		}
	}
}
