namespace Examen
{
    public class Asignatura : Alumno , IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        // Constructor
        public Asignatura(string nombreAlumno, string numeroCuenta, string email, string nombreAsignatura, string horario, string nombreDocente)
        {
            NombreAlumno = nombreAlumno;
            NumeroCuenta = numeroCuenta;
            Email = email;
            NombreAsignatura = nombreAsignatura;
            Horario = horario;
            NombreDocente = nombreDocente;
        }

        // Método para calcular la nota final usando las propiedades N1, N2 y N3
        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        // Método para calcular la nota final usando parámetros
        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        // Método que retorna un mensaje según la nota final
        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal >= 90)
                return "Sobresaliente";
            else if (notaFinal >= 80)
                return "Muy Bueno";
            else if (notaFinal >= 60)
                return "Bueno";
            else
                return "Reprobado";
        }

        // Método para imprimir los datos del alumno, asignatura y nota final
        public void Imprimir()
        {
            double notaFinal = CalcularNotaFinal();
            Console.WriteLine($"Alumno: {NombreAlumno}");
            Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Asignatura: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Docente: {NombreDocente}");
            Console.WriteLine($"Nota Final (usando propiedades): {notaFinal} - {MensajeNotaFinal(notaFinal)}");

            double notaFinalConParametros = CalcularNotaFinal(N1, N2, N3);
            Console.WriteLine($"Nota Final (usando parámetros): {notaFinalConParametros} - {MensajeNotaFinal(notaFinalConParametros)}");
        }
    }
}

       

