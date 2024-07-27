using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso object_usuario = new CD_Permiso();
        public List<Permiso> Listar(int IdUsuario)
        {
            return object_usuario.Listar(IdUsuario);
        }

    }
}
