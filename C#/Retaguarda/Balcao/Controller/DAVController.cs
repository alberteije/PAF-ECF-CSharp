/********************************************************************************
Title: AlbertEijePDV
Description: Classe de controle do DAV

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
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PafEcf.VO;
using Balcao.Infra;
using Balcao.Util;

namespace Balcao.Controller
{

    public class DAVController
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataReader leitor;
        public string ConsultaSQL;

        public DAVController()
        {
            conexao = dbConnection.conectarRetaguarda();
        }


        //TODO: Leitor - Estude o DAVController do Caixa e grave os Hahs: HASH_TRIPA e HASH_INCREMENTO no procedimento abaixo.
        public void InsereDAV(DavCabecalhoVO DAVCabecalho, List<DavDetalheVO> ListaDAVDetalhe)
        {
            string Tripa, Hash;
            string NumeroUltimoDav, NumeroNovoDav;

            // insere o novo dav no cabecalho
            ConsultaSQL =
                "insert into DAV_CABECALHO (" +
                "NUMERO_DAV," +
                "ID_EMPRESA," +
                "NOME_DESTINATARIO," +
                "CPF_CNPJ_DESTINATARIO," +
                "DATA_EMISSAO," +
                "HORA_EMISSAO," +
                "SITUACAO," +
                "SUBTOTAL," +
                "VALOR" +
                ") values (" +
                "?pNumeroDav," +
                "?pIdEmpresa," +
                "?pDestinatario," +
                "?pCPFCNPJ," +
                "?pDataEmissao," +
                "?pHoraEmissao," +
                "?pSituacao," +
                "?pSubTotal," +
                "?pValor)";
            try
            {

                comando = new MySqlCommand("select NUMERO_DAV from DAV_CABECALHO where id = (select max(id) from dav_cabecalho)", conexao);
                leitor = comando.ExecuteReader();
                leitor.Read();
                NumeroUltimoDav = Convert.ToString(leitor["NUMERO_DAV"]);

                if ((NumeroUltimoDav == "") || (NumeroUltimoDav == "9999999999"))
                    NumeroNovoDav = "0000000001";
                else
                {
                    NumeroNovoDav = (Convert.ToInt32(NumeroUltimoDav) + 1).ToString();
                    NumeroNovoDav = new string('0', 10 - NumeroNovoDav.Length) + NumeroNovoDav;
                }

                leitor.Close();

                comando = new MySqlCommand(ConsultaSQL, conexao);
                comando.Parameters.AddWithValue("?pNumeroDav", NumeroNovoDav);
                comando.Parameters.AddWithValue("?pIdEmpresa", DAVCabecalho.IdEmpresa);
                comando.Parameters.AddWithValue("?pDestinatario", DAVCabecalho.NomeDestinatario);
                comando.Parameters.AddWithValue("?pCPFCNPJ", DAVCabecalho.CpfCnpjDestinatario);
                comando.Parameters.AddWithValue("?pDataEmissao", DAVCabecalho.DataEmissao);
                comando.Parameters.AddWithValue("?pHoraEmissao", DAVCabecalho.HoraEmissao);
                comando.Parameters.AddWithValue("?pSituacao", DAVCabecalho.Situacao);
                comando.Parameters.AddWithValue("?pSubTotal", DAVCabecalho.Subtotal);
                comando.Parameters.AddWithValue("?pValor", DAVCabecalho.Valor);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("select max(ID) as ID from DAV_CABECALHO", conexao);
                leitor = comando.ExecuteReader();
                leitor.Read();
                DAVCabecalho.Id = Convert.ToInt32(leitor["ID"]);
            }
            catch (Exception eError)
            {
                Log.write(eError.ToString());
            }
            finally
            {
                if (leitor != null)
                    leitor.Close();
            }


            // insere os dados na tabela de detalhes
            ConsultaSQL =
              "insert into DAV_DETALHE (" +
              "ID_PRODUTO," +
              "ID_DAV_CABECALHO," +
              "NUMERO_DAV," +
              "DATA_EMISSAO," +
              "ITEM," +
              "QUANTIDADE," +
              "VALOR_UNITARIO," +
              "VALOR_TOTAL," +
              "CANCELADO," +
              "MESCLA_PRODUTO," +
              "GTIN_PRODUTO," +
              "NOME_PRODUTO," +
              "TOTALIZADOR_PARCIAL," +
              "UNIDADE_PRODUTO) values (" +
              "?pIdProduto," +
              "?pIdDavCabecalho," +
              "?pNumeroDav," +
              "?pDataEmissao," +
              "?pItem," +
              "?pQuantidade," +
              "?pValorUnitario," +
              "?pValorTotal," +
              "?pCancelado," +
              "?pMesclaProduto," +
              "?pGtinProduto," +
              "?pNomeProduto," +
              "?pTOTALIZADOR_PARCIAL," +
              "?pUnidadeProduto)";
            try
            {

                for (int i = 0; i <= ListaDAVDetalhe.Count - 1; i++)
                {
                    comando = new MySqlCommand(ConsultaSQL, conexao);
                    comando.Parameters.AddWithValue("?pIdProduto", ListaDAVDetalhe[i].IdProduto);
                    comando.Parameters.AddWithValue("?pIdDavCabecalho", DAVCabecalho.Id);
                    comando.Parameters.AddWithValue("?pNumeroDav", ListaDAVDetalhe[i].NumeroDav);
                    comando.Parameters.AddWithValue("?pDataEmissao", new DateTime()); //DateTime.Now.ToString("yyyy-mm-dd")
                    comando.Parameters.AddWithValue("?pItem", ListaDAVDetalhe[i].Item);
                    comando.Parameters.AddWithValue("?pQuantidade", ListaDAVDetalhe[i].Quantidade);
                    comando.Parameters.AddWithValue("?pValorUnitario", ListaDAVDetalhe[i].ValorUnitario);
                    comando.Parameters.AddWithValue("?pValorTotal", ListaDAVDetalhe[i].ValorTotal);
                    comando.Parameters.AddWithValue("?pCancelado", ListaDAVDetalhe[i].Cancelado);
                    comando.Parameters.AddWithValue("?pMesclaProduto", ListaDAVDetalhe[i].MesclaProduto);
                    comando.Parameters.AddWithValue("?pGtinProduto", ListaDAVDetalhe[i].GtinProduto);
                    comando.Parameters.AddWithValue("?pNomeProduto", ListaDAVDetalhe[i].NomeProduto);
                    comando.Parameters.AddWithValue("?pUnidadeProduto", ListaDAVDetalhe[i].UnidadeProduto);
                    comando.Parameters.AddWithValue("?pTOTALIZADOR_PARCIAL", ListaDAVDetalhe[i].TotalizadorParcial);
                    comando.Parameters.AddWithValue("?pHashIncremento", 0);
                    comando.Parameters.AddWithValue("?pHashTripa", "");
                    comando.ExecuteNonQuery();
                }


            }
            catch (Exception eError)
            {
                Log.write(eError.ToString());
            }
            finally
            {
                if (leitor != null)
                    leitor.Close();
            }
        }


        public List<DavCabecalhoVO> TabelaDavCabecalho()
        {
            List<DavCabecalhoVO> ListaDavCabecalho = new List<DavCabecalhoVO>();

            ConsultaSQL = " SELECT * FROM DAV_CABECALHO WHERE SITUACAO = 'P' ORDER BY ID";

            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    DavCabecalhoVO DavCabecalho = new DavCabecalhoVO();

                    DavCabecalho.Id = Convert.ToInt32(leitor["ID"]);
                    DavCabecalho.NumeroDav = leitor["NUMERO_DAV"].ToString();
                    DavCabecalho.NomeDestinatario = leitor["NOME_DESTINATARIO"].ToString();
                    DavCabecalho.CpfCnpjDestinatario = leitor["CPF_CNPJ_DESTINATARIO"].ToString();
                    DavCabecalho.DataEmissao = Convert.ToDateTime(leitor["DATA_EMISSAO"]);
                    DavCabecalho.HoraEmissao = leitor["HORA_EMISSAO"].ToString();
                    DavCabecalho.Valor = Convert.IsDBNull(leitor["VALOR"]) ? 0 : Convert.ToDecimal(leitor["VALOR"]);

                    ListaDavCabecalho.Add(DavCabecalho);
                }
                return ListaDavCabecalho;
            }

            catch (Exception eError)
            {
                Log.write(eError.ToString());
                return null;
            }
            finally
            {
                if (leitor != null)
                    leitor.Close();
            }
        }


        public List<DavDetalheVO> TabelaDavDetalhe(string pIdCabecalho)
        {
            List<DavDetalheVO> ListaDavDetalhe = new List<DavDetalheVO>();

            ConsultaSQL = " SELECT * FROM DAV_DETALHE WHERE ID_DAV_CABECALHO = " + pIdCabecalho;

            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    DavDetalheVO DavDetalhe = new DavDetalheVO();

                    DavDetalhe.Id = Convert.ToInt32(leitor["ID"]);
                    DavDetalhe.NomeProduto = leitor["NOME_PRODUTO"].ToString();
                    DavDetalhe.Quantidade = Convert.ToDecimal(leitor["QUANTIDADE"]);
                    DavDetalhe.ValorUnitario = Convert.ToDecimal(leitor["VALOR_UNITARIO"]);
                    DavDetalhe.ValorTotal = Convert.ToDecimal(leitor["VALOR_TOTAL"]);

                    ListaDavDetalhe.Add(DavDetalhe);
                }
                return ListaDavDetalhe;
            }

            catch (Exception eError)
            {
                Log.write(eError.ToString());
                return null;
            }
            finally
            {
                if (leitor != null)
                    leitor.Close();
            }
        }

    }

}
