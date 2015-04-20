using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalDBClienteServicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReferenceListarTodosLosUsers.UsersServiceClient client = new ServiceReferenceListarTodosLosUsers.UsersServiceClient();

         
            dataGridView1.DataSource = client.ListarTodosLosUsers();
 
        }
    }
}
