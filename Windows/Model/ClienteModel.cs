using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Entities;

namespace Windows.Model
{
    public class ClienteModel
    {
        public static ResponseModel<ClienteEntity> Guardar(ClienteEntity cliente)
        {
            var response = new ResponseModel<ClienteEntity>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    var existe = context.Clientes.Any(x => x.Id == cliente.Id);
                    if (existe)
                    {
                        context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        context.Clientes.Add(cliente);
                    }

                    if (context.SaveChanges() > 0)
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
            catch(SystemException ex)
            {
                response.Message += "\r\n" + ex.Message;
            }
            return response;
        }

        public static ResponseModel<List<ClienteEntity>> Obtener()
        {
            var response = new ResponseModel<List<ClienteEntity>>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    response.Data = context.Clientes.ToList();
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

        public static ResponseModel<ClienteEntity> Obtener(int id)
        {
            var response = new ResponseModel<ClienteEntity>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    response.Data = context.Clientes.FirstOrDefault(x => x.Id == id);
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

        public static ResponseModel<ClienteEntity> Eliminar(int id)
        {
            var response = new ResponseModel<ClienteEntity>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    var cliente = new ClienteEntity { Id = Convert.ToInt32(id) };
                    context.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;

                    if (context.SaveChanges() > 0)
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
    }
}
