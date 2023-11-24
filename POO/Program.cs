namespace POO
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Estudiante(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return $"Estudiante: {Nombre}, Edad: {Edad}";
        }
    }

    public class Curso
    {
        public string NombreCurso { get; set; }
        private List<Estudiante> estudiantes;

        public Curso(string nombreCurso)
        {
            NombreCurso = nombreCurso;
            estudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }

        public void MostrarEstudiantes()
        {
            Console.WriteLine($"Estudiantes en el curso {NombreCurso}:");
            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine(estudiante.ToString());
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso("Programación en C#");
            curso.AgregarEstudiante(new Estudiante("Juan", 20));
            curso.AgregarEstudiante(new Estudiante("Ana", 22));
            curso.MostrarEstudiantes();
        }
    }
}

//Este programa crea una clase Estudiante con los atributos Nombre y Edad,
//Y una clase Curso que encapsula una lista de estudiantes y proporciona métodos para agregar estudiantes e imprimir la lista de estudiantes.
//En el método Main, se crea un objeto Curso, se agregan dos estudiantes y luego se imprime la lista de estudiantes.