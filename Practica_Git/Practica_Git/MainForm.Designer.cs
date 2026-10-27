/*
 * Created by SharpDevelop.
 * User: CC2_PC46
 * Date: 27/10/2026
 * Time: 07:28 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica_Git
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSumar = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.lblRes = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(132, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(132, 42);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(121, 20);
			this.textBox2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Numero 1:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Numero 2:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnSumar
			// 
			this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSumar.Location = new System.Drawing.Point(12, 86);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(98, 35);
			this.btnSumar.TabIndex = 4;
			this.btnSumar.Text = "Sumar";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// btnRestar
			// 
			this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestar.Location = new System.Drawing.Point(174, 86);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(98, 35);
			this.btnRestar.TabIndex = 5;
			this.btnRestar.Text = "Restar";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiplicar.Location = new System.Drawing.Point(12, 127);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(98, 35);
			this.btnMultiplicar.TabIndex = 6;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// btnDividir
			// 
			this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDividir.Location = new System.Drawing.Point(174, 127);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(98, 35);
			this.btnDividir.TabIndex = 7;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// lblRes
			// 
			this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRes.Location = new System.Drawing.Point(69, 197);
			this.lblRes.Name = "lblRes";
			this.lblRes.Size = new System.Drawing.Size(146, 35);
			this.lblRes.TabIndex = 8;
			this.lblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(74, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(141, 18);
			this.label4.TabIndex = 9;
			this.label4.Text = "Su resultado es :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 241);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblRes);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Practica_Git";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblRes;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
	}
}
