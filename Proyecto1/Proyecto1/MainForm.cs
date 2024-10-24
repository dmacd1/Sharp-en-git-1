/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 23/10/2024
 * Time: 17:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto1
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
		//BOTON PARA LIMPIAR LOS DATOS AGREGADOS
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Text="";
			textBox2.Text="";
			textBox3.Text="";
			textBox4.Text="";
			textBox5.Text="";
			comboBox1.Text="";
			dateTimePicker1.Text="";
			
		}
		//BOTON GUARDAR AQUI ES DONDE SE GENERA EL RFC CON LAS PRIMERAS DOS LETRAS DEL APELLIDO PATERNO UNA DEL APELLIDO MATERNO 
		//LA PRIMERA DE EL NOMBRE CON LA FECHA DE NACIMIENTO EMPEZANDO POR EL AÑO,MES Y EL DIA ,POSTERIORMENTE UNA HOMOCLAVE DE 3 DIGITOS
		void Button2Click(object sender, EventArgs e)
		{
			string nombre=textBox1.Text;
            string apellido1=textBox2.Text;
            string apellido2=textBox3.Text;
            string telefono=textBox5.Text;
            string direccion=textBox4.Text;
            string semestre=comboBox1.SelectedItem.ToString();
            DateTime fechaNacimiento=dateTimePicker1.Value;
			//ESTO SE UTILIZA PARA LA HOMOCLAVE TENGA NUMEROS RANDOM 
             Random random=new Random();
             string h =random.Next(100000, 999999).ToString("D6");
             //AQUI SE CUENTAN LOS DIGITOS Y AL FINAL SE IMPRIME EN EL LABEL
            string rfc = apellido1.Substring(0, 2)+apellido2.Substring(0, 1)+nombre.Substring(0, 1)+
            fechaNacimiento.ToString("yyMMdd")+h.Substring(0,3);
             
             
             RFC Forms2=new RFC();
             if(rfc==rfc)
             {
             	Forms2.Show();
             	MessageBox.Show( "RFC: " + rfc+" "+
             "NOMBRE COMPLETO: "+nombre+" "+apellido1+" "+apellido2);
             }
             else {
             	MessageBox.Show("ERROR");
             	
             }
        }
	}
}
