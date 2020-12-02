using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Pasajero
    {
        public static ML.Result Add(ML.Pasajero pasajero)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenAeroMexicoEntities context=new DL.ExamenAeroMexicoEntities())
                {
                    ObjectParameter idPasajero = new ObjectParameter("IdPasajero", typeof(int));
                    var query = context.PasajeroAdd(pasajero.Nombre, pasajero.ApellidoPaterno, pasajero.ApellidoMaterno, idPasajero);
                    if (query >= 1)
                    {
                        pasajero.IdPasajero = (int)idPasajero.Value;
                        result.Correct = true;
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
        public static ML.Result GetById(ML.Pasajero pasajero)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenAeroMexicoEntities context=new DL.ExamenAeroMexicoEntities())
                {
                    var query = context.PasajeroGetById(pasajero.IdPasajero).FirstOrDefault();
                    if (query != null)
                    {
                        pasajero.ApellidoMaterno = query.ApellidoMaterno;
                        pasajero.ApellidoPaterno = query.ApellidoPaterno;
                        pasajero.Nombre = query.Nombre;
                        result.Object = pasajero;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros. ";
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
        public static ML.Result Update(ML.Pasajero pasajero)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenAeroMexicoEntities context=new DL.ExamenAeroMexicoEntities())
                {
                    var query = context.PasajeroUpdate(pasajero.Nombre, pasajero.ApellidoPaterno, pasajero.ApellidoMaterno, pasajero.IdPasajero);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo actualizar. ";
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
