namespace Departamento
{
    public class depto
    {
        public string Name { get; set; }
        public int population { get; set; }
        public depto(string n, int poblacion)
        {
            Name = n;
            population = poblacion;

        }
    }
}