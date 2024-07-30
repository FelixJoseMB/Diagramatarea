using System;


public class MiembroDeLaComunidad
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public MiembroDeLaComunidad(int id, string nombre, string apellido)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
    }
}


public class Empleado : MiembroDeLaComunidad
{
    public Empleado(int id, string nombre, string apellido)
        : base(id, nombre, apellido) { }
}


public class Estudiante : MiembroDeLaComunidad
{
    public Estudiante(int id, string nombre, string apellido)
        : base(id, nombre, apellido) { }
}

public class ExAlumno : MiembroDeLaComunidad
{
    public ExAlumno(int id, string nombre, string apellido)
        : base(id, nombre, apellido) { }
}


public class Docente : Empleado
{
    public Docente(int id, string nombre, string apellido)
        : base(id, nombre, apellido) { }
}


public class Administrativo : Empleado
{
    public Administrativo(int id, string nombre, string apellido)
        : base(id, nombre, apellido) { }
}


public class Administrador : Docente
{
    public Administrador(int id, string nombre, string apellido)
        : base(id, nombre, apellido) { }
}


public class Maestro : Docente
{
    public Maestro(int id, string nombre, string apellido)
        : base(id, nombre, apellido) { }
}
