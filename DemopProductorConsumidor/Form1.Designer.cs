namespace DemopProductorConsumidor
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
            panel1 = new Panel();
            BtnRegistrar = new Button();
            TextDescripcionPedido = new TextBox();
            TxtNombreCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            BtnPreocesar = new Button();
            DgvPedidos = new DataGridView();
            IdCliente = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            DescricionPedido = new DataGridViewTextBoxColumn();
            FechaPedido = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnRegistrar);
            panel1.Controls.Add(TextDescripcionPedido);
            panel1.Controls.Add(TxtNombreCliente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 194);
            panel1.TabIndex = 0;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Location = new Point(203, 153);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(75, 23);
            BtnRegistrar.TabIndex = 5;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = true;
            BtnRegistrar.Click += BtnAsignar_Click;
            // 
            // TextDescripcionPedido
            // 
            TextDescripcionPedido.Location = new Point(17, 124);
            TextDescripcionPedido.Name = "TextDescripcionPedido";
            TextDescripcionPedido.Size = new Size(261, 23);
            TextDescripcionPedido.TabIndex = 4;
            // 
            // TxtNombreCliente
            // 
            TxtNombreCliente.Location = new Point(17, 55);
            TxtNombreCliente.Name = "TxtNombreCliente";
            TxtNombreCliente.RightToLeft = RightToLeft.Yes;
            TxtNombreCliente.ScrollBars = ScrollBars.Both;
            TxtNombreCliente.Size = new Size(261, 23);
            TxtNombreCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 91);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 2;
            label2.Text = "DescripcionPedido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "NombreCliente";
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnPreocesar);
            panel2.Controls.Add(DgvPedidos);
            panel2.Location = new Point(12, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 208);
            panel2.TabIndex = 1;
            // 
            // BtnPreocesar
            // 
            BtnPreocesar.Location = new Point(468, 158);
            BtnPreocesar.Name = "BtnPreocesar";
            BtnPreocesar.Size = new Size(75, 23);
            BtnPreocesar.TabIndex = 1;
            BtnPreocesar.Text = "Procesar";
            BtnPreocesar.UseVisualStyleBackColor = true;
            BtnPreocesar.Click += BtnPreocesar_Click;
            // 
            // DgvPedidos
            // 
            DgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPedidos.Columns.AddRange(new DataGridViewColumn[] { IdCliente, NombreCliente, DescricionPedido, FechaPedido });
            DgvPedidos.Location = new Point(3, 21);
            DgvPedidos.Name = "DgvPedidos";
            DgvPedidos.Size = new Size(459, 160);
            DgvPedidos.TabIndex = 0;
            DgvPedidos.CellContentClick += DgvPedidos_CellContentClick;
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "IdCliente";
            IdCliente.Name = "IdCliente";
            // 
            // NombreCliente
            // 
            NombreCliente.HeaderText = "NombreCliente";
            NombreCliente.Name = "NombreCliente";
            // 
            // DescricionPedido
            // 
            DescricionPedido.HeaderText = "DescripcionPedido";
            DescricionPedido.Name = "DescricionPedido";
            // 
            // FechaPedido
            // 
            FechaPedido.HeaderText = "FechaPedido";
            FechaPedido.Name = "FechaPedido";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 447);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox TextDescripcionPedido;
        private TextBox TxtNombreCliente;
        private Label label2;
        private Button BtnRegistrar;
        private Panel panel2;
        private DataGridView DgvPedidos;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn DescricionPedido;
        private DataGridViewTextBoxColumn FechaPedido;
        private Button BtnPreocesar;
    }
}
