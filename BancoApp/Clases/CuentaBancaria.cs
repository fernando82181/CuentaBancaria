using System;
using System.Collections.Generic;
using System.Text;

namespace BancoApp.Clases
{
    class CuentaBancaria
    {
        private Cliente titular;
        private int numeroCuenta;

        private double saldo;


        public CuentaBancaria( Cliente cliente, int numeroCuenta, double saldo ) { 
        
            this.titular = cliente;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
        }


        public Cliente getCliente() { 
        
            return this.titular;

        }
        public void setCliente(Cliente cliente)
        {

            this.titular = new Cliente (cliente.getNombre(), cliente.getCorreo(), cliente.getTelefono());
        }

        public int getNumeroCuenta()
        {
            return this.numeroCuenta;
        }
        public void setNumeroCuenta(int numeroCuenta)
        {
            this.numeroCuenta = numeroCuenta;
        }
        public double getSaldo()
        {
            return this.saldo;
        }
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }



    }
}
