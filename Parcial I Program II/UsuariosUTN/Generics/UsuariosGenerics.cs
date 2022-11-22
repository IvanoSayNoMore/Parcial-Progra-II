using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosUTN.Enums;
using UsuariosUTN.Usuarios;

namespace UsuariosUTN.Generics
{
    public class UsuariosGeneric<T>
        where T : TipoUsuario
    {
        List<T> listElement;
        public UsuariosGeneric()
        {
            listElement = new List<T>();
            // dict = new Dictionary<U, V>();
        }
        public void Add(T elem)
        {
            listElement.Add(elem);

        }
        public List<T> RetornaListaUsuarios(ETiposUsuarios tipo)
        {
            List<T> list = new List<T>();

            foreach (T elem in listElement)
            {
                if(elem.TipoUsuarix == tipo)
                {
                    list.Add(elem);
                }
            }
            return list;

        }

        public static implicit operator UsuariosGeneric<T>(List<Usuario> v)
        {
            UsuariosGeneric<T> usuarios = new UsuariosGeneric<T>();
            foreach (T item in v)
            {
                usuarios.Add(item);
            }
            return usuarios;
        }

  
    }
}
