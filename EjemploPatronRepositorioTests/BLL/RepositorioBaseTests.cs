using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjemploPatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploPatronRepositorio.Entidades;

namespace EjemploPatronRepositorio.BLL.Tests
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
        public void GuardarTest()
        {
            RepositorioBase<Cuentas> repositorio;
            repositorio = new RepositorioBase<Cuentas>();
            Assert.IsTrue(repositorio.Guardar(GetCuenta()));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Cuentas> repositorio;
            repositorio = new RepositorioBase<Cuentas>();
            Assert.IsTrue(repositorio.Modificar(GetCuenta()));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Cuentas> repositorio;
            repositorio = new RepositorioBase<Cuentas>();
            Assert.IsTrue(repositorio.Eliminar(GetCuenta()));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Cuentas> repositorio;
            repositorio = new RepositorioBase<Cuentas>();
            Assert.IsNotNull(repositorio.Modificar(GetCuenta()));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Cuentas> repositorio;
            repositorio = new RepositorioBase<Cuentas>();
            Assert.IsNotNull(repositorio.GetList(GetCuenta()));
        }
    }
}