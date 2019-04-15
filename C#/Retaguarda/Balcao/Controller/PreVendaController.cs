/********************************************************************************
Title: AlbertEijePDV
Description: Classe de controle da pre-venda

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

    public class PreVendaController
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataReader leitor;
        public string ConsultaSQL;

        public PreVendaController()
        {
            conexao = dbConnection.conectarRetaguarda();
        }


        public void InserePreVenda(PreVendaCabecalhoVO PreVendaCabecalho, List<PreVendaDetalheVO> ListaPreVendaDetalhe)
        {

            // insere o novo PreVenda no cabecalho
            ConsultaSQL =
                "insert into PRE_VENDA_CABECALHO (" +
                "ID_EMPRESA," +
                "NOME_DESTINATARIO," +
                "CPF_CNPJ_DESTINATARIO," +
                "DATA_PV," +
                "HORA_PV," +
                "SITUACAO," +
                "SUBTOTAL," +
                "VALOR" +
                ") values (" +
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

                comando = new MySqlCommand(ConsultaSQL, conexao);
                comando.Parameters.AddWithValue("?pIdEmpresa", PreVendaCabecalho.IdEmpresa);
                comando.Parameters.AddWithValue("?pDestinatario", PreVendaCabecalho.NomeDestinatario);
                comando.Parameters.AddWithValue("?pCPFCNPJ", PreVendaCabecalho.CpfCnpjDestinatario);
                comando.Parameters.AddWithValue("?pDataEmissao", PreVendaCabecalho.DataEmissao);
                comando.Parameters.AddWithValue("?pHoraEmissao", PreVendaCabecalho.HoraEmissao);
                comando.Parameters.AddWithValue("?pSituacao", PreVendaCabecalho.Situacao);
                comando.Parameters.AddWithValue("?pSubTotal", PreVendaCabecalho.SubTotal);
                comando.Parameters.AddWithValue("?pValor", PreVendaCabecalho.Valor);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("select max(ID) as ID from PRE_VENDA_CABECALHO", conexao);
                leitor = comando.ExecuteReader();
                leitor.Read();
                PreVendaCabecalho.Id = Convert.ToInt32(leitor["ID"]);
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
              "insert into PRE_VENDA_DETALHE (" +
              "ID_PRODUTO," +
              "ID_PRE_VENDA_CABECALHO," +
              "ITEM," +
              "QUANTIDADE," +
              "VALOR_UNITARIO," +
              "VALOR_TOTAL," +
              "CANCELADO," +
              "GTIN_PRODUTO," +
              "NOME_PRODUTO," +
              "UNIDADE_PRODUTO) values (" +
              "?pIdProduto," +
              "?pIdPreVendaCabecalho," +
              "?pItem," +
              "?pQuantidade," +
              "?pValorUnitario," +
              "?pValorTotal," +
              "?pCancelado," +
              "?pGtinProduto," +
              "?pNomeProduto," +
             "?pUnidadeProduto)";
            try
            {

                for (int i = 0; i <= ListaPreVendaDetalhe.Count - 1; i++)
                {
                    comando = new MySqlCommand(ConsultaSQL, conexao);
                    comando.Parameters.AddWithValue("?pIdProduto", ListaPreVendaDetalhe[i].IdProduto);
                    comando.Parameters.AddWithValue("?pIdPreVendaCabecalho", PreVendaCabecalho.Id);
                    comando.Parameters.AddWithValue("?pItem", ListaPreVendaDetalhe[i].Item);
                    comando.Parameters.AddWithValue("?pQuantidade", ListaPreVendaDetalhe[i].Quantidade);
                    comando.Parameters.AddWithValue("?pValorUnitario", ListaPreVendaDetalhe[i].ValorUnitario);
                    comando.Parameters.AddWithValue("?pValorTotal", ListaPreVendaDetalhe[i].ValorTotal);
                    comando.Parameters.AddWithValue("?pCancelado", ListaPreVendaDetalhe[i].Cancelado);
                    comando.Parameters.AddWithValue("?pGtinProduto", ListaPreVendaDetalhe[i].GtinProduto);
                    comando.Parameters.AddWithValue("?pNomeProduto", ListaPreVendaDetalhe[i].NomeProduto);
                    comando.Parameters.AddWithValue("?pUnidadeProduto", ListaPreVendaDetalhe[i].UnidadeProduto);
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


        public List<PreVendaCabecalhoVO> TabelaPreVendaCabecalho()
        {
            List<PreVendaCabecalhoVO> ListaPreVendaCabecalho = new List<PreVendaCabecalhoVO>();

            ConsultaSQL = " SELECT * FROM PRE_VENDA_CABECALHO WHERE SITUACAO = 'P' ORDER BY ID";

            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    PreVendaCabecalhoVO PreVendaCabecalho = new PreVendaCabecalhoVO();

                    PreVendaCabecalho.Id = Convert.ToInt32(leitor["ID"]);
                    PreVendaCabecalho.DataEmissao = Convert.ToDateTime(leitor["DATA_PV"]);
                    PreVendaCabecalho.HoraEmissao = leitor["HORA_PV"].ToString();
                    PreVendaCabecalho.Valor = Convert.IsDBNull(leitor["VALOR"]) ? 0 : Convert.ToDecimal(leitor["VALOR"]);

                    ListaPreVendaCabecalho.Add(PreVendaCabecalho);
                }
                return ListaPreVendaCabecalho;
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


        public List<PreVendaDetalheVO> TabelaPreVendaDetalhe(string pIdCabecalho)
        {
            List<PreVendaDetalheVO> ListaPreVendaDetalhe = new List<PreVendaDetalheVO>();

            ConsultaSQL = " SELECT * FROM PRE_VENDA_DETALHE WHERE ID_PRE_VENDA_CABECALHO = " + pIdCabecalho;

            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    PreVendaDetalheVO PreVendaDetalhe = new PreVendaDetalheVO();

                    PreVendaDetalhe.Id = Convert.ToInt32(leitor["ID"]);
                    PreVendaDetalhe.NomeProduto = leitor["NOME_PRODUTO"].ToString();
                    PreVendaDetalhe.Quantidade = Convert.ToDecimal(leitor["QUANTIDADE"]);
                    PreVendaDetalhe.ValorUnitario = Convert.ToDecimal(leitor["VALOR_UNITARIO"]);
                    PreVendaDetalhe.ValorTotal = Convert.ToDecimal(leitor["VALOR_TOTAL"]);

                    ListaPreVendaDetalhe.Add(PreVendaDetalhe);
                }
                return ListaPreVendaDetalhe;
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