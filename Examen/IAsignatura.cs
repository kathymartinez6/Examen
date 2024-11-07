namespace Examen
{
    public interface IAsignatura
    {
        double CalcularNotaFinal();
        double CalcularNotaFinal(double n1, double n2, double n3);
        string MensajeNotaFinal(double notaFinal);
        void Imprimir();
    }
}
