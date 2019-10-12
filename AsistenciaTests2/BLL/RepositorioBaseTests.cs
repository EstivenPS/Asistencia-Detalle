using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asistencia.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asistencia.Entidades;

namespace Asistencia.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();

            Assert.IsTrue(repositorio.Buscar(1) != null);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = new Asignaturas();

            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = new Asignaturas();

            Assert.IsTrue(repositorio.Guardar(asignatura));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = new Asignaturas();

            asignatura.AsignaturaId = 1;

            Assert.IsTrue(repositorio.Modificar(asignatura));
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }
    }
}