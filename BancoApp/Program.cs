


using BancoApp.Clases;

public class Program
{
    public static void Main(string[] args)
    {

        Cliente clienteNuevo = new Cliente( "Fernando Carta", "fernando.carta@example.com", "123456789");
        CuentaAhorros cuentaAhorros = new CuentaAhorros( 0.15, 12, clienteNuevo, 123456,250000 );

        Console.WriteLine("Cliente: " + cuentaAhorros.getCliente().getNombre() + " " + cuentaAhorros.getCliente().getCorreo());
        Console.WriteLine("Cliente nuevo : " + clienteNuevo.getNombre() + " " + clienteNuevo.getCorreo());

        //Crear dos clientes nuevos y dos cuentas nuevas: 1 de ahorro 1 de corriente y asignarles un cliente diferente a cada una de ellas.
        //Luego mostrar por consola el nombre y correo de cada cliente y el saldo de cada cuenta.

    }
}