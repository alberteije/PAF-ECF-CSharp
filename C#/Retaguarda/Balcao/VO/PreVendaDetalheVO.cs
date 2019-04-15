/********************************************************************************
Title: AlbertEijePDV
Description: VO relacionado à tabela PRE_VENDA_DETALHE

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


    public class PreVendaDetalheVO
    {


        private int FID;
        private int FID_PRODUTO;
        private int FID_ECF_PRE_VENDA_CABECALHO;
        private int FITEM;
        private decimal FQUANTIDADE;
        private decimal FVALOR_UNITARIO;
        private decimal FVALOR_TOTAL;
        private string FCANCELADO;
        private string FGTIN_PRODUTO;
        private string FNOME_PRODUTO;
        private string FUNIDADE_PRODUTO;

        private string FECF_ICMS_ST;



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


        public int IdProduto
        {
            get
            {
                return FID_PRODUTO;
            }
            set
            {
                FID_PRODUTO = value;
            }
        }


        public int IdPreVenda
        {
            get
            {
                return FID_ECF_PRE_VENDA_CABECALHO;
            }
            set
            {
                FID_ECF_PRE_VENDA_CABECALHO = value;
            }
        }


        public int Item
        {
            get
            {
                return FITEM;
            }
            set
            {
                FITEM = value;
            }
        }


        public decimal Quantidade
        {
            get
            {
                return FQUANTIDADE;
            }
            set
            {
                FQUANTIDADE = value;
            }
        }


        public decimal ValorUnitario
        {
            get
            {
                return FVALOR_UNITARIO;
            }
            set
            {
                FVALOR_UNITARIO = value;
            }
        }


        public decimal ValorTotal
        {
            get
            {
                return FVALOR_TOTAL;
            }
            set
            {
                FVALOR_TOTAL = value;
            }
        }


        public string Cancelado
        {
            get
            {
                return FCANCELADO;
            }
            set
            {
                FCANCELADO = value;
            }
        }


        public String GtinProduto
        {
            get
            {
                return FGTIN_PRODUTO;
            }
            set
            {
                FGTIN_PRODUTO = value;
            }
        }


        public String NomeProduto
        {
            get
            {
                return FNOME_PRODUTO;
            }
            set
            {
                FNOME_PRODUTO = value;
            }
        }


        public String UnidadeProduto
        {
            get
            {
                return FUNIDADE_PRODUTO;
            }
            set
            {
                FUNIDADE_PRODUTO = value;
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


    }


}