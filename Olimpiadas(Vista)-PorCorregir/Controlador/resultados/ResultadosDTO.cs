using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controlador.resultados
{
    public class ResultadosDTO
    {
        private long numerodocumento;
        private string nombreparticipante;
        private byte idposicion;
        private byte idpais;

        public void setNumerodocumento(long valor) {
            this.numerodocumento = valor;
        }

        public long getNumerodocumento() {
            return this.numerodocumento;
        }

        public void setNombreparticipante(string valor) {
            this.nombreparticipante = valor;
        }

        public string getNombreparticipante() {
            return this.nombreparticipante;
        }

        public void setIdposicion(byte valor)
        {
            this.idposicion = valor;
        }

        public byte getIdposicion()
        {
            return this.idposicion;
        }

        public void setIdpais(byte valor)
        {
            this.idpais = valor;
        }

        public byte getIdpais()
        {
            return this.idpais;
        }

    }
}
