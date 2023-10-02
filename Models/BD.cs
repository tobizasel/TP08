using System.Data.SqlClient;
using Dapper;

class BD
{
    
    private static string _connectionString = @"Server=.;Database=TP08;Trusted_Connection=True";

    static void CrearCuenta(Usuarios usuario){
        string query = "INSERT INTO Usuarios(Id, Username, Contraseña, Mail, Telefono, Nombre) VALUES (@ZId, @ZUsername, @ZContraseña, @ZMail, @ZTelefono, @ZNombre)";

        using(SqlConnection BD = new SqlConnection(_connectionString)){
            BD.Execute(query, new(@ZId = usuario.id, @ZUsername = usuario.Username, @ZContraseña = usuario.Contraseña, @ZMail = usuario.Mail, @ZTelefono = usuario.Telefono, @ZNombre = usuario.Nombre));
        }
    }
}