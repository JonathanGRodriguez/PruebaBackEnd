using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Vuelo
    {
        public static ML.Result Add(ML.Vuelo vuelo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenAeroMexicoEntities context=new DL.ExamenAeroMexicoEntities())
                {
                    var query = context.VueloAdd(vuelo.NumeroVuelo, vuelo.Origen, vuelo.Destino, vuelo.FechaSalida);
                    if (query >= 1)
                    {
                        result.Correct = true;
                        result.Object = vuelo;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo agregar";
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
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenAeroMexicoEntities context=new DL.ExamenAeroMexicoEntities())
                {
                    var query = context.VueloGetAll().ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach(var obj in query)
                        {
                            ML.Vuelo vuelo = new ML.Vuelo();
                            vuelo.Destino = obj.Destino;
                            vuelo.FechaSalida = obj.FechaSalida.Value;
                            vuelo.NumeroVuelo = obj.NumeroVuelo;
                            vuelo.Origen = obj.Origen;
                            result.Objects.Add(vuelo);
                        }
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
        public static ML.Result GetByNumeroVuelo(ML.Vuelo vuelo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenAeroMexicoEntities context=new DL.ExamenAeroMexicoEntities())
                {
                    var query = context.VueloGetByNumeroVuelo(vuelo.NumeroVuelo).FirstOrDefault();
                    if (query != null)
                    {
                        vuelo.Destino = query.Destino;
                        vuelo.FechaSalida = query.FechaSalida.Value;
                        vuelo.Origen = query.Origen;
                        vuelo.NumeroVuelo = query.NumeroVuelo;
                        result.Object = vuelo;
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
        public static ML.Result Update(ML.Vuelo vuelo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ExamenAeroMexicoEntities context = new DL.ExamenAeroMexicoEntities())
                {
                    var query = context.VueloUpdate(vuelo.NumeroVuelo, vuelo.Origen, vuelo.Destino, vuelo.FechaSalida);
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
