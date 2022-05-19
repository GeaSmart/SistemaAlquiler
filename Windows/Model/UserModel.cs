using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Entities;
using Windows.Utils;

namespace Windows.Model
{
    public class UserModel
    {
        public static ResponseModel<UserEntity> Check(UserEntity credenciales)
        {
            var response = new ResponseModel<UserEntity>();
            response.Response = false;
            try
            {
                var pw = HashHelper.SHA1(credenciales.Password);
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    var usuario = context.Usuarios.FirstOrDefault(x => x.Username == credenciales.Username && x.Password == pw);
                    if (usuario != null)
                    {
                        response.Response = true;
                        response.Data = new UserEntity { Username = usuario.Username, IsAdmin = usuario.IsAdmin, Id = usuario.Id };
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var item in error.ValidationErrors)
                    {
                        sb.Append(item.ErrorMessage);
                        sb.Append("\r\n");
                    }
                }
                response.Response = false;
                response.Message = sb.ToString();
            }
            catch (SystemException ex)
            {
                response.Message += "\r\n" + ex.Message;
            }
            return response;
        }

        public static ResponseModel<List<UserEntity>> Obtener()
        {
            var response = new ResponseModel<List<UserEntity>>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    response.Data = context.Usuarios.ToList();
                    response.Response = true;
                }
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var item in error.ValidationErrors)
                    {
                        sb.Append(item.ErrorMessage);
                        sb.Append("\r\n");
                    }
                }
                response.Response = false;
                response.Message = sb.ToString();
            }
            catch (SystemException ex)
            {
                response.Message += "\r\n" + ex.Message;
            }
            return response;
        }

        public static ResponseModel<UserEntity> Guardar(UserEntity usuario)
        {
            var response = new ResponseModel<UserEntity>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    var user = context.Usuarios.FirstOrDefault(x => x.Id == usuario.Id);
                    if (user != null)
                    {
                        user.Password = HashHelper.SHA1(usuario.Password);
                        context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                        if (context.SaveChanges() > 0)
                            response.Response = true;
                    }
                    else
                    {
                        response.Response = false;
                    }

                    
                }
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var item in error.ValidationErrors)
                    {
                        sb.Append(item.ErrorMessage);
                        sb.Append("\r\n");
                    }
                }
                response.Response = false;
                response.Message = sb.ToString();
            }
            catch (SystemException ex)
            {
                response.Message += "\r\n" + ex.Message;
            }
            return response;
        }
    }
}
