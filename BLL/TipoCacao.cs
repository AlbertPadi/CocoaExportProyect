using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class TipoCacao : ClaseMaestra
    {
        Conexion conexion = new Conexion();
        public int TipoCacaoId { get; set; }
        public string Descripcion { get; set; }

        public TipoCacao()
        {
            this.TipoCacaoId = 0;
            this.Descripcion = "";
        }

        public TipoCacao(int tipocacaoid, string descripcion)
        {
            this.TipoCacaoId = tipocacaoid;
            this.Descripcion = descripcion;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert Into TiposCacao(Descripcion) Values('{0}')", this.Descripcion));
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
                retorno = conexion.Ejecutar(String.Format("Update TiposCacao Set Descripcion='{0}' where TipoCacaoId={1}", this.Descripcion ,this.TipoCacaoId));
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
                retorno = conexion.Ejecutar(String.Format("Delete from TiposCacao where TipoCacaoId={0}", this.TipoCacaoId));
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

            dt = conexion.getDatos(String.Format("select *from TiposCacao where TipoCacaoId= {0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }

            return dt.Rows.Count > 0;
        }

        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = " ";
            if (!Orden.Equals(""))
                ordenFinal = " Orden By " + Orden;


            return conexion.getDatos(" Select " + Campos + " from TiposCacao where " + Condicion + ordenFinal);
        }
    }
}
