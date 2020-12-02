using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenAeroMexicoEntities context=new DL.ExamenAeroMexicoEntities())
                {
                    var query = context.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.UserName, usuario.Contrasenia);
                    if (query >= 1)
                    {
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
        public static ML.Result GetById(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenAeroMexicoEntities context=new DL.ExamenAeroMexicoEntities())
                {
                    var query = context.UsuarioGetById(usuario.IdUsuario).FirstOrDefault();
                    if (query != null)
                    {
                        usuario.ApellidoMaterno = query.ApellidoMaterno;
                        usuario.ApellidoPaterno = query.ApellidoPaterno;
                        usuario.Contrasenia = query.Contrasenia;
                        usuario.Nombre = query.Nombre;
                        usuario.UserName = query.UserName;
                        result.Object = usuario;
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
        public static ML.Result Update(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenAeroMexicoEntities context=new DL.ExamenAeroMexicoEntities())
                {
                    var query = context.UsuarioUpdate(usuario.Nombre, usuario.IdUsuario, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.UserName, usuario.Contrasenia);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo actualizar";
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
