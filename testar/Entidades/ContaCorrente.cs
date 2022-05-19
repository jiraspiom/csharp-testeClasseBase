
namespace testar.Entidades
{
    internal class ContaCorrente : Conta
    {
        private string _novidadeCC { get; set; }

        public ContaCorrente(int numeroConta, string nomeBancoConta, string novidade) : base(numeroConta, nomeBancoConta)
        {
            _novidadeCC = novidade;
        }

        public override string ToString()
        {
            return
                $"Número da conta: {_numeroConta}, \n" +
                $"Nome do banco: {_nomeBancoConta}, \n" +
                $"Obs: {_novidadeCC} \n";

        }
    }
}
