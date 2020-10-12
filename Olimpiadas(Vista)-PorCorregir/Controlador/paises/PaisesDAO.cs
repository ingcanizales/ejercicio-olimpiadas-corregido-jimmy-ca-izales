using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Controlador.paises
{
    public class PaisesDAO
    {

        Clasedatos clasedatos = null;
        PaisesDTO paisesDTO = null;
        DataTable listaDatos = null; 

        public PaisesDAO(PaisesDTO paisesDTO)
        {
            this.paisesDTO = paisesDTO;
        }

        public DataTable ListarPaises() {
            listaDatos = new DataTable();
            try {
                clasedatos = new Clasedatos();
                SqlParameter[] parametros = null;

                if (this.paisesDTO == null) {

                    parametros = new SqlParameter[2];

                    parametros[0] = new SqlParameter();
                    parametros[0].ParameterName = "@idpais";
                    parametros[0].SqlDbType = SqlDbType.TinyInt;
                    parametros[0].SqlValue = paisesDTO.getIdpais();

                    parametros[1] = new SqlParameter();
                    parametros[1].ParameterName = "@nombrepais";
                    parametros[1].SqlDbType = SqlDbType.VarChar;
                    parametros[1].Size = 50;
                    parametros[1].SqlValue = paisesDTO.getNombrepais();

                } else {

                    parametros = null;

                }

                listaDatos = clasedatos.retornaTabla(parametros, "sppaises_listar");
            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }

            return listaDatos;
        }


        public void guardarNuevoPais() {

            try {

                clasedatos = new Clasedatos();
                SqlParameter[] parametros = new SqlParameter[1];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@nombrepais";
                parametros[0].SqlDbType = SqlDbType.VarChar;
                parametros[0].Size = 50;
                parametros[0].SqlValue = paisesDTO.getNombrepais();

                clasedatos.ejecutarSP(parametros, "sppaises_guardar");
            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }
        }


        public void guardarCambiospais() {
            try
            {
                clasedatos = new Clasedatos();
                SqlParameter[] parametros = new SqlParameter[2];
                
                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idpais";
                parametros[0].SqlDbType = SqlDbType.TinyInt;
                parametros[0].SqlValue = paisesDTO.getIdpais();

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@nombrepais";
                parametros[1].SqlDbType = SqlDbType.VarChar;
                parametros[1].Size = 50;
                parametros[1].SqlValue = paisesDTO.getNombrepais();

                clasedatos.ejecutarSP(parametros, "sppaises_guardarcambios");

            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }

        }
    }
}
