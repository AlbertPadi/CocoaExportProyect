using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Recepcion : ClaseMaestra
    {
        Conexion conexion = new Conexion();
        Lotes lotes = new Lotes();
        public int RecepcionId { get; set; }
        public int SocioId { get; set; }
        public string CodigoLote { get; set; }
        public int LoteId { get; set; }
        public int TipoCacaoId { get; set; }
        public string Fecha { get; set; }
        public double CantidadPesada { get; set; }
        public double Monto { get; set; }
        public string Observacion { get; set; }
        public string RecibidoPor { get; set; }

        public double CantidadAnterior { get; set; }
        

    public Recepcion()
        {
            this.RecepcionId = 0;
            this.SocioId = 0;
            this.LoteId = 0;
            this.CodigoLote = "";
            this.TipoCacaoId = 0;
            this.Fecha = "";
            this.CantidadPesada = 0;
            this.Monto = 0;
            this.Observacion = "";
            this.RecibidoPor = "";
        }
        

       
        public override bool Insertar()
                {
                    bool retorno = false;
                    DataTable dt = new DataTable();
            try
                    {
                       retorno = conexion.Ejecutar(String.Format("insert into Recepciones(SocioId, LoteId, TipoCacaoId, Fecha, CantidadPesada, Monto,  Observacion, RecibidoPor) values({0}, {1}, {2}, '{3}', {4}, {5}, '{6}', '{7}')", this.SocioId, this.LoteId, this.TipoCacaoId, this.Fecha, this.CantidadPesada, this.Monto, this.Observacion, this.RecibidoPor));
                       conexion.Ejecutar(String.Format("update Lotes set Total=Total + " + this.CantidadPesada + " where LoteId=" + this.LoteId));

                     }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                    return retorno;
                }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Update Recepciones set SocioId={0}, TipoCacaoId={1}, Fecha = '{2}', CantidadPesada={3}, Observacion='{4}', RecibidoPor='{5}' where RecepcionId={6}", this.SocioId, this.TipoCacaoId, this.Fecha, this.CantidadPesada, this.Observacion, this.RecibidoPor, this.RecepcionId));

                if (this.CantidadPesada > this.CantidadAnterior)
                {
                    double aux = (this.CantidadPesada - this.CantidadAnterior);
                    conexion.Ejecutar(String.Format("update Lotes set Total=Total + " + aux + " where LoteId=" + this.LoteId));
                }
                else
                {
                    double aux = (this.CantidadAnterior - this.CantidadPesada);
                    conexion.Ejecutar(String.Format("update Lotes set Total=Total + " + aux + " where LoteId=" + this.LoteId));
                }
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
                retorno = conexion.Ejecutar(String.Format("delete from Recepciones where RecepcionId = {0}", this.RecepcionId));
                conexion.Ejecutar(String.Format("update set Total=Total - " + this.CantidadPesada + " where LoteId=" + this.LoteId));
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

            dt = conexion.getDatos(String.Format("select * From Recepciones where RecepcionId= {0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.RecepcionId= (int)dt.Rows[0]["RecepcionId"];
                this.SocioId = (int)dt.Rows[0]["SocioId"];
                this.TipoCacaoId = (int)dt.Rows[0]["TipoCacaoId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.CantidadPesada = (double)dt.Rows[0]["CantidadPesada"];
                this.Monto = (double)dt.Rows[0]["Monto"];
                this.Observacion = dt.Rows[0]["Observacion"].ToString();
                this.RecibidoPor = dt.Rows[0]["RecibidoPor"].ToString();

            }

            return dt.Rows.Count > 0;
        }
       
        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = " ";
            if (!Orden.Equals(""))
                ordenFinal = " Orden By " + Orden;


            return conexion.getDatos(" Select " + Campos + " from Recepciones where "+Condicion+ordenFinal);
        }
    }
}
