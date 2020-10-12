using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controlador.paises
{
    public class PaisesDTO
    {
        private string idpais;
        private string nombrepais;

        public void setIdpais(string valor) {
            this.idpais = valor;
        }

        public string getIdpais() {
            return this.idpais;
        }

        public void setNombrepais(string valor) {
            this.nombrepais = valor;
        }

        public string getNombrepais() {
            return this.nombrepais;
        }

    }
}
