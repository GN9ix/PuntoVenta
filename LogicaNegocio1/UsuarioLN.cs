using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace LogicaNegocio
{
    public class UsuarioLN
    {
        UsuarioDAO dao = new UsuarioDAO();

        public void CrearUsuario(string usuario, string pass)
        {
            dao.InsertarUsuario(usuario, pass);
        }

        public bool Login(string usuario, string pass)
        {
            return dao.ValidarUsuario(usuario, pass);
        }
    }
}