using ExemploSolid.DIP.Solucao.Interfaces;

namespace ExemploSolid.DIP.Solucao
{
    public class CPFServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}