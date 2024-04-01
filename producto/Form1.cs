
using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace producto
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(localdb)\\daniel2216;Initial Catalog=Tiendita;Integrated Security=True";

       
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 proveedorFrom = new Form2();
            proveedorFrom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer la conexión con la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Ejecutar una consulta SQL
                    string query = "SELECT * FROM Camisas";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Leer los resultados de la consulta
                    while (reader.Read())
                    {
                        // Obtener los valores de las columnas y hacer algo con ellos
                        int camisaID = reader.GetInt32(0);
                        string marca = reader.GetString(1);
                        decimal precio = reader.GetDecimal(2);
                        string talla = reader.GetString(3);

                        // Por ejemplo, mostrar los valores en un MessageBox
                        MessageBox.Show($"ID: {camisaID}, Marca: {marca}, Precio: {precio}, Talla: {talla}");
                    }

                    // Cerrar el lector y la conexión
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la conexión o consulta
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación al usuario
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cancelar el pedido?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Aquí iría el código para cancelar el pedido
                // Por ejemplo, puedes cerrar el formulario después de cancelar el pedido
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación al usuario
            MessageBox.Show("¡Guardado Exitosamente!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de marcas de camisas (supongamos que tenemos una lista predefinida)
            List<string> marcasCamisas = ObtenerMarcasCamisas();

            // Agregar las opciones de marcas de camisas al menú desplegable
            foreach (string marca in marcasCamisas)
            {
                ToolStripMenuItem opcionMarca = new ToolStripMenuItem(marca);
                opcionMarca.Click += OpcionMarca_Click;
                menu.Items.Add(opcionMarca);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button3, 0, button3.Height);
        }

        private void OpcionMarca_Click(object sender, EventArgs e)
        {
            // Obtener la marca seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string marcaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones según la marca seleccionada
            MessageBox.Show("Has seleccionado la marca de camisas: " + marcaSeleccionada);
        }

        // Método ficticio para obtener la lista de marcas de camisas
        private List<string> ObtenerMarcasCamisas()
        {
            // Aquí podrías obtener la lista de marcas de camisas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré una lista predefinida de marcas como ejemplo
            List<string> marcas = new List<string> { "Tommy Hilfiger", "Lacoste", "Armani Exchange" };
            return marcas;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de marcas de sudaderas (supongamos que tenemos una lista predefinida)
            List<string> marcasSudaderas = ObtenerMarcasSudaderas();

            // Agregar las opciones de marcas de sudaderas al menú desplegable
            foreach (string marca in marcasSudaderas)
            {
                ToolStripMenuItem opcionMarca = new ToolStripMenuItem(marca);
                opcionMarca.Click += OpcionMarcaSudadera_Click;
                menu.Items.Add(opcionMarca);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button6, 0, button6.Height);
        }

        private void OpcionMarcaSudadera_Click(object sender, EventArgs e)
        {
            // Obtener la marca seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string marcaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones según la marca seleccionada
            MessageBox.Show("Has seleccionado la marca de sudaderas: " + marcaSeleccionada);
        }

        // Método ficticio para obtener la lista de marcas de sudaderas
        private List<string> ObtenerMarcasSudaderas()
        {
            // Aquí podrías obtener la lista de marcas de sudaderas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré una lista predefinida de marcas como ejemplo
            List<string> marcas = new List<string> { "Nike", "Adidas", "Puma" };
            return marcas;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de marcas de pantalones (supongamos que tenemos una lista predefinida)
            List<string> marcasPantalones = ObtenerMarcasPantalones();

            // Agregar las opciones de marcas de pantalones al menú desplegable
            foreach (string marca in marcasPantalones)
            {
                ToolStripMenuItem opcionMarca = new ToolStripMenuItem(marca);
                opcionMarca.Click += OpcionMarcaPantalon_Click;
                menu.Items.Add(opcionMarca);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button7, 0, button7.Height);
        }

        private void OpcionMarcaPantalon_Click(object sender, EventArgs e)
        {
            // Obtener la marca seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string marcaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones según la marca seleccionada
            MessageBox.Show("Has seleccionado la marca de pantalones: " + marcaSeleccionada);
        }

        // Método ficticio para obtener la lista de marcas de pantalones
        private List<string> ObtenerMarcasPantalones()
        {
            // Aquí podrías obtener la lista de marcas de pantalones desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré una lista predefinida de marcas como ejemplo
            List<string> marcas = new List<string> { "Levi's", "Wrangler", "Dockers" };
            return marcas;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de marcas de blusas (supongamos que tenemos una lista predefinida)
            List<string> marcasBlusas = ObtenerMarcasBlusas();

            // Agregar las opciones de marcas de blusas al menú desplegable
            foreach (string marca in marcasBlusas)
            {
                ToolStripMenuItem opcionMarca = new ToolStripMenuItem(marca);
                opcionMarca.Click += OpcionMarcaBlusa_Click;
                menu.Items.Add(opcionMarca);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button19, 0, button19.Height);
        }

        private void OpcionMarcaBlusa_Click(object sender, EventArgs e)
        {
            // Obtener la marca seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string marcaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones según la marca seleccionada
            MessageBox.Show("Has seleccionado la marca de blusas: " + marcaSeleccionada);
        }

        // Método ficticio para obtener la lista de marcas de blusas
        private List<string> ObtenerMarcasBlusas()
        {
            // Aquí podrías obtener la lista de marcas de blusas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré una lista predefinida de marcas como ejemplo
            List<string> marcas = new List<string> { "Zara", "H&M", "Forever 21" };
            return marcas;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de precios de camisas
            Dictionary<string, decimal> preciosCamisas = ObtenerPreciosCamisas();

            // Agregar las opciones de precios de camisas al menú desplegable
            foreach (var precio in preciosCamisas)
            {
                ToolStripMenuItem opcionPrecio = new ToolStripMenuItem($"{precio.Key}: {precio.Value:C}");
                opcionPrecio.Click += OpcionPrecio_Click;
                menu.Items.Add(opcionPrecio);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button10, 0, button10.Height);
        }

        private void OpcionPrecio_Click(object sender, EventArgs e)
        {
            // Obtener el precio seleccionado
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string precioSeleccionado = opcionSeleccionada.Text.Split(':')[0]; // Obtener solo el valor del precio (sin el formato de moneda)

            // Realizar acciones según el precio seleccionado
            MessageBox.Show("Has seleccionado el precio de camisa: " + precioSeleccionado);
        }

        // Método ficticio para obtener la lista de precios de camisas
        private Dictionary<string, decimal> ObtenerPreciosCamisas()
        {
            // Aquí podrías obtener la lista de precios de camisas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré un diccionario predefinido de precios como ejemplo
            Dictionary<string, decimal> precios = new Dictionary<string, decimal>
    {
        { "Camisa 1", 30 },
        { "Camisa 2", 25 },
        { "Camisa 3", 35 }
    };
            return precios;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de precios de sudaderas
            Dictionary<string, decimal> preciosSudaderas = ObtenerPreciosSudaderas();

            // Agregar las opciones de precios de sudaderas al menú desplegable
            foreach (var precio in preciosSudaderas)
            {
                ToolStripMenuItem opcionPrecio = new ToolStripMenuItem($"{precio.Key}: {precio.Value:C}");
                opcionPrecio.Click += OpcionPrecio_Click;
                menu.Items.Add(opcionPrecio);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button13, 0, button13.Height);
        }

        // Método ficticio para obtener la lista de precios de sudaderas
        private Dictionary<string, decimal> ObtenerPreciosSudaderas()
        {
            // Aquí podrías obtener la lista de precios de sudaderas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré un diccionario predefinido de precios como ejemplo
            Dictionary<string, decimal> precios = new Dictionary<string, decimal>
    {
        { "Sudadera 1", 40 },
        { "Sudadera 2", 35 },
        { "Sudadera 3", 45 }
    };
            return precios;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de precios de pantalones
            Dictionary<string, decimal> preciosPantalones = ObtenerPreciosPantalones();

            // Agregar las opciones de precios de pantalones al menú desplegable
            foreach (var precio in preciosPantalones)
            {
                ToolStripMenuItem opcionPrecio = new ToolStripMenuItem($"{precio.Key}: {precio.Value:C}");
                opcionPrecio.Click += OpcionPrecio_Click;
                menu.Items.Add(opcionPrecio);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button8, 0, button8.Height);
        }

        // Método ficticio para obtener la lista de precios de pantalones
        private Dictionary<string, decimal> ObtenerPreciosPantalones()
        {
            // Aquí podrías obtener la lista de precios de pantalones desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré un diccionario predefinido de precios como ejemplo
            Dictionary<string, decimal> precios = new Dictionary<string, decimal>
    {
        { "Pantalón 1", 50 },
        { "Pantalón 2", 45 },
        { "Pantalón 3", 55 }
    };
            return precios;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de precios de blusas
            Dictionary<string, decimal> preciosBlusas = ObtenerPreciosBlusas();

            // Agregar las opciones de precios de blusas al menú desplegable
            foreach (var precio in preciosBlusas)
            {
                ToolStripMenuItem opcionPrecio = new ToolStripMenuItem($"{precio.Key}: {precio.Value:C}");
                opcionPrecio.Click += OpcionPrecio_Click;
                menu.Items.Add(opcionPrecio);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button5, 0, button5.Height);
        }

        // Método ficticio para obtener la lista de precios de blusas
        private Dictionary<string, decimal> ObtenerPreciosBlusas()
        {
            // Aquí podrías obtener la lista de precios de blusas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré un diccionario predefinido de precios como ejemplo
            Dictionary<string, decimal> precios = new Dictionary<string, decimal>
    {
        { "Blusa 1", 40 },
        { "Blusa 2", 35 },
        { "Blusa 3", 45 }
    };
            return precios;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de tallas
            List<string> tallas = ObtenerTallas();

            // Agregar las opciones de tallas al menú desplegable
            foreach (var talla in tallas)
            {
                ToolStripMenuItem opcionTalla = new ToolStripMenuItem(talla);
                opcionTalla.Click += OpcionTalla_Click; // Aquí se suscribe al evento
                menu.Items.Add(opcionTalla);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button20, 0, button20.Height);
        }

        // Método ficticio para obtener la lista de tallas
        private List<string> ObtenerTallas()
        {
            // Aquí podrías obtener la lista de tallas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré una lista predefinida de tallas como ejemplo
            List<string> tallas = new List<string> { "S", "M", "L", "XL" };
            return tallas;
        }

        // Evento de clic para manejar la selección de la talla
        private void OpcionTalla_Click(object sender, EventArgs e)
        {
            // Obtener la talla seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string tallaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones según la talla seleccionada
            MessageBox.Show("Has seleccionado la talla: " + tallaSeleccionada);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de tallas de sudaderas
            List<string> tallasSudaderas = ObtenerTallasSudaderas();

            // Agregar las opciones de tallas al menú desplegable
            foreach (var talla in tallasSudaderas)
            {
                ToolStripMenuItem opcionTalla = new ToolStripMenuItem(talla);
                opcionTalla.Click += OpcionTallaSudadera_Click; // Suscribir al evento de clic
                menu.Items.Add(opcionTalla);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button14, 0, button14.Height);
        }

        // Método ficticio para obtener la lista de tallas de sudaderas
        private List<string> ObtenerTallasSudaderas()
        {
            // Aquí podrías obtener la lista de tallas de sudaderas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré una lista predefinida de tallas como ejemplo
            List<string> tallas = new List<string> { "S", "M", "L", "XL" };
            return tallas;
        }

        // Evento de clic para manejar la selección de la talla de sudadera
        private void OpcionTallaSudadera_Click(object sender, EventArgs e)
        {
            // Obtener la talla seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string tallaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones según la talla seleccionada
            MessageBox.Show("Has seleccionado la talla de sudadera: " + tallaSeleccionada);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de tallas de pantalones
            List<string> tallasPantalones = ObtenerTallasPantalones();

            // Agregar las opciones de tallas al menú desplegable
            foreach (var talla in tallasPantalones)
            {
                ToolStripMenuItem opcionTalla = new ToolStripMenuItem(talla);
                opcionTalla.Click += OpcionTallaPantalon_Click; // Suscribir al evento de clic
                menu.Items.Add(opcionTalla);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button12, 0, button12.Height);
        }

        // Método ficticio para obtener la lista de tallas de pantalones
        private List<string> ObtenerTallasPantalones()
        {
            // Aquí podrías obtener la lista de tallas de pantalones desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré una lista predefinida de tallas como ejemplo
            List<string> tallas = new List<string> { "30", "32", "34", "36" };
            return tallas;
        }

        // Evento de clic para manejar la selección de la talla de pantalón
        private void OpcionTallaPantalon_Click(object sender, EventArgs e)
        {
            // Obtener la talla seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string tallaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones según la talla seleccionada
            MessageBox.Show("Has seleccionado la talla de pantalón: " + tallaSeleccionada);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Crear el menú desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de tallas de blusas
            List<string> tallasBlusas = ObtenerTallasBlusas();

            // Agregar las opciones de tallas al menú desplegable
            foreach (var talla in tallasBlusas)
            {
                ToolStripMenuItem opcionTalla = new ToolStripMenuItem(talla);
                opcionTalla.Click += OpcionTallaBlusa_Click; // Suscribir al evento de clic
                menu.Items.Add(opcionTalla);
            }

            // Mostrar el menú desplegable en la posición del botón
            menu.Show(button13, 0, button13.Height);
        }

        // Método ficticio para obtener la lista de tallas de blusas
        private List<string> ObtenerTallasBlusas()
        {
            // Aquí podrías obtener la lista de tallas de blusas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolveré una lista predefinida de tallas como ejemplo
            List<string> tallas = new List<string> { "S", "M", "L", "XL" };
            return tallas;
        }

        // Evento de clic para manejar la selección de la talla de blusa
        private void OpcionTallaBlusa_Click(object sender, EventArgs e)
        {
            // Obtener la talla seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string tallaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones según la talla seleccionada
            MessageBox.Show("Has seleccionado la talla de blusa: " + tallaSeleccionada);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de entrada para que el usuario ingrese la cantidad de camisas
            string cantidadInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de camisas que desea comprar:", "Cantidad de Camisas", "");

            // Verificar si se ingresó una cantidad
            if (!string.IsNullOrEmpty(cantidadInput))
            {
                // Intentar convertir la entrada a un número entero
                if (int.TryParse(cantidadInput, out int cantidad))
                {
                    // Realizar acciones con la cantidad ingresada (por ejemplo, mostrarla en un MessageBox)
                    MessageBox.Show("Has ingresado " + cantidad + " camisas.", "Cantidad Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar un mensaje de error si la entrada no es válida
                    MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje si no se ingresó ninguna cantidad
                MessageBox.Show("No se ha ingresado ninguna cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de entrada para que el usuario ingrese la cantidad de sudaderas
            string cantidadInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de sudaderas que desea comprar:", "Cantidad de Sudaderas", "");

            // Verificar si se ingresó una cantidad
            if (!string.IsNullOrEmpty(cantidadInput))
            {
                // Intentar convertir la entrada a un número entero
                if (int.TryParse(cantidadInput, out int cantidad))
                {
                    // Realizar acciones con la cantidad ingresada (por ejemplo, mostrarla en un MessageBox)
                    MessageBox.Show("Has ingresado " + cantidad + " sudaderas.", "Cantidad Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar un mensaje de error si la entrada no es válida
                    MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje si no se ingresó ninguna cantidad
                MessageBox.Show("No se ha ingresado ninguna cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de entrada para que el usuario ingrese la cantidad de pantalones que desea comprar
            string cantidadInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de pantalones que desea comprar:", "Cantidad de Pantalones", "");

            // Verificar si se ingresó una cantidad
            if (!string.IsNullOrEmpty(cantidadInput))
            {
                // Intentar convertir la entrada a un número entero
                if (int.TryParse(cantidadInput, out int cantidad))
                {
                    // Realizar acciones con la cantidad ingresada (por ejemplo, mostrarla en un MessageBox)
                    MessageBox.Show("Has ingresado " + cantidad + " pantalones.", "Cantidad Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar un mensaje de error si la entrada no es válida
                    MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje si no se ingresó ninguna cantidad
                MessageBox.Show("No se ha ingresado ninguna cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de entrada para que el usuario ingrese la cantidad de blusas que desea comprar
            string cantidadInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de blusas que desea comprar:", "Cantidad de Blusas", "");

            // Verificar si se ingresó una cantidad
            if (!string.IsNullOrEmpty(cantidadInput))
            {
                // Intentar convertir la entrada a un número entero
                if (int.TryParse(cantidadInput, out int cantidad))
                {
                    // Realizar acciones con la cantidad ingresada (por ejemplo, mostrarla en un MessageBox)
                    MessageBox.Show("Has ingresado " + cantidad + " blusas.", "Cantidad Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar un mensaje de error si la entrada no es válida
                    MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje si no se ingresó ninguna cantidad
                MessageBox.Show("No se ha ingresado ninguna cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Obtener la descripción ingresada por el usuario
            string descripcion = textBox3.Text;

            // Puedes realizar acciones según la descripción ingresada
            // Por ejemplo, realizar validaciones, mostrar una vista previa, etc.

            // En este ejemplo, no haremos nada más que almacenar la descripción.
            // Si deseas hacer algo más con la descripción, puedes agregar el código aquí.
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
