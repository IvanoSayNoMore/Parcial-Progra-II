using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UsuariosUTN.Clases;
using UsuariosUTN.Usuarios;

namespace Testers
{
    [TestClass]
    public class TestInsert
    {
        [TestMethod]
        public void UsuariosDao_Insert_SiElUsuarioEsNull_DeberiaLanzarExcepcion()
        {
            TipoUsuario tipoUsuario = null;
            try
            {
                if (UsuarioDao.Insert(tipoUsuario))
                {
                    Assert.IsTrue(false);
                }
            }
            catch 
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void ExamenDao_Insert_SiElExamenEsNull_DeberiaLanzarExcepcion()
        {
            Examen tipoExamen = null;
            try
            {
                if (ExamenDao.Insert(tipoExamen))
                {
                    Assert.IsTrue(false);
                }
            }
            catch
            {
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
        public void MateriaDao_Insert_SiLaMateriaEsNull_DeberiaLanzarExcepcion()
        {
            Materia tipoMateria = null;
            try
            {
                if (MateriasDao.Insert(tipoMateria))
                {
                    Assert.IsTrue(false);
                }
            }
            catch
            {
                Assert.IsTrue(true);
            }

        }
    }
}
