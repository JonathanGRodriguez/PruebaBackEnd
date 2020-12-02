using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Reservacion
    {
        public static ML.Result Add(ML.Reservacion reservacion)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenAeroMexicoEntities context=new DL.ExamenAeroMexicoEntities())
                {
                    ObjectParameter idReservacion = new ObjectParameter("IdReservacion", typeof(int));
                    var query = context.ReservacionAdd(reservacion.Usuario.IdUsuario, reservacion.Vuelo.NumeroVuelo, idReservacion);
                    if (query >= 1)
                    {
                        reservacion.IdReservacion = (int)idReservacion.Value;
                        result.Correct = true;
                        result.Object = reservacion;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo agregar. ";
                    }
                }
            }
            catch(Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = e.Message;
            }
            return result;
        }
    }
}
