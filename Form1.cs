using Dapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio3_Paradigmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cadena = "workstation id=empresa2.mssql.somee.com;packet size=4096;user id=danielavf_SQLLogin_1;pwd=DaniEmpresa2026;data source=empresa2.mssql.somee.com;persist security info=False;initial catalog=empresa2;TrustServerCertificate=True";
            string sql_c = "select * from CATEGORIAS";

            using (var con = new Microsoft.Data.SqlClient.SqlConnection(cadena))
            {
                con.Open();
                this.comboBox2.DataSource = con.Query<P.M_CATEGORIA>(sql_c).ToList();
                this.comboBox2.ValueMember = "id";
                this.comboBox2.DisplayMember = "categoria";
            }


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        //BOTON CARGAR
        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = "workstation id=empresa2.mssql.somee.com;packet size=4096;user id=danielavf_SQLLogin_1;pwd=DaniEmpresa2026;data source=empresa2.mssql.somee.com;persist security info=False;initial catalog=empresa2;TrustServerCertificate=True";
            string sql = "select * from PRODUCTOS";
            string sql_c = "select * from CATEGORIAS";

            using (var con = new Microsoft.Data.SqlClient.SqlConnection(cadena))
            {
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).DataSource = con.Query<P.M_CATEGORIA>(sql_c).ToList();
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).ValueMember = "id";
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).DisplayMember = "categoria";
                this.dataGridView1.DataSource = con.Query<P.M_PRODUCTO>(sql).ToList();

            }

        }

        //BOTON AGREGAR
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            P.M_PRODUCTO prod = new P.M_PRODUCTO();
            prod.producto = this.textBox1.Text;
            prod.cantidad = Convert.ToDouble(this.numericUpDown1.Value.ToString());
            prod.id_categoria = Convert.ToInt32(this.comboBox2.SelectedValue);

            string cadena = "workstation id=empresa2.mssql.somee.com;packet size=4096;user id=danielavf_SQLLogin_1;pwd=DaniEmpresa2026;data source=empresa2.mssql.somee.com;persist security info=False;initial catalog=empresa2;TrustServerCertificate=True";
            string sql = @"insert into
                PRODUCTOS(PRODUCTO, ID_CATEGORIA, PRECIO, CANTIDAD, COSTO)
                VALUES(@PRODUCTO,@ID_CATEGORIA, 25, @CANTIDAD, 20)";
            string sql2 = "select * from PRODUCTOS";
            string sql_c = "select * from CATEGORIAS";


            using (var con = new Microsoft.Data.SqlClient.SqlConnection(cadena))
            {
                con.Open();
                con.Execute(sql, prod);
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).DataSource = con.Query<P.M_CATEGORIA>(sql_c).ToList();
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).ValueMember = "id";
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).DisplayMember = "categoria";
                this.dataGridView1.DataSource = con.Query<P.M_PRODUCTO>(sql2).ToList();

                con.Close();

                this.textBox1.Clear();
                this.numericUpDown1.Value = 0;
                this.comboBox2.SelectedIndex = 0;
            }


        }

        //BOTON ELIMINAR
        private void button2_Click(object sender, EventArgs e)
        {
            int r = this.dataGridView1.CurrentRow.Index;
            P.M_PRODUCTO p = new P.M_PRODUCTO();
            p.id = Convert.ToInt32(this.dataGridView1.Rows[r].Cells[0].Value.ToString());

            string cadena = "workstation id=empresa2.mssql.somee.com;packet size=4096;user id=danielavf_SQLLogin_1;pwd=DaniEmpresa2026;data source=empresa2.mssql.somee.com;persist security info=False;initial catalog=empresa2;TrustServerCertificate=True";
            string sql_b = @"
                           delete from PRODUCTOS
                           where id=@id";

            string sql = "select * from PRODUCTOS";
            string sql_c = "select * from CATEGORIAS";
            using (var con = new Microsoft.Data.SqlClient.SqlConnection(cadena))
            {
                con.Open();
                con.Execute(sql_b, p);
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).DataSource = con.Query<P.M_CATEGORIA>(sql_c).ToList();
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).ValueMember = "id";
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).DisplayMember = "categoria";
                this.dataGridView1.DataSource = con.Query<P.M_PRODUCTO>(sql).ToList();
            }
        }

        //BOTON MODIFICAR
        private void button3_Click(object sender, EventArgs e)
        {
            int r = this.dataGridView1.CurrentRow.Index;
            P.M_PRODUCTO p = new P.M_PRODUCTO();
            p.id = Convert.ToInt32(this.dataGridView1.Rows[r].Cells[0].Value.ToString());
            p.producto = this.textBox1.Text;
            p.precio = Convert.ToDouble(this.numericUpDown1.Value.ToString());
            p.cantidad = Convert.ToDouble(this.dataGridView1.Rows[r].Cells[4].Value.ToString());
            p.costo = Convert.ToDouble(this.dataGridView1.Rows[r].Cells[5].Value.ToString());
            p.id_categoria = Convert.ToInt32(this.comboBox2.SelectedValue);

            string cadena = "workstation id=empresa2.mssql.somee.com;packet size=4096;user id=danielavf_SQLLogin_1;pwd=DaniEmpresa2026;data source=empresa2.mssql.somee.com;persist security info=False;initial catalog=empresa2;TrustServerCertificate=True";
            string sql_b = @"update PRODUCTOS set
                             PRODUCTO=@producto,
                             ID_CATEGORIA=@id_categoria,
                             PRECIO=@precio,
                             CANTIDAD=@cantidad,
                             COSTO=@costo
                             where id=@id";

            string sql = "select * from PRODUCTOS";
            string sql_c = "select * from CATEGORIAS";
            using (var con = new Microsoft.Data.SqlClient.SqlConnection(cadena))
            {
                con.Open();
                con.Execute(sql_b, p);
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).DataSource = con.Query<P.M_CATEGORIA>(sql_c).ToList();
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).ValueMember = "id";
                ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[2]).DisplayMember = "categoria";
                this.dataGridView1.DataSource = con.Query<P.M_PRODUCTO>(sql).ToList();
                this.textBox1.Clear();
                this.numericUpDown1.Value = 0;
                this.comboBox2.SelectedIndex = 0;
            }


        }

        //Context del Modificar
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int r = this.dataGridView1.CurrentRow.Index;
            this.textBox1.Text = this.dataGridView1.Rows[r].Cells[1].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(this.dataGridView1.Rows[r].Cells[3].Value.ToString());
        }
    }
}

