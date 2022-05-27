﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21_OrientacaoObjeto2
{
    public class produto
    {
        public string Nome;
        public DateTime DataFabricacao;
        public DateTime DataVencimento;

        public bool EhVencido()
        {
            var dataHoje = DateTime.Today;

            if (DataVencimento > dataHoje)
            {
                return false;
            }
            return true;
        }

        public bool EstaEmPromocao()
        {
            var vencido = EhVencido();

            if (vencido == true)
            {
                return false;
            }

            var dataHoje = DateTime.Today;

            var dataInicioPromocao = DataVencimento.AddDays(-3);

            var dataTerminoPromocao = DataVencimento.AddDays(-1);

            return dataHoje >= dataInicioPromocao && dataHoje <= dataTerminoPromocao
                ? true
                : false;

        }
    }
}
