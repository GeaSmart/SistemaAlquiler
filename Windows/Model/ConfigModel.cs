using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Entities;

namespace Windows.Model
{
    public class ConfigModel
    {
        public static ResponseModel<List<ConfigEntity>> Obtener(string property)
        {
            var response = new ResponseModel<List<ConfigEntity>>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    response.Data = context.Configs.Where(x=>x.Property == property).ToList();
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

        public static ResponseModel<ConfigEntity> GuardarMarca(ConfigEntity config)
        {
            var response = new ResponseModel<ConfigEntity>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    var existe = context.Configs.Any(x => x.Value == config.Value && x.Property == "MARCA");

                    if (!existe)
                    {
                        config.Property = "MARCA";
                        context.Configs.Add(config);


                        if (context.SaveChanges() > 0)
                            response.Response = true;
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

        public static ResponseModel<ConfigEntity> GuardarTipo(ConfigEntity config)
        {
            var response = new ResponseModel<ConfigEntity>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    var existe = context.Configs.Any(x => x.Value == config.Value && x.Property == "TIPO");

                    if (!existe)
                    {
                        config.Property = "TIPO";
                        context.Configs.Add(config);


                        if (context.SaveChanges() > 0)
                            response.Response = true;
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

        public static ResponseModel<ConfigEntity> EliminarMarcasDuplicadas()
        {
            var response = new ResponseModel<ConfigEntity>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    var rowsAffected = context.Database.ExecuteSqlCommand("delete FROM ConfigEntities WHERE Property = 'MARCA' and Value not in (select distinct Marca from EquipoEntities)");
                    if (rowsAffected > 0)
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

        public static ResponseModel<ConfigEntity> EliminarTiposDuplicadas()
        {
            var response = new ResponseModel<ConfigEntity>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    var rowsAffected = context.Database.ExecuteSqlCommand("delete FROM ConfigEntities WHERE Property = 'TIPO' and Value not in (select distinct Tipo from EquipoEntities)");
                    if (rowsAffected > 0)
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

        public static int GetLastId(string tipo)
        {
            var response = 0;
            
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    response = context.Equipos.Where(x => x.Tipo.Substring(0,3) == tipo.Substring(0,3)).OrderByDescending(x => x.Id).Take(1).Select(x => x.Id).SingleOrDefault();
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
            }
            catch (SystemException ex)
            {
                response = 0;
                //response.Message += "\r\n" + ex.Message;
            }
            return response;
        }
    }
}
