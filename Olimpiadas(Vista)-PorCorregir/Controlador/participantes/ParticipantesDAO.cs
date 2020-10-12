using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Controlador.participantes
{
    public class ParticipantesDAO
    {

        Clasedatos clasedatos = null;
        ParticipantesDTO participantesDTO = null;
        DataTable listaDatos = null; 
       

        public ParticipantesDAO(ParticipantesDTO participantesDTO)
        {
            this.participantesDTO = participantesDTO;
        }

        public DataTable ListarParticipantes() {
            listaDatos = new DataTable();
            try {
                clasedatos = new Clasedatos();
                SqlParameter[] parametros = null;

                if (this.participantesDTO == null) {

                    parametros = new SqlParameter[3];

                    parametros[0] = new SqlParameter();
                    parametros[0].ParameterName = "@numerodocumento";
                    parametros[0].SqlDbType = SqlDbType.BigInt;
                    parametros[0].SqlValue = participantesDTO.getNumerodocumento();

                    parametros[1] = new SqlParameter();
                    parametros[1].ParameterName = "@nombreparticipante";
                    parametros[1].SqlDbType = SqlDbType.VarChar;
                    parametros[1].Size = 50;
                    parametros[1].SqlValue = participantesDTO.getNombreparticipante();

                    parametros[2] = new SqlParameter();
                    parametros[2].ParameterName = "@idpais";
                    parametros[2].SqlDbType = SqlDbType.TinyInt;
                    parametros[2].SqlValue = participantesDTO.getIdpais();
                } else {
                    parametros = null;
                }

                listaDatos = clasedatos.retornaTabla(parametros, "spparticipantes_listar");
            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }

            return listaDatos;
        }


        public void guardarNuevoParticipante() {

            SqlParameter[] parametros = null;

            try {

                clasedatos = new Clasedatos();
                parametros = new SqlParameter[3];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@numerodocumento";
                parametros[0].SqlDbType = SqlDbType.BigInt;
                parametros[0].SqlValue = participantesDTO.getNumerodocumento();

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@nombreparticipante";
                parametros[1].SqlDbType = SqlDbType.VarChar;
                parametros[1].Size = 50;
                parametros[1].SqlValue = participantesDTO.getNombreparticipante();

                parametros[2] = new SqlParameter();
                parametros[2].ParameterName = "@idpais";
                parametros[2].SqlDbType = SqlDbType.TinyInt;
                parametros[2].SqlValue = participantesDTO.getIdpais();

                clasedatos.ejecutarSP(parametros, "spparticipantes_guardar");
            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }
        }


        public void guardarCambiosParticipantes() {

            SqlParameter[] parametros = null;

            try
            {
                clasedatos = new Clasedatos();

                parametros = new SqlParameter[3];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@numerodocumento";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].SqlValue = participantesDTO.getNumerodocumento();

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@nombreparticipante";
                parametros[1].SqlDbType = SqlDbType.VarChar;
                parametros[1].Size = 50;
                parametros[1].SqlValue = participantesDTO.getNombreparticipante();

                parametros[2] = new SqlParameter();
                parametros[2].ParameterName = "@idpais";
                parametros[2].SqlDbType = SqlDbType.TinyInt;
                parametros[2].SqlValue = participantesDTO.getIdpais();

                clasedatos.ejecutarSP(parametros, "spparticipantes_guardarcambios");
            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }

        }

        public DataTable TraerPaisParticipante()
        {
            listaDatos = new DataTable();
            try
            {
                clasedatos = new Clasedatos();
                SqlParameter[] parametros = null;

                    parametros = new SqlParameter[1];

                    parametros[0] = new SqlParameter();
                    parametros[0].ParameterName = "@numerodocumento";
                    parametros[0].SqlDbType = SqlDbType.BigInt;
                    parametros[0].SqlValue = participantesDTO.getNumerodocumento();

                listaDatos = clasedatos.retornaTabla(parametros, "sptraerpaisparticipante_listar");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return listaDatos;
        }


    }
}
