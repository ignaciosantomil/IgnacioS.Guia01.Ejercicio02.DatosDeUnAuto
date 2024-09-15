using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgnacioS.Guia01.Ejercicio02.DatosDeUnAuto.DatosDeUnAuto
{
    internal class DatosDeUnAutoModel
    {   //Crear lista de personas
        //List<personas>
        private List<Auto> autos = new();
        public string IngresarAuto(Auto auto)
        {
            if(auto.Anio<2000 || auto.Anio>2021)
            {
                return "El año debe estar entre el 2000 y 2021";
            }
            if(auto.Precio<=0)
            {
                return "El precio debe ser mayor a 0";
            }
            if(string.IsNullOrWhiteSpace(auto.Modelo))
            {
                return "El modelo del auto es requerido";
            }
            if(auto.Modelo.Length>30)
            {
                return "El modelo del auto no puede tener más de 30 caracteres";
            }
            
            autos.Add(auto);

            return null;
        }


    }
}
