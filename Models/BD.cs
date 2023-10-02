using System.Data.SqlClient;
using Dapper;

class BD
{
    private static string _connectionString = @"Server=.;Database=TP08;Trusted_Connection=True";

    public static bool validar(Usuarios usuario){
        string query = "SELECT * FROM Usuarios WHERE Id = @Zid";
        Usuarios miUsuario = null;

        using (SqlConnection BD = new SqlConnection(_connectionString)){
            miUsuario = BD.QueryFirstOrDefault<Usuarios>(query, new {Zid = usuario.Id});
        }

        Console.WriteLine(miUsuario);
        if ((miUsuario.Nombre == usuario.Nombre) && (usuario.Contraseña == usuario.Contraseña))
        {
            return true;
        }
        return false;
    }

    public static void crearCuenta(Usuarios usuario)
    {
        string query = "INSERT INTO Usuarios(Username, Contraseña, Mail, Telefono, Nombre) VALUES ( @ZUsername, @ZContraseña, @ZMail, @ZTelefono, @ZNombre)";

        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            BD.Execute(query, new { ZUsername = usuario.Username, ZContraseña = usuario.Contraseña, ZMail = usuario.Mail, ZTelefono = usuario.Telefono, ZNombre = usuario.Nombre });
        }
    }
}