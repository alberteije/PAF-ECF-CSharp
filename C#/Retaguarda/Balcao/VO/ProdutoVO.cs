/********************************************************************************
Title: AlbertEijePDV
Description: VO relacionado à tabela PRODUTO

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


    public class ProdutoVO
    {


        private int FID;
        private int FID_UNIDADE_PRODUTO;
        private string FGTIN;
        private string FCODIGO_INTERNO;
        private string FNOME;
        private string FDESCRICAO;
        private string FDESCRICAO_PDV;
        private decimal FVALOR_VENDA;
        private decimal FQTD_ESTOQUE;
        private decimal FQTD_ESTOQUE_ANTERIOR;
        private decimal FESTOQUE_MIN;
        private decimal FESTOQUE_MAX;
        private string FIAT;
        private string FIPPT;
        private string FNCM;
        private string FTIPO_ITEM_SPED;
        private DateTime FDATA_ESTOQUE;
        private decimal FTAXA_IPI;
        private decimal FTAXA_ISSQN;
        private decimal FTAXA_PIS;
        private decimal FTAXA_COFINS;
        private decimal FTAXA_ICMS;
        private string FCST;
        private string FCSOSN;
        private string FTOTALIZADOR_PARCIAL;
        private string FECF_ICMS_ST;
        private int FCODIGO_BALANCA;
        private string FPAF_P_ST;
        private string FHASH_TRIPA;
        private int FHASH_INCREMENTO;

        private string FUnidadeProduto;
        private string FPodeFracionarUnidade;


        public int Id
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


        public int IdUnidade
        {
            get
            {
                return FID_UNIDADE_PRODUTO;
            }
            set
            {
                FID_UNIDADE_PRODUTO = value;
            }
        }


        public String GTIN
        {
            get
            {
                return FGTIN;
            }
            set
            {
                FGTIN = value;
            }
        }


        public String CodigoInterno
        {
            get
            {
                return FCODIGO_INTERNO;
            }
            set
            {
                FCODIGO_INTERNO = value;
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


        public String Descricao
        {
            get
            {
                return FDESCRICAO;
            }
            set
            {
                FDESCRICAO = value;
            }
        }


        public String DescricaoPDV
        {
            get
            {
                return FDESCRICAO_PDV;
            }
            set
            {
                FDESCRICAO_PDV = value;
            }
        }


        public decimal ValorVenda
        {
            get
            {
                return FVALOR_VENDA;
            }
            set
            {
                FVALOR_VENDA = value;
            }
        }


        public decimal QtdeEstoque
        {
            get
            {
                return FQTD_ESTOQUE;
            }
            set
            {
                FQTD_ESTOQUE = value;
            }
        }


        public decimal QtdeEstoqueAnterior
        {
            get
            {
                return FQTD_ESTOQUE_ANTERIOR;
            }
            set
            {
                FQTD_ESTOQUE_ANTERIOR = value;
            }
        }


        public decimal EstoqueMinimo
        {
            get
            {
                return FESTOQUE_MIN;
            }
            set
            {
                FESTOQUE_MIN = value;
            }
        }


        public decimal EstoqueMaximo
        {
            get
            {
                return FESTOQUE_MAX;
            }
            set
            {
                FESTOQUE_MAX = value;
            }
        }


        public String IAT
        {
            get
            {
                return FIAT;
            }
            set
            {
                FIAT = value;
            }
        }


        public String IPPT
        {
            get
            {
                return FIPPT;
            }
            set
            {
                FIPPT = value;
            }
        }


        public String NCM
        {
            get
            {
                return FNCM;
            }
            set
            {
                FNCM = value;
            }
        }


        public String TipoItemSped
        {
            get
            {
                return FTIPO_ITEM_SPED;
            }
            set
            {
                FTIPO_ITEM_SPED = value;
            }
        }


        public DateTime DataEstoque
        {
            get
            {
                return FDATA_ESTOQUE;
            }
            set
            {
                FDATA_ESTOQUE = value;
            }
        }


        public decimal AliquotaIPI
        {
            get
            {
                return FTAXA_IPI;
            }
            set
            {
                FTAXA_IPI = value;
            }
        }


        public decimal AliquotaISSQN
        {
            get
            {
                return FTAXA_ISSQN;
            }
            set
            {
                FTAXA_ISSQN = value;
            }
        }


        public decimal AliquotaPIS
        {
            get
            {
                return FTAXA_PIS;
            }
            set
            {
                FTAXA_PIS = value;
            }
        }


        public decimal AliquotaCOFINS
        {
            get
            {
                return FTAXA_COFINS;
            }
            set
            {
                FTAXA_COFINS = value;
            }
        }


        public decimal AliquotaICMS
        {
            get
            {
                return FTAXA_ICMS;
            }
            set
            {
                FTAXA_ICMS = value;
            }
        }


        public String Cst
        {
            get
            {
                return FCST;
            }
            set
            {
                FCST = value;
            }
        }


        public String Csosn
        {
            get
            {
                return FCSOSN;
            }
            set
            {
                FCSOSN = value;
            }
        }


        public String TotalizadorParcial
        {
            get
            {
                return FTOTALIZADOR_PARCIAL;
            }
            set
            {
                FTOTALIZADOR_PARCIAL = value;
            }
        }


        public String ECFICMS
        {
            get
            {
                return FECF_ICMS_ST;
            }
            set
            {
                FECF_ICMS_ST = value;
            }
        }


        public int CodigoBalanca
        {
            get
            {
                return FCODIGO_BALANCA;
            }
            set
            {
                FCODIGO_BALANCA = value;
            }
        }


        public String PafProdutoST
        {
            get
            {
                return FPAF_P_ST;
            }
            set
            {
                FPAF_P_ST = value;
            }
        }


        public String HashTripa
        {
            get
            {
                return FHASH_TRIPA;
            }
            set
            {
                FHASH_TRIPA = value;
            }
        }


        public int HashIncremento
        {
            get
            {
                return FHASH_INCREMENTO;
            }
            set
            {
                FHASH_INCREMENTO = value;
            }
        }



        public String UnidadeProduto
        {
            get
            {
                return FUnidadeProduto;
            }
            set
            {
                FUnidadeProduto = value;
            }
        }


        public String PodeFracionarUnidade
        {
            get
            {
                return FPodeFracionarUnidade;
            }
            set
            {
                FPodeFracionarUnidade = value;
            }
        }


    }

}
