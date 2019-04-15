/********************************************************************************
Title: AlbertEijePDV
Description: VO relacionado à tabela UNIDADE_PRODUTO

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


    public class UnidadeProdutoVO
    {


        private int FID;
        private string FNOME;
        private string FDESCRICAO;
        private string FPODE_FRACIONAR;


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


        public String PodeFracionar
        {
            get
            {
                return FPODE_FRACIONAR;
            }
            set
            {
                FPODE_FRACIONAR = value;
            }
        }


    }


}