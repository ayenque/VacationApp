using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UPC.VacationApp.BL;
using UPC.VacationApp.BL.BusinessLogic;

namespace UPC.VacationApp.UT
{
    [TestClass]
    public class VacacionUT
    {
        [TestMethod]
        public void Registrar()
        {
            var objVacacion = new Vacacion()
            {
                Activo = true,
                FechaInicio = DateTime.Now,
                FechaFinal = DateTime.Now,
                IdUsuarioRegistro = 0,
                FechaRegistro = DateTime.Now,
                IdUsuario = 2

            };

            var objVacacionBL = new VacacionBL(); //llamar al metodo de registrar

            var id = objVacacionBL.Registrar(objVacacion);

            Assert.AreEqual(4, id);
            
        }

        [TestMethod]
        public void Buscar()
        {
      

            var objVacacionBL = new VacacionBL(); //llamar al metodo de registrar

            var objVacacion = objVacacionBL.Buscar(1);

            Assert.AreEqual(1, objVacacion.Id);

        }

        
        [TestMethod]
        public void Modificar()
        {
            var objVacacion = new Vacacion()
            {
                Id = 1,
                Activo = false,
                FechaInicio = DateTime.Now,
                FechaFinal = DateTime.Now,
                IdUsuarioModifico = 1,
                                
            };

            var objVacacionBL = new VacacionBL(); //llamar al metodo de registrar

            var respuesta = objVacacionBL.Modificar(objVacacion);

            Assert.AreEqual(true, respuesta);

        }


        [TestMethod]
        public void Eliminar()
        {


            var objVacacionBL = new VacacionBL(); //llamar al metodo de registrar

            var respuesta = objVacacionBL.Eliminar(1);

            Assert.AreEqual(true, respuesta);

        }



    }
}
