﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class DestinosExportes : ClaseMaestra
    {
        Conexion conexion = new Conexion();
        public int DestinoId { get; set; }
        public string Pais { get; set; }
        public string CodigoDestino { get; set; }
        public string NombreDestino { get; set; }
        public string Direccion { get; set; }
        public double CodigoPostal { get; set; }

        public DestinosExportes()
        {
            this.DestinoId = 0;
            this.Pais = "";
            this.CodigoDestino = "";
            this.NombreDestino = "";
            this.Direccion = "";
            this.CodigoPostal = 0;
        }

        public DestinosExportes(string pais, string nombre, string direccion, double codigopostal)
        {
            this.Pais = pais;
            this.NombreDestino = nombre;
            this.Direccion = direccion;
            this.CodigoPostal = codigopostal;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert into DestinosExportes(Pais, CodigoDestino, NombreDestino, Direccion, CodigoPostal) Values('{0}', '{1}', '{2}', '{3}', {4})", this.Pais, this.CodigoDestino, this.NombreDestino, this.Direccion, this.CodigoPostal));
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
                retorno = conexion.Ejecutar(String.Format("Update DestinosExportes set Pais = '{0}', CodigoDestino='{1}', NombreDestino = '{2}', Direccion = '{3}', CodigoPostal = {4} where DestinoId = {5}", this.Pais, this.CodigoDestino, this.NombreDestino, this.Direccion, this.CodigoPostal, this.DestinoId));
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
                retorno = conexion.Ejecutar(String.Format("Delete From DestinosExportes where DestinoId = {0}", this.DestinoId));
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
           
                dt = conexion.getDatos(String.Format("select *from DestinosExportes where DestinoId= {0}", IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.Pais = dt.Rows[0]["Pais"].ToString();
                    this.CodigoDestino = dt.Rows[0]["CodigoDestino"].ToString();
                    this.NombreDestino = dt.Rows[0]["NombreDestino"].ToString();
                    this.Direccion = dt.Rows[0]["Direccion"].ToString();
                    this.CodigoPostal = (int)dt.Rows[0]["CodigoPostal"];
                }
            return dt.Rows.Count > 0;
        }
          
        
        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden By " + Orden;

            return conexion.getDatos(" Select " + Campos + " from DestinosExportes where " + Condicion + "" + ordenFinal);
        }
    }
}
