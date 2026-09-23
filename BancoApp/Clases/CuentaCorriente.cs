using System;
using System.Collections.Generic;
using System.Text;

namespace BancoApp.Clases
{
    class CuentaCorriente : CuentaBancaria
    {
        private double prestamo;
        private int periodoPrestamo;
        private double porcentajeInteresPrestamo;

        public CuentaCorriente( double prestamo, int periodoPrestamo, double porcentajeInteresPrestamo, Cliente cliente, int numeroCuenta, double saldo) : base(cliente, numeroCuenta, saldo)
        {
            this.prestamo = prestamo;
            this.periodoPrestamo = periodoPrestamo;
            this.porcentajeInteresPrestamo = porcentajeInteresPrestamo;

        }
    }
}
