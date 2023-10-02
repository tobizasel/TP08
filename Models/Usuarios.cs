public class Usuarios
{
    
    public string Username { get; private set; }
    public int Id { get; private set; }
    public string Contraseña { get; private set; }
    public string Mail { get; private set; }
    public string Nombre { get; private set; }
    public int Telefono { get; private set; }

    public Usuarios(string username, int id, string contraseña, string mail, string nombre, int telefono)
    {
        Username = username;
        Id = id;
        Contraseña = contraseña;
        Mail = mail;
        Nombre = nombre;
        Telefono = telefono;
    }


}