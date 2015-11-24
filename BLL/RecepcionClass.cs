using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class RecepcionClass : ClaseMaestra
    {
        Conexion conexion = new Conexion();
        public int RecepcionId { get; set; }
        public int SocioId { get; set; }
        public int LoteId { get; set; }
        public int CertificacionId { get; set; }
        public int TipoCacaoId { get; set; }
        public string Fecha { get; set; }
        public int CantidadPesada { get; set; }
        public string Observacion { get; set; }
        public string RecibidoPor { get; set; }

        public RecepcionClass()
        {
            this.RecepcionId = 0;
            this.SocioId = 0;
            this.LoteId =0;
            this.CertificacionId = 0;
            this.TipoCacaoId = 0;
            this.Fecha = "";
            this.CantidadPesada = 0;
            this.Observacion = "";
            this.RecibidoPor = "";
        }

        public RecepcionClass(int recepcioid, int socioid, int loteid, int certificacionid, int tipocacaoid, string fecha, int cantidadpesada, string observacion, string recibidopor)
        {
            this.RecepcionId = recepcioid;
            this.SocioId = socioid;
            this.LoteId = loteid;
            this.CertificacionId = certificacionid;
            this.TipoCacaoId = tipocacaoid;
            this.Fecha = fecha;
            this.CantidadPesada = cantidadpesada;
            this.Observacion = observacion;
            this.RecibidoPor = recibidopor;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert Into Recepciones(SocioId, LoteId, CertificacionId, TipoCacaoId, Fecha, CantidadPesada, Observacion, RecibidoPor) Values({0}, {1}, {2}, {3}, '{4}', {5}, '{6}', '{7}')", this.SocioId, this.LoteId, this.CertificacionId, this.TipoCacaoId, this.Fecha, this.CantidadPesada, this.Observacion, this.RecibidoPor));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt;

            dt = conexion.getDatos(String.Format("select *from Recepciones where RecepcionId= {0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.CantidadPesada = (int)dt.Rows[0]["CantidadPesada"];
                this.Observacion = dt.Rows[0]["Observacion"].ToString();
                this.RecibidoPor = dt.Rows[0]["RecibidoPor"].ToString();

            }

            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Update Recepciones Set Fecha='{0}', CantidadPesada={1}, Observacion='{3}', RecebidoPor='{4}' where RecepcionId={5}", this.Fecha, this.CantidadPesada, this.Observacion, this.RecibidoPor ));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Delete from Recepciones where InspeccionId={0}", this.RecepcionId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }


        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (Orden.Equals(""))
                ordenFinal = " Orden By " + Orden;
            return conexion.getDatos("Select " + Campos + " from Recepciones where " + Condicion + Orden);
        }
    }
}
