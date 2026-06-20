namespace Ejercicio3_Paradigmas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PRODUCTO = new DataGridViewTextBoxColumn();
            ID_CATEGORIA = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            COSTO = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            textBox1 = new TextBox();
            buttonAgregar = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 33);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, PRODUCTO, ID_CATEGORIA, PRECIO, CANTIDAD, COSTO });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(980, 395);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // PRODUCTO
            // 
            PRODUCTO.DataPropertyName = "producto";
            PRODUCTO.HeaderText = "PRODUCTO";
            PRODUCTO.MinimumWidth = 6;
            PRODUCTO.Name = "PRODUCTO";
            PRODUCTO.Width = 125;
            // 
            // ID_CATEGORIA
            // 
            ID_CATEGORIA.DataPropertyName = "id_categoria";
            ID_CATEGORIA.HeaderText = "CATEGORIA";
            ID_CATEGORIA.MinimumWidth = 6;
            ID_CATEGORIA.Name = "ID_CATEGORIA";
            ID_CATEGORIA.Width = 125;
            // 
            // PRECIO
            // 
            PRECIO.DataPropertyName = "precio";
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 6;
            PRECIO.Name = "PRECIO";
            PRECIO.Width = 125;
            // 
            // CANTIDAD
            // 
            CANTIDAD.DataPropertyName = "cantidad";
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.MinimumWidth = 6;
            CANTIDAD.Name = "CANTIDAD";
            CANTIDAD.Width = 125;
            // 
            // COSTO
            // 
            COSTO.DataPropertyName = "costo";
            COSTO.HeaderText = "COSTO";
            COSTO.MinimumWidth = 6;
            COSTO.Name = "COSTO";
            COSTO.Width = 125;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(numericUpDown1);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(buttonAgregar);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.RightToLeft = RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(980, 500);
            splitContainer1.SplitterDistance = 101;
            splitContainer1.TabIndex = 2;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 2;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(187, 33);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(94, 29);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(623, 36);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 500);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PRODUCTO;
        private DataGridViewTextBoxColumn ID_CATEGORIA;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn COSTO;
        private Button buttonAgregar;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
    }
}
