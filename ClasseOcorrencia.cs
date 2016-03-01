using System.Collections.Generic;

namespace PhoneAppPI
{
    class Ocorrencia
    {
        public string ocorrencia;
        public List<string> passos;
        public Ocorrencia()
        {

        }
        public Ocorrencia(string nome)
        {
            passos = new List<string>();
            ocorrencia = nome;
        }

        public void AddPasso(string passo)
        {
            passos.Add(passo);
        }

    }
}
