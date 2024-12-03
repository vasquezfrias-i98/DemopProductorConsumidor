using System.Windows.Forms;

namespace DemopProductorConsumidor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            Pedidos nuevopedido = new Pedidos(

                ContadorId++,
                TxtNombresCliente.Text,
                TxtDescripcionPedido.Text
                );

            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaPedido.Agregar(nuevopedido);
                }
                );
            TxtNombresCliente.Clear();
            TxtDescripcionPedido.Clear();
        }

        private void DgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            private void BtnProcesar_Click(object sender, EventArgs e)
            {
                Thread hiloconsumidor = new Thread(ProcesarPedido);
                hiloconsumidor.Start();
            }
            private void ProcesarPedido()
            {
                Pedido pedido = colaPedido.Extraer();
                AgregarPedidoADataGrid(pedido);

            }
            private void AgregarPedidoADataGrid(Pedido pedido)
            {
                if (DgvPedidos.InvokeRequired)
                {
                    DgvPedidos.Invoke(new Action(() =>
                    {
                        DgvPedidos.Rows.Add(
                            pedido.IdCliente, pedido.NombreCliente,
                            pedido.DescripcionPedido,
                            pedido.FechaCreacion
                            );
                    })
                    );
                }
                else
                {
                    DgvPedidos.Rows.Add(
                        pedido.IdCliente, pedido.NombreCliente,
                        pedido.DescripcionPedido,
                        pedido.FechaPedido
                        );
                }
            }
        }

        private void BtnPreocesar_Click(object sender, EventArgs e)
        {
                Thread hiloconsumidor = new Thread(ProcesarPedido);
                hiloconsumidor.Start();
            }
            private void ProcesarPedido()
            {
                Pedido pedido = colaPedido.Extraer();
                AgregarPedidoADataGrid(pedido);

            }
            private void AgregarPedidoADataGrid(Pedido pedido)
            {
                if (DgvPedidos.InvokeRequired)
                {
                    DgvPedidos.Invoke(new Action(() =>
                    {
                        DgvPedidos.Rows.Add(
                            pedido.IdCliente, pedido.NombreCliente,
                            pedido.DescipcionPedido,
                            pedido.FechaCreacion
                            );
                    })
                    );
                }
                else
                {
                    DgvPedidos.Rows.Add(
                        pedido.IdCliente, pedido.NombreCliente,
                        pedido.DescripcionPedido,
                        pedido.FechaCreacion
                        );
                }
            }
        }
    }
