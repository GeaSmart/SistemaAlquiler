using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Entities;

namespace Windows.Model
{
    public class ContratoModel
    {
        public static ResponseModel<ContratoEntity> Guardar(ContratoEntity contrato)
        {
            var response = new ResponseModel<ContratoEntity>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    var existe = context.Contratos.Any(x => x.Id == contrato.Id);
                    if (existe)
                    {
                        context.Entry(contrato).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        context.Contratos.Add(contrato);
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

        public static ResponseModel<List<ContratoEntity>> Obtener()
        {
            var response = new ResponseModel<List<ContratoEntity>>();
            response.Response = false;
            try
            {
                using (ApplicationDBContext context = new ApplicationDBContext())
                {
                    response.Data = context.Contratos.ToList();
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

        //public static ResponseModel<List<ContratoEntity>> Obtener()
        //{
        //    var response = new ResponseModel<List<ContratoEntity>>();
        //    response.Response = false;
        //    try
        //    {
        //        using (ApplicationDBContext context = new ApplicationDBContext())
        //        {
        //            response.Data = context.Equipos.ToList();
        //            response.Response = true;
        //        }
        //    }
        //    catch (DbEntityValidationException ex)
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        foreach (var error in ex.EntityValidationErrors)
        //        {
        //            foreach (var item in error.ValidationErrors)
        //            {
        //                sb.Append(item.ErrorMessage);
        //                sb.Append("\r\n");
        //            }
        //        }
        //        response.Response = false;
        //        response.Message = sb.ToString();
        //    }
        //    catch (SystemException ex)
        //    {
        //        response.Message += "\r\n" + ex.Message;
        //    }
        //    return response;
        //}

        //public static ResponseModel<EquipoEntity> Obtener(int id)
        //{
        //    var response = new ResponseModel<EquipoEntity>();
        //    response.Response = false;
        //    try
        //    {
        //        using (ApplicationDBContext context = new ApplicationDBContext())
        //        {
        //            response.Data = context.Equipos.FirstOrDefault(x => x.Id == id);
        //            response.Response = true;
        //        }
        //    }
        //    catch (DbEntityValidationException ex)
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        foreach (var error in ex.EntityValidationErrors)
        //        {
        //            foreach (var item in error.ValidationErrors)
        //            {
        //                sb.Append(item.ErrorMessage);
        //                sb.Append("\r\n");
        //            }
        //        }
        //        response.Response = false;
        //        response.Message = sb.ToString();
        //    }
        //    catch (SystemException ex)
        //    {
        //        response.Message += "\r\n" + ex.Message;
        //    }
        //    return response;
        //}

        //public static ResponseModel<EquipoEntity> Eliminar(int id)
        //{
        //    var response = new ResponseModel<EquipoEntity>();
        //    response.Response = false;
        //    try
        //    {
        //        using (ApplicationDBContext context = new ApplicationDBContext())
        //        {
        //            var equipo = new EquipoEntity { Id = Convert.ToInt32(id) };
        //            context.Entry(equipo).State = System.Data.Entity.EntityState.Deleted;

        //            if (context.SaveChanges() > 0)
        //                response.Response = true;
        //        }
        //    }
        //    catch (DbEntityValidationException ex)
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        foreach (var error in ex.EntityValidationErrors)
        //        {
        //            foreach (var item in error.ValidationErrors)
        //            {
        //                sb.Append(item.ErrorMessage);
        //                sb.Append("\r\n");
        //            }
        //        }
        //        response.Response = false;
        //        response.Message = sb.ToString();
        //    }
        //    catch (SystemException ex)
        //    {
        //        response.Message += "\r\n" + ex.Message;
        //    }
        //    return response;
        //}
    }
}
