using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Controlador.posiciones
{
    public class PosicionesDAO
    {

        Clasedatos clasedatos= null;
        PosicionesDTO posicionesDTO= null;
        DataTable listaDatos= null; 

        public PosicionesDAO(PosicionesDTO posicionesDTO)
        {
            this.posicionesDTO = posicionesDTO;

        }

        public DataTable ListarPosiciones() {
            listaDatos = new DataTable();
            try {
                clasedatos = new Clasedatos();
                SqlParameter[] parametros = null;


                if (this.posicionesDTO == null) {

                    parametros = new SqlParameter[2];

                    parametros[0] = new SqlParameter();
                    parametros[0].ParameterName = "@idposicion";
                    parametros[0].SqlDbType = SqlDbType.TinyInt;
                    parametros[0].SqlValue = posicionesDTO.getIdposicion();

                    parametros[1] = new SqlParameter();
                    parametros[1].ParameterName = "@nombreposicion";
                    parametros[1].SqlDbType = SqlDbType.VarChar;
                    parametros[1].Size = 50;
                    parametros[1].SqlValue = posicionesDTO.getNombreposicion();

                } else {

                    parametros = null;

                }

                listaDatos = clasedatos.retornaTabla(parametros, "spposiciones_listar");
            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }

            return listaDatos;
        }


        public void guardarNuevoPosicion() {

            try {

                clasedatos = new Clasedatos();


                SqlParameter[] parametros = new SqlParameter[1];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@nombreposicion";
                parametros[0].SqlDbType = SqlDbType.VarChar;
                parametros[0].Size = 50;
                parametros[0].SqlValue = posicionesDTO.getNombreposicion();

                clasedatos.ejecutarSP(parametros, "spposiciones_guardar");
            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }
        }


        public void guardarCambiosposicion() {
            try
            {
                clasedatos = new Clasedatos();
                SqlParameter[] parametros = new SqlParameter[2];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idposicion";
                parametros[0].SqlDbType = SqlDbType.TinyInt;
                parametros[0].Size = 50;
                parametros[0].SqlValue = posicionesDTO.getIdposicion();

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@nombreposicion";
                parametros[1].SqlDbType = SqlDbType.VarChar;
                parametros[1].Size = 50;
                parametros[1].SqlValue = posicionesDTO.getNombreposicion();

                clasedatos.ejecutarSP(parametros, "spposiciones_guardarcambios");

            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }

        }
    }
}
