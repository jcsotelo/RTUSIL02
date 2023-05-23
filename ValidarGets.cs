using TestApi;
using TestApi.DTOs;
using Xunit;

namespace UnitTesting.Test
{
    public class ValidarGets
    {
        [Fact]
        public void ValidarNombreArchivoPlano()
        {
            var validarObjetos = new ValidarObjetos();

            string nombrearchivo = "C:\\JuanCarlos\\USIL\\gistfile1.txt";

            bool isvalid = validarObjetos.NombreArchivotxt(nombrearchivo);

            Assert.True(isvalid);

        }

        [Fact]
        public void ValidarCapacidadArchivoPLano()
        {
            var validarObjetos = new ValidarObjetos();

            //string nombrearchivo = "C:\\JuanCarlos\\USIL\\gistfile1.txt";

            string capacidad = validarObjetos.CapacidadArchivotxt();

            string expectativa = "Vacio";

            Assert.Equal(capacidad, expectativa);
        }
    }
}
