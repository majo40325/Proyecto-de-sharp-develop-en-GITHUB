/*
 * Created by SharpDevelop.
 * User: CC2_PC46
 * Date: 27/10/2026
 * Time: 07:28 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica_Git
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSumarClick(object sender, EventArgs e)
		{
			double resultado, num1, num2;
			num1=Convert.ToDouble(textBox1.Text);
			num2=Convert.ToDouble(textBox2.Text);
			resultado= num1 + num2;
			lblRes.Text=Convert.ToString(resultado);
		}
		
		void BtnRestarClick(object sender, EventArgs e)
		{
			double resultado, num1, num2;
			num1=Convert.ToDouble(textBox1.Text);
			num2=Convert.ToDouble(textBox2.Text);
			resultado= num1 - num2;
			lblRes.Text=Convert.ToString(resultado);
		}
		
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			double resultado, num1, num2;
			num1=Convert.ToDouble(textBox1.Text);
			num2=Convert.ToDouble(textBox2.Text);
			resultado= num1 * num2;
			lblRes.Text=Convert.ToString(resultado);
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double resultado, num1, num2;
			num1=Convert.ToDouble(textBox1.Text);
			num2=Convert.ToDouble(textBox2.Text);
			resultado= num1 / num2;
			lblRes.Text=Convert.ToString(resultado);
		}
	}
}