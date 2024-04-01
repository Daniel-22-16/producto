
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
                // Establecer la conexi�n con la base de datos
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

                    // Cerrar el lector y la conexi�n
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepci�n que pueda ocurrir durante la conexi�n o consulta
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmaci�n al usuario
            DialogResult result = MessageBox.Show("�Est�s seguro de que deseas cancelar el pedido?", "Confirmar cancelaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Aqu� ir�a el c�digo para cancelar el pedido
                // Por ejemplo, puedes cerrar el formulario despu�s de cancelar el pedido
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmaci�n al usuario
            MessageBox.Show("�Guardado Exitosamente!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de marcas de camisas (supongamos que tenemos una lista predefinida)
            List<string> marcasCamisas = ObtenerMarcasCamisas();

            // Agregar las opciones de marcas de camisas al men� desplegable
            foreach (string marca in marcasCamisas)
            {
                ToolStripMenuItem opcionMarca = new ToolStripMenuItem(marca);
                opcionMarca.Click += OpcionMarca_Click;
                menu.Items.Add(opcionMarca);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button3, 0, button3.Height);
        }

        private void OpcionMarca_Click(object sender, EventArgs e)
        {
            // Obtener la marca seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string marcaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones seg�n la marca seleccionada
            MessageBox.Show("Has seleccionado la marca de camisas: " + marcaSeleccionada);
        }

        // M�todo ficticio para obtener la lista de marcas de camisas
        private List<string> ObtenerMarcasCamisas()
        {
            // Aqu� podr�as obtener la lista de marcas de camisas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� una lista predefinida de marcas como ejemplo
            List<string> marcas = new List<string> { "Tommy Hilfiger", "Lacoste", "Armani Exchange" };
            return marcas;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de marcas de sudaderas (supongamos que tenemos una lista predefinida)
            List<string> marcasSudaderas = ObtenerMarcasSudaderas();

            // Agregar las opciones de marcas de sudaderas al men� desplegable
            foreach (string marca in marcasSudaderas)
            {
                ToolStripMenuItem opcionMarca = new ToolStripMenuItem(marca);
                opcionMarca.Click += OpcionMarcaSudadera_Click;
                menu.Items.Add(opcionMarca);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button6, 0, button6.Height);
        }

        private void OpcionMarcaSudadera_Click(object sender, EventArgs e)
        {
            // Obtener la marca seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string marcaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones seg�n la marca seleccionada
            MessageBox.Show("Has seleccionado la marca de sudaderas: " + marcaSeleccionada);
        }

        // M�todo ficticio para obtener la lista de marcas de sudaderas
        private List<string> ObtenerMarcasSudaderas()
        {
            // Aqu� podr�as obtener la lista de marcas de sudaderas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� una lista predefinida de marcas como ejemplo
            List<string> marcas = new List<string> { "Nike", "Adidas", "Puma" };
            return marcas;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de marcas de pantalones (supongamos que tenemos una lista predefinida)
            List<string> marcasPantalones = ObtenerMarcasPantalones();

            // Agregar las opciones de marcas de pantalones al men� desplegable
            foreach (string marca in marcasPantalones)
            {
                ToolStripMenuItem opcionMarca = new ToolStripMenuItem(marca);
                opcionMarca.Click += OpcionMarcaPantalon_Click;
                menu.Items.Add(opcionMarca);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button7, 0, button7.Height);
        }

        private void OpcionMarcaPantalon_Click(object sender, EventArgs e)
        {
            // Obtener la marca seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string marcaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones seg�n la marca seleccionada
            MessageBox.Show("Has seleccionado la marca de pantalones: " + marcaSeleccionada);
        }

        // M�todo ficticio para obtener la lista de marcas de pantalones
        private List<string> ObtenerMarcasPantalones()
        {
            // Aqu� podr�as obtener la lista de marcas de pantalones desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� una lista predefinida de marcas como ejemplo
            List<string> marcas = new List<string> { "Levi's", "Wrangler", "Dockers" };
            return marcas;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de marcas de blusas (supongamos que tenemos una lista predefinida)
            List<string> marcasBlusas = ObtenerMarcasBlusas();

            // Agregar las opciones de marcas de blusas al men� desplegable
            foreach (string marca in marcasBlusas)
            {
                ToolStripMenuItem opcionMarca = new ToolStripMenuItem(marca);
                opcionMarca.Click += OpcionMarcaBlusa_Click;
                menu.Items.Add(opcionMarca);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button19, 0, button19.Height);
        }

        private void OpcionMarcaBlusa_Click(object sender, EventArgs e)
        {
            // Obtener la marca seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string marcaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones seg�n la marca seleccionada
            MessageBox.Show("Has seleccionado la marca de blusas: " + marcaSeleccionada);
        }

        // M�todo ficticio para obtener la lista de marcas de blusas
        private List<string> ObtenerMarcasBlusas()
        {
            // Aqu� podr�as obtener la lista de marcas de blusas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� una lista predefinida de marcas como ejemplo
            List<string> marcas = new List<string> { "Zara", "H&M", "Forever 21" };
            return marcas;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de precios de camisas
            Dictionary<string, decimal> preciosCamisas = ObtenerPreciosCamisas();

            // Agregar las opciones de precios de camisas al men� desplegable
            foreach (var precio in preciosCamisas)
            {
                ToolStripMenuItem opcionPrecio = new ToolStripMenuItem($"{precio.Key}: {precio.Value:C}");
                opcionPrecio.Click += OpcionPrecio_Click;
                menu.Items.Add(opcionPrecio);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button10, 0, button10.Height);
        }

        private void OpcionPrecio_Click(object sender, EventArgs e)
        {
            // Obtener el precio seleccionado
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string precioSeleccionado = opcionSeleccionada.Text.Split(':')[0]; // Obtener solo el valor del precio (sin el formato de moneda)

            // Realizar acciones seg�n el precio seleccionado
            MessageBox.Show("Has seleccionado el precio de camisa: " + precioSeleccionado);
        }

        // M�todo ficticio para obtener la lista de precios de camisas
        private Dictionary<string, decimal> ObtenerPreciosCamisas()
        {
            // Aqu� podr�as obtener la lista de precios de camisas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� un diccionario predefinido de precios como ejemplo
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
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de precios de sudaderas
            Dictionary<string, decimal> preciosSudaderas = ObtenerPreciosSudaderas();

            // Agregar las opciones de precios de sudaderas al men� desplegable
            foreach (var precio in preciosSudaderas)
            {
                ToolStripMenuItem opcionPrecio = new ToolStripMenuItem($"{precio.Key}: {precio.Value:C}");
                opcionPrecio.Click += OpcionPrecio_Click;
                menu.Items.Add(opcionPrecio);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button13, 0, button13.Height);
        }

        // M�todo ficticio para obtener la lista de precios de sudaderas
        private Dictionary<string, decimal> ObtenerPreciosSudaderas()
        {
            // Aqu� podr�as obtener la lista de precios de sudaderas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� un diccionario predefinido de precios como ejemplo
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
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de precios de pantalones
            Dictionary<string, decimal> preciosPantalones = ObtenerPreciosPantalones();

            // Agregar las opciones de precios de pantalones al men� desplegable
            foreach (var precio in preciosPantalones)
            {
                ToolStripMenuItem opcionPrecio = new ToolStripMenuItem($"{precio.Key}: {precio.Value:C}");
                opcionPrecio.Click += OpcionPrecio_Click;
                menu.Items.Add(opcionPrecio);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button8, 0, button8.Height);
        }

        // M�todo ficticio para obtener la lista de precios de pantalones
        private Dictionary<string, decimal> ObtenerPreciosPantalones()
        {
            // Aqu� podr�as obtener la lista de precios de pantalones desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� un diccionario predefinido de precios como ejemplo
            Dictionary<string, decimal> precios = new Dictionary<string, decimal>
    {
        { "Pantal�n 1", 50 },
        { "Pantal�n 2", 45 },
        { "Pantal�n 3", 55 }
    };
            return precios;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de precios de blusas
            Dictionary<string, decimal> preciosBlusas = ObtenerPreciosBlusas();

            // Agregar las opciones de precios de blusas al men� desplegable
            foreach (var precio in preciosBlusas)
            {
                ToolStripMenuItem opcionPrecio = new ToolStripMenuItem($"{precio.Key}: {precio.Value:C}");
                opcionPrecio.Click += OpcionPrecio_Click;
                menu.Items.Add(opcionPrecio);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button5, 0, button5.Height);
        }

        // M�todo ficticio para obtener la lista de precios de blusas
        private Dictionary<string, decimal> ObtenerPreciosBlusas()
        {
            // Aqu� podr�as obtener la lista de precios de blusas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� un diccionario predefinido de precios como ejemplo
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
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de tallas
            List<string> tallas = ObtenerTallas();

            // Agregar las opciones de tallas al men� desplegable
            foreach (var talla in tallas)
            {
                ToolStripMenuItem opcionTalla = new ToolStripMenuItem(talla);
                opcionTalla.Click += OpcionTalla_Click; // Aqu� se suscribe al evento
                menu.Items.Add(opcionTalla);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button20, 0, button20.Height);
        }

        // M�todo ficticio para obtener la lista de tallas
        private List<string> ObtenerTallas()
        {
            // Aqu� podr�as obtener la lista de tallas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� una lista predefinida de tallas como ejemplo
            List<string> tallas = new List<string> { "S", "M", "L", "XL" };
            return tallas;
        }

        // Evento de clic para manejar la selecci�n de la talla
        private void OpcionTalla_Click(object sender, EventArgs e)
        {
            // Obtener la talla seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string tallaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones seg�n la talla seleccionada
            MessageBox.Show("Has seleccionado la talla: " + tallaSeleccionada);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de tallas de sudaderas
            List<string> tallasSudaderas = ObtenerTallasSudaderas();

            // Agregar las opciones de tallas al men� desplegable
            foreach (var talla in tallasSudaderas)
            {
                ToolStripMenuItem opcionTalla = new ToolStripMenuItem(talla);
                opcionTalla.Click += OpcionTallaSudadera_Click; // Suscribir al evento de clic
                menu.Items.Add(opcionTalla);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button14, 0, button14.Height);
        }

        // M�todo ficticio para obtener la lista de tallas de sudaderas
        private List<string> ObtenerTallasSudaderas()
        {
            // Aqu� podr�as obtener la lista de tallas de sudaderas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� una lista predefinida de tallas como ejemplo
            List<string> tallas = new List<string> { "S", "M", "L", "XL" };
            return tallas;
        }

        // Evento de clic para manejar la selecci�n de la talla de sudadera
        private void OpcionTallaSudadera_Click(object sender, EventArgs e)
        {
            // Obtener la talla seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string tallaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones seg�n la talla seleccionada
            MessageBox.Show("Has seleccionado la talla de sudadera: " + tallaSeleccionada);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de tallas de pantalones
            List<string> tallasPantalones = ObtenerTallasPantalones();

            // Agregar las opciones de tallas al men� desplegable
            foreach (var talla in tallasPantalones)
            {
                ToolStripMenuItem opcionTalla = new ToolStripMenuItem(talla);
                opcionTalla.Click += OpcionTallaPantalon_Click; // Suscribir al evento de clic
                menu.Items.Add(opcionTalla);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button12, 0, button12.Height);
        }

        // M�todo ficticio para obtener la lista de tallas de pantalones
        private List<string> ObtenerTallasPantalones()
        {
            // Aqu� podr�as obtener la lista de tallas de pantalones desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� una lista predefinida de tallas como ejemplo
            List<string> tallas = new List<string> { "30", "32", "34", "36" };
            return tallas;
        }

        // Evento de clic para manejar la selecci�n de la talla de pantal�n
        private void OpcionTallaPantalon_Click(object sender, EventArgs e)
        {
            // Obtener la talla seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string tallaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones seg�n la talla seleccionada
            MessageBox.Show("Has seleccionado la talla de pantal�n: " + tallaSeleccionada);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Crear el men� desplegable
            ContextMenuStrip menu = new ContextMenuStrip();

            // Obtener la lista de tallas de blusas
            List<string> tallasBlusas = ObtenerTallasBlusas();

            // Agregar las opciones de tallas al men� desplegable
            foreach (var talla in tallasBlusas)
            {
                ToolStripMenuItem opcionTalla = new ToolStripMenuItem(talla);
                opcionTalla.Click += OpcionTallaBlusa_Click; // Suscribir al evento de clic
                menu.Items.Add(opcionTalla);
            }

            // Mostrar el men� desplegable en la posici�n del bot�n
            menu.Show(button13, 0, button13.Height);
        }

        // M�todo ficticio para obtener la lista de tallas de blusas
        private List<string> ObtenerTallasBlusas()
        {
            // Aqu� podr�as obtener la lista de tallas de blusas desde una base de datos, archivo, etc.
            // Por ahora, simplemente devolver� una lista predefinida de tallas como ejemplo
            List<string> tallas = new List<string> { "S", "M", "L", "XL" };
            return tallas;
        }

        // Evento de clic para manejar la selecci�n de la talla de blusa
        private void OpcionTallaBlusa_Click(object sender, EventArgs e)
        {
            // Obtener la talla seleccionada
            ToolStripMenuItem opcionSeleccionada = (ToolStripMenuItem)sender;
            string tallaSeleccionada = opcionSeleccionada.Text;

            // Realizar acciones seg�n la talla seleccionada
            MessageBox.Show("Has seleccionado la talla de blusa: " + tallaSeleccionada);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de di�logo de entrada para que el usuario ingrese la cantidad de camisas
            string cantidadInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de camisas que desea comprar:", "Cantidad de Camisas", "");

            // Verificar si se ingres� una cantidad
            if (!string.IsNullOrEmpty(cantidadInput))
            {
                // Intentar convertir la entrada a un n�mero entero
                if (int.TryParse(cantidadInput, out int cantidad))
                {
                    // Realizar acciones con la cantidad ingresada (por ejemplo, mostrarla en un MessageBox)
                    MessageBox.Show("Has ingresado " + cantidad + " camisas.", "Cantidad Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar un mensaje de error si la entrada no es v�lida
                    MessageBox.Show("Por favor, ingrese una cantidad v�lida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje si no se ingres� ninguna cantidad
                MessageBox.Show("No se ha ingresado ninguna cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de di�logo de entrada para que el usuario ingrese la cantidad de sudaderas
            string cantidadInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de sudaderas que desea comprar:", "Cantidad de Sudaderas", "");

            // Verificar si se ingres� una cantidad
            if (!string.IsNullOrEmpty(cantidadInput))
            {
                // Intentar convertir la entrada a un n�mero entero
                if (int.TryParse(cantidadInput, out int cantidad))
                {
                    // Realizar acciones con la cantidad ingresada (por ejemplo, mostrarla en un MessageBox)
                    MessageBox.Show("Has ingresado " + cantidad + " sudaderas.", "Cantidad Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar un mensaje de error si la entrada no es v�lida
                    MessageBox.Show("Por favor, ingrese una cantidad v�lida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje si no se ingres� ninguna cantidad
                MessageBox.Show("No se ha ingresado ninguna cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de di�logo de entrada para que el usuario ingrese la cantidad de pantalones que desea comprar
            string cantidadInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de pantalones que desea comprar:", "Cantidad de Pantalones", "");

            // Verificar si se ingres� una cantidad
            if (!string.IsNullOrEmpty(cantidadInput))
            {
                // Intentar convertir la entrada a un n�mero entero
                if (int.TryParse(cantidadInput, out int cantidad))
                {
                    // Realizar acciones con la cantidad ingresada (por ejemplo, mostrarla en un MessageBox)
                    MessageBox.Show("Has ingresado " + cantidad + " pantalones.", "Cantidad Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar un mensaje de error si la entrada no es v�lida
                    MessageBox.Show("Por favor, ingrese una cantidad v�lida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje si no se ingres� ninguna cantidad
                MessageBox.Show("No se ha ingresado ninguna cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de di�logo de entrada para que el usuario ingrese la cantidad de blusas que desea comprar
            string cantidadInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de blusas que desea comprar:", "Cantidad de Blusas", "");

            // Verificar si se ingres� una cantidad
            if (!string.IsNullOrEmpty(cantidadInput))
            {
                // Intentar convertir la entrada a un n�mero entero
                if (int.TryParse(cantidadInput, out int cantidad))
                {
                    // Realizar acciones con la cantidad ingresada (por ejemplo, mostrarla en un MessageBox)
                    MessageBox.Show("Has ingresado " + cantidad + " blusas.", "Cantidad Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar un mensaje de error si la entrada no es v�lida
                    MessageBox.Show("Por favor, ingrese una cantidad v�lida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje si no se ingres� ninguna cantidad
                MessageBox.Show("No se ha ingresado ninguna cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Obtener la descripci�n ingresada por el usuario
            string descripcion = textBox3.Text;

            // Puedes realizar acciones seg�n la descripci�n ingresada
            // Por ejemplo, realizar validaciones, mostrar una vista previa, etc.

            // En este ejemplo, no haremos nada m�s que almacenar la descripci�n.
            // Si deseas hacer algo m�s con la descripci�n, puedes agregar el c�digo aqu�.
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
