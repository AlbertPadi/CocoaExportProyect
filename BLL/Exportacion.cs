using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Exportacion : ClaseMaestra
    {
        Conexion conexion = new Conexion();

        public int ExportacionId { get; set; }
        public int DestinoId { get; set; }
        public int LoteId { get; set; }
        public int CertificacionId { get; set; }
        public double CantidadToneladas { get; set; }
        public double Monto { get; set; }
        public string Fecha { get; set; }
        public string Resumen { get; set; }

        public List<Lotes>Lotes{ set; get;}
    public Exportacion()
        {
            this.ExportacionId = 0;
            this.DestinoId = 0;
            this.CantidadToneladas = 0;
            this.CertificacionId = 0;
            this.Monto = 0;
            this.Fecha = "";
            this.LoteId = 0;
            this.Resumen = "";
            Lotes = new List<BLL.Lotes>();
        }
        public void AgregarLotes(int LoteId, string CodigoLote)
        {
            this.Lotes.Add(new Lotes(LoteId, CodigoLote));
        }

        public override bool Insertar()
        {
            bool retorno = false;
            StringBuilder Comando = new StringBuilder();
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert into Exportaciones(DestinoId, Monto, Fecha, Resumen) values({0}, {1}, '{2}', '{3}')", this.DestinoId, this.Monto, this.Fecha, this.Resumen));
                if (retorno) 
                {
                        this.ExportacionId = (int)conexion.getDatos("Select Max(ExportacionId) as ExportacionId from Exportaciones").Rows[0]["ExportacionId"];
                    foreach (var lote in this.Lotes)
                    {
                        Comando.AppendLine(String.Format("Insert Into LotesExportes(LoteId, CodigoLote, ExportacionId) Values({0},'{1}', {2})", lote.LoteId, lote.CodigoLote, this.ExportacionId));
                    }
                    retorno = conexion.Ejecutar(Comando.ToString());
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }
        public override bool Eliminar()
        {
            bool retorno = false;

            retorno = conexion.Ejecutar("Delete LotesExportes where ExportacionId = " + this.ExportacionId + ";" + "Delete Exportaciones where ExportacionId = " + this.ExportacionId);

            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable ();
            DataTable LotesExp = new DataTable();
            dt = conexion.getDatos(String.Format("select DestinoId, CantidadToneladas, Fecha, Resumen from Exportaciones where ExportacionId = {0}", IdBuscado));

            if (dt.Rows.Count>0)
            {
                this.DestinoId = (int)dt.Rows[0]["DestinoId"];
                this.CantidadToneladas = (double)dt.Rows[0]["CantidadToneladas"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.Resumen = dt.Rows[0]["Resumen"].ToString();

                LotesExp = conexion.getDatos(String.Format("select e.CodigoLote from Exportaciones l inner join LotesExportes e on l.ExportacionId = e.ExportacionId where e.ExportacionId = {0}", this.ExportacionId));
                foreach (DataRow data in LotesExp.Rows)
                {
                    this.AgregarLotes((int)data["LoteId"],  data["CodigoLote"].ToString());
                }
            }
            return dt.Rows.Count > 0;
        }
        
        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden By " + Orden;
            return conexion.getDatos(String.Format(" Select " + Campos + " From Exportaciones Where " + Condicion + " " + ordenFinal));
        }
    }
}
