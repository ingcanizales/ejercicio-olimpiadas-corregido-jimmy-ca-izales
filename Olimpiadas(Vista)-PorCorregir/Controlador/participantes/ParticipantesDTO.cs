using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controlador.participantes
{
    public class ParticipantesDTO
    {
        private long numerodocumento;
        private string nombreparticipante;
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
