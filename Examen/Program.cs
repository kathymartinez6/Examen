namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
             
                Console.WriteLine("Ingrese el nombre del alumno:");
                string nombreAlumno = Console.ReadLine();

                Console.WriteLine("Ingrese el número de cuenta:");
                string numeroCuenta = Console.ReadLine();

                Console.WriteLine("Ingrese el email del alumno:");
                string email = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre de la asignatura:");
                string nombreAsignatura = Console.ReadLine();

                Console.WriteLine("Ingrese el horario de la asignatura:");
                string horario = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre del docente:");
                string nombreDocente = Console.ReadLine();

               
                Asignatura asignatura = new Asignatura(nombreAlumno, numeroCuenta, email, nombreAsignatura, horario, nombreDocente);

                
                Console.WriteLine("Ingrese la nota del primer parcial (máximo 30):");
                asignatura.N1 = ValidarNota(Console.ReadLine(), 30);

                Console.WriteLine("Ingrese la nota del segundo parcial (máximo 30):");
                asignatura.N2 = ValidarNota(Console.ReadLine(), 30);

                Console.WriteLine("Ingrese la nota del tercer parcial (máximo 40):");
                asignatura.N3 = ValidarNota(Console.ReadLine(), 40);

                
                asignatura.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

      
        static int ValidarNota(string input, int maxNota)
        {
            if (!int.TryParse(input, out int nota) || nota < 0 || nota > maxNota)
            {
                throw new ArgumentException($"La nota ingresada no es válida. Debe ser un valor entre 0 y {maxNota}.");
            }
            return nota;
        }
    }

}