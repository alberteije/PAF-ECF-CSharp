/********************************************************************************
Title: AlbertEijePDV
Description: VO relacionado à tabela CLIENTE

The MIT License

Copyright: Copyright (C) 2012 Albert Eije

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.

       The author may be contacted at:
           alberteije@gmail.com

@author Albert Eije
@version 1.0
********************************************************************************/


using System;

namespace PafEcf.VO
{


    public class ClienteVO
    {


        private int? FID;
        private int? FID_SITUACAO_CLIENTE;
        private string FNOME;
        private string FFANTASIA;
        private string FEMAIL;
        private string FCPF_CNPJ;
        private string FRG;
        private string FORGAO_RG;
        private DateTime? FDATA_EMISSAO_RG;
        private string FSEXO;
        private string FINSCRICAO_ESTADUAL;
        private string FINSCRICAO_MUNICIPAL;
        private string FTIPO_PESSOA;
        private DateTime? FDATA_CADASTRO;
        private string FCONTATO;
        private string FLOGRADOURO;
        private string FNUMERO;
        private string FCOMPLEMENTO;
        private string FCEP;
        private string FBAIRRO;
        private string FCIDADE;
        private string FUF;
        private string FFONE1;
        private string FFONE2;
        private string FCELULAR;
        private int? FCODIGO_IBGE_CIDADE;
        private int? FCODIGO_IBGE_UF;


        public int? Id
        {
            get
            {
                return FID;
            }
            set
            {
                FID = value;
            }
        }


        public int? IdSituacaoCliente
        {
            get
            {
                return FID_SITUACAO_CLIENTE;
            }
            set
            {
                FID_SITUACAO_CLIENTE = value;
            }
        }


        public String Nome
        {
            get
            {
                return FNOME;
            }
            set
            {
                FNOME = value;
            }
        }


        public String Fantasia
        {
            get
            {
                return FFANTASIA;
            }
            set
            {
                FFANTASIA = value;
            }
        }


        public String Email
        {
            get
            {
                return FEMAIL;
            }
            set
            {
                FEMAIL = value;
            }
        }


        public String CpfOuCnpj
        {
            get
            {
                return FCPF_CNPJ;
            }
            set
            {
                FCPF_CNPJ = value;
            }
        }


        public String Rg
        {
            get
            {
                return FRG;
            }
            set
            {
                FRG = value;
            }
        }


        public String OrgaoRg
        {
            get
            {
                return FORGAO_RG;
            }
            set
            {
                FORGAO_RG = value;
            }
        }


        public DateTime? DataEmissaoRg
        {
            get
            {
                return FDATA_EMISSAO_RG;
            }
            set
            {
                FDATA_EMISSAO_RG = value;
            }
        }


        public String Sexo
        {
            get
            {
                return FSEXO;
            }
            set
            {
                FSEXO = value;
            }
        }


        public String InscricaoEstadual
        {
            get
            {
                return FINSCRICAO_ESTADUAL;
            }
            set
            {
                FINSCRICAO_ESTADUAL = value;
            }
        }


        public String InscricaoMunicipal
        {
            get
            {
                return FINSCRICAO_MUNICIPAL;
            }
            set
            {
                FINSCRICAO_MUNICIPAL = value;
            }
        }


        public String TipoPessoa
        {
            get
            {
                return FTIPO_PESSOA;
            }
            set
            {
                FTIPO_PESSOA = value;
            }
        }


        public DateTime? DataCadastro
        {
            get
            {
                return FDATA_CADASTRO;
            }
            set
            {
                FDATA_CADASTRO = value;
            }
        }


        public String Contato
        {
            get
            {
                return FCONTATO;
            }
            set
            {
                FCONTATO = value;
            }
        }


        public String Logradouro
        {
            get
            {
                return FLOGRADOURO;
            }
            set
            {
                FLOGRADOURO = value;
            }
        }


        public String Numero
        {
            get
            {
                return FNUMERO;
            }
            set
            {
                FNUMERO = value;
            }
        }


        public String Complemento
        {
            get
            {
                return FCOMPLEMENTO;
            }
            set
            {
                FCOMPLEMENTO = value;
            }
        }


        public String Cep
        {
            get
            {
                return FCEP;
            }
            set
            {
                FCEP = value;
            }
        }


        public String Bairro
        {
            get
            {
                return FBAIRRO;
            }
            set
            {
                FBAIRRO = value;
            }
        }


        public String Cidade
        {
            get
            {
                return FCIDADE;
            }
            set
            {
                FCIDADE = value;
            }
        }


        public String Uf
        {
            get
            {
                return FUF;
            }
            set
            {
                FUF = value;
            }
        }


        public String Fone1
        {
            get
            {
                return FFONE1;
            }
            set
            {
                FFONE1 = value;
            }
        }


        public String Fone2
        {
            get
            {
                return FFONE2;
            }
            set
            {
                FFONE2 = value;
            }
        }


        public String Celular
        {
            get
            {
                return FCELULAR;
            }
            set
            {
                FCELULAR = value;
            }
        }


        public int? CodigoIbgeCidade
        {
            get
            {
                return FCODIGO_IBGE_CIDADE;
            }
            set
            {
                FCODIGO_IBGE_CIDADE = value;
            }
        }


        public int? CodigoIbgeUf
        {
            get
            {
                return FCODIGO_IBGE_UF;
            }
            set
            {
                FCODIGO_IBGE_UF = value;
            }
        }


    }

}

