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
                MessageBox.Show("Movimiento Fallido");
            }
            else if (error is WrongUserType)
            {
                MessageBox.Show("Usuario Invalido");
            }
            else if (error is AlreadyExists)
            {
                MessageBox.Show("Ya existe");
            }
            else if (error is DoesNotExist)
            {
                MessageBox.Show("No existe");
            }
            else if (error is InventoryCreation)
            {
                MessageBox.Show("Error al crear inventario");
            }
            else if (error is WrongDataType)
            {
                MessageBox.Show("Tipo de data invalido");
            }
            else if (error is NoPermit)
            {
                MessageBox.Show("No tiene permiso para realizar este movimiento");
            }
            else
            {
                MessageBox.Show("Error Desconocido");
            }
        }
    }
}
