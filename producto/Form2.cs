using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace producto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // Obtener el ID ingresado por el usuario
            string id = textBox9.Text;

            // Aquí puedes realizar la lógica para guardar el ID
            // Por ejemplo, puedes llamar a un método para guardar el ID en una base de datos
            GuardarIDEnBaseDeDatos(id);

            // No mostramos ningún mensaje en este caso
            // textBox9.Clear(); // Opcional: Limpiar el TextBox después de guardar el ID
        }

        // Método ficticio para guardar el ID en una base de datos
        private void GuardarIDEnBaseDeDatos(string id)
        {
            // Aquí iría la lógica para guardar el ID en una base de datos
            // Por ahora, simplemente imprimiré el ID en la consola como ejemplo
            Console.WriteLine("ID guardado en la base de datos: " + id);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // Tu código aquí para manejar el evento de cambio de texto del textBox7
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Agregar las empresas al ComboBox
            comboBox1.Items.Add("Puma");
            comboBox1.Items.Add("Adidas");
            comboBox1.Items.Add("Nike");
            comboBox1.Items.Add("Lacoste");
            comboBox1.Items.Add("Tommy Hilfiger");
            comboBox1.Items.Add("Armani Exchange");
            comboBox1.Items.Add("Levi's");
            comboBox1.Items.Add("Dockers");
            comboBox1.Items.Add("Wrangler");
            comboBox1.Items.Add("Zara");
            comboBox1.Items.Add("H&M");
            comboBox1.Items.Add("Forever 21");

            // Agregar tipos de pago al ComboBox
            comboBox2.Items.Add("Efectivo");
            comboBox2.Items.Add("Tarjeta de crédito");
            comboBox2.Items.Add("Transferencia bancaria");
            comboBox2.Items.Add("Cheque");
            comboBox2.Items.Add("Pago móvil");
            comboBox2.Items.Add("Criptomoneda");

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la empresa seleccionada
            string empresaSeleccionada = comboBox1.SelectedItem.ToString();

            // Realizar acciones según la empresa seleccionada
            MessageBox.Show("Has seleccionado la empresa: " + empresaSeleccionada);
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el tipo de pago seleccionado
            string tipoPagoSeleccionado = comboBox2.SelectedItem.ToString();

            // Realizar acciones según el tipo de pago seleccionado
            MessageBox.Show("Has seleccionado el tipo de pago: " + tipoPagoSeleccionado);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // No hacemos nada mientras el usuario sigue escribiendo
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            // El usuario ha terminado de escribir su nombre completo
            string nombreCompleto = textBox5.Text;

            // Mostrar un MessageBox con el nombre completo
            MessageBox.Show("¡Hola, " + nombreCompleto + "! Bienvenido/a.", "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // No hacemos nada mientras el usuario sigue escribiendo
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            // El usuario ha terminado de escribir su correo electrónico
            string correoElectronico = textBox6.Text;

            // Aquí puedes realizar validaciones adicionales sobre el correo electrónico ingresado
            // Por ejemplo, verificar si tiene un formato válido

            // Puedes también realizar otras acciones según el correo electrónico ingresado
            // Por ejemplo, mostrar un mensaje de éxito o error, o habilitar/deshabilitar otros controles

            // En este ejemplo, simplemente mostraremos el correo electrónico ingresado en un MessageBox
            MessageBox.Show("Correo electrónico ingresado: " + correoElectronico, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // No hacemos nada mientras el usuario sigue escribiendo
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            // El usuario ha terminado de escribir su número de teléfono
            string telefono = textBox2.Text;

            // Aquí puedes realizar validaciones adicionales sobre el número de teléfono ingresado
            // Por ejemplo, verificar si tiene el formato correcto, longitud adecuada, etc.

            // Puedes también realizar otras acciones según el número de teléfono ingresado
            // Por ejemplo, mostrar un mensaje de éxito o error, o habilitar/deshabilitar otros controles

            // En este ejemplo, simplemente mostraremos el número de teléfono ingresado en un MessageBox
            MessageBox.Show("Número de teléfono ingresado: " + telefono, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // No hacemos nada mientras el usuario sigue escribiendo
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            // El usuario ha terminado de escribir su dirección
            string direccion = textBox8.Text;

            // Aquí puedes realizar validaciones adicionales sobre la dirección ingresada
            // Por ejemplo, verificar si está en un formato válido, longitud adecuada, etc.

            // Puedes también realizar otras acciones según la dirección ingresada
            // Por ejemplo, mostrar un mensaje de éxito o error, o habilitar/deshabilitar otros controles

            // En este ejemplo, simplemente mostraremos la dirección ingresada en un MessageBox
            MessageBox.Show("Dirección ingresada: " + direccion, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Aquí puedes escribir la lógica para guardar la información ingresada por el usuario

            // Por ejemplo, obtener los valores de los controles
            string nombre = textBox5.Text;
            string direccion = textBox8.Text;
            string correoElectronico = textBox6.Text;
            string telefono = textBox2.Text;
            string tipoPagoSeleccionado = comboBox2.SelectedItem?.ToString();

            // Validar los datos ingresados (formato, longitud, etc.)
            bool datosValidos = ValidarDatos(nombre, direccion, correoElectronico, telefono, tipoPagoSeleccionado);

            if (datosValidos)
            {
                // Aquí puedes llamar a un método para guardar los datos en una base de datos, archivo, etc.
                // GuardarDatos(nombre, direccion, correoElectronico, telefono, tipoPagoSeleccionado);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mostrar un mensaje de error si los datos no son válidos
                MessageBox.Show("Por favor, ingrese datos válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para validar los datos ingresados por el usuario
        private bool ValidarDatos(string nombre, string direccion, string correoElectronico, string telefono, string tipoPago)
        {
            // Aquí puedes implementar tus reglas de validación
            // Por ejemplo, verificar si los campos no están vacíos y tienen un formato válido

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(correoElectronico) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(tipoPago))
            {
                return false;
            }

            // Aquí podrías agregar más validaciones, como comprobar el formato del correo electrónico o del teléfono

            return true;
        }
    }
}
