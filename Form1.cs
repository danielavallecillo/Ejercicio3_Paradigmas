using Dapper;

namespace Ejercicio3_Paradigmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            using (var con = new Microsoft.Data.SqlClient.SqlConnection(cadena))
            {
                this.dataGridView1.DataSource = con.Query<P.M_PRODUCTO>(sql).ToList();

            }

        }

        //BOTON AGREGAR
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            P.M_PRODUCTO prod = new P.M_PRODUCTO();
            prod.producto = this.textBox1.Text;
            prod.cantidad = Convert.ToDouble(this.numericUpDown1.Value.ToString());

            string cadena = "workstation id=empresa2.mssql.somee.com;packet size=4096;user id=danielavf_SQLLogin_1;pwd=DaniEmpresa2026;data source=empresa2.mssql.somee.com;persist security info=False;initial catalog=empresa2;TrustServerCertificate=True";
            string sql = @"insert into
                PRODUCTOS(PRODUCTO, ID_CATEGORIA, PRECIO, CANTIDAD, COSTO)
                VALUES(@PRODUCTO,1, 25, @CANTIDAD, 20)";
            string sql2 = "select * from PRODUCTOS";


            using (var con = new Microsoft.Data.SqlClient.SqlConnection(cadena))
            {
                con.Open();
                con.Execute(sql, prod);
                this.dataGridView1.DataSource = con.Query<P.M_PRODUCTO>(sql2).ToList();
                con.Close();
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
            using (var con = new Microsoft.Data.SqlClient.SqlConnection(cadena))
            {
                con.Execute(sql_b, p);
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

            string cadena = "workstation id=empresa2.mssql.somee.com;packet size=4096;user id=danielavf_SQLLogin_1;pwd=DaniEmpresa2026;data source=empresa2.mssql.somee.com;persist security info=False;initial catalog=empresa2;TrustServerCertificate=True";
            string sql_b = @"
                           update PRODUCTOS set PRODUCTO=@PRODUCTO, PRECIO=@PRECIO  
                           where id=@id";

            string sql = "select * from PRODUCTOS";
            using (var con = new Microsoft.Data.SqlClient.SqlConnection(cadena))
            {
                con.Execute(sql_b, p);
                this.dataGridView1.DataSource = con.Query<P.M_PRODUCTO>(sql).ToList();
            }


        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int r = this.dataGridView1.CurrentRow.Index;
            this.textBox1.Text = this.dataGridView1.Rows[r].Cells[1].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(this.dataGridView1.Rows[r].Cells[3].Value.ToString());
        }
    }
}

