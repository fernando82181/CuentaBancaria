using System;
using System.Collections.Generic;
using System.Text;

namespace BancoApp.Clases
{
    class CuentaAhorros : CuentaBancaria
    {
        private double porcentajeInteresAhorro;
        private int periodoInteresAhorro;

        public CuentaAhorros( double porcentajeInteresAhorro, int periodoInteresAhorro, Cliente cliente, int numeroCuenta, double saldo) : base(cliente, numeroCuenta, saldo)
        {
            this.porcentajeInteresAhorro = porcentajeInteresAhorro;
            this.periodoInteresAhorro = periodoInteresAhorro;
        }
    }
}
