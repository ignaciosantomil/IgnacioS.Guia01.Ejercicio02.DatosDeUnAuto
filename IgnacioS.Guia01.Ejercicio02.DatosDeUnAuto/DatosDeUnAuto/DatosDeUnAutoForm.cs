using IgnacioS.Guia01.Ejercicio02.DatosDeUnAuto.DatosDeUnAuto;

namespace IgnacioS.Guia01.Ejercicio02.DatosDeUnAuto
{
    public partial class DatosDeUnAutoForm : Form
    {
        public DatosDeUnAutoForm()
        {
            InitializeComponent();
        }
        private DatosDeUnAutoModel modelo = new();
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var auto = new Auto();

            auto.Marca = cmbMarca.TabIndex;
            auto.Modelo = txtModelo.Text;
            if(!int.TryParse(txtAnio.Text,out int anio))
            {
                MessageBox.Show("El año debe ser un valor numérico");
                return;
            }
            auto.Anio = anio;

            if(!int.TryParse(txtPrecio.Text, out int precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico");
                return;
            }
            auto.Precio = precio;
            var error = modelo.IngresarAuto(auto);
            if(error = null)
            {
                MessageBox.Show("El auto fue agregado correctamente");
            }
            else
            {
                MessageBox.Show(error);
            }

        }
    }
}
