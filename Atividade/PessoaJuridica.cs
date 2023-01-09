namespace Atividade
{
    public class PessoaJuridica : Clientes
    {
        public string? Cnpj { get; set; }

        public string? Ie { get; set; }

        override
        public void PagarImposto(float v){
            this.Valor = v;
            this.ValorImposto = this.Valor *20/100;
            this.ValorFinal = this.Valor + this.ValorImposto;
        }
    }
}