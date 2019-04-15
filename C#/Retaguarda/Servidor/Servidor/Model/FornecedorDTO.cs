using System;
using System.Text;
using System.Collections.Generic;


namespace Servidor.Model {
    
    public class FornecedorDTO {
        public FornecedorDTO() { }
        public int Id { get; set; }
        public PessoaDTO Pessoa { get; set; }
        public AtividadeForCliDTO AtividadeForCli { get; set; }
        public SituacaoForCliDTO SituacaoForCli { get; set; }
        public System.Nullable<System.DateTime> Desde { get; set; }
        public string OptanteSimplesNacional { get; set; }
        public string Localizacao { get; set; }
        public System.Nullable<System.DateTime> DataCadastro { get; set; }
        public string SofreRetencao { get; set; }
        public string ChequeNominalA { get; set; }
        public string Observacao { get; set; }
        public string ContaRemetente { get; set; }
        public System.Nullable<int> PrazoMedioEntrega { get; set; }
        public string GeraFaturamento { get; set; }
        public System.Nullable<int> NumDiasPrimeiroVencimento { get; set; }
        public System.Nullable<int> NumDiasIntervalo { get; set; }
        public System.Nullable<int> QuantidadeParcelas { get; set; }
    }
}
