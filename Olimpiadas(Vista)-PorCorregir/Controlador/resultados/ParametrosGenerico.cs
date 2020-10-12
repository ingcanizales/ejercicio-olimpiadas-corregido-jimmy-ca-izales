using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Controlador.resultados
{
    public class ParametrosGenerico
    {
        public SqlParameter numerico(string variableSP, SqlDbType tipoDato, long atributo, short consecutivo) {
            SqlParameter[] parametros = null;
            parametros = new SqlParameter[1];
            parametros[consecutivo] = new SqlParameter();
            parametros[consecutivo].ParameterName = variableSP;
            parametros[consecutivo].SqlDbType = tipoDato;
            parametros[consecutivo].SqlValue = atributo;
            return parametros[consecutivo];
        }

        public SqlParameter numerico(string variableSP, SqlDbType tipoDato, byte atributo, short consecutivo)
        {
            SqlParameter[] parametros = null;
            parametros = new SqlParameter[1];
            parametros[consecutivo] = new SqlParameter();
            parametros[consecutivo].ParameterName = variableSP;
            parametros[consecutivo].SqlDbType = tipoDato;
            parametros[consecutivo].SqlValue = atributo;
            return parametros[consecutivo];
        }

        public SqlParameter texto(string variableSP, SqlDbType tipoDato, string atributo, byte limiteCaracteres, short consecutivo)
        {
            SqlParameter[] parametros = null;
            parametros = new SqlParameter[1];
            parametros[consecutivo] = new SqlParameter();
            parametros[consecutivo].ParameterName = variableSP;
            parametros[consecutivo].SqlDbType = tipoDato;
            parametros[consecutivo].Size = limiteCaracteres;
            parametros[consecutivo].SqlValue = atributo;
            return parametros[consecutivo];
        }

    }
}
