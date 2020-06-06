using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace StOrgPro
{
    public class Message
    {
        public void ShowError(dynamic error)
        {
            if (error is FailedLogin)
            {
                MessageBox.Show("Usuario o Password Invalido");
            }
            else if (error is NoDBConnection)
            {
                MessageBox.Show("No se pude establecer conexion");
            }
            else if (error is FailedToRemove)
            {
                MessageBox.Show("Movimiento Invalido");
            }
            else if (error is WrongUserType)
            {
                MessageBox.Show("Usuario Invalido");
            }
            else
            {
                MessageBox.Show("Error Desconocido");
            }
        }
    }
}
