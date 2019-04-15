/********************************************************************************
Title: AlbertEijePDV
Description: Classe de controle do produto.

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


    public class ProdutoController
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataReader leitor;
        public string ConsultaSQL;
        public string ClausulaWhere;

        public ProdutoController()
        {
            conexao = dbConnection.conectarRetaguarda();
        }


        public ProdutoVO Consulta(string pCodigo, int pTipo)
        {
            switch (pTipo)
            {
                case 1:
                    {      //  pesquisa pelo codigo da balanca
                        ClausulaWhere = " where " +
                                        "(P.CODIGO_BALANCA = " + Biblioteca.QuotedStr(pCodigo) + ")" +
                                        " and (P.ID_UNIDADE_PRODUTO = U.ID)";
                    } break;
                case 2:
                    {     //  pesquisa pelo GTIN
                        ClausulaWhere = " where " +
                                        " (P.GTIN = " + Biblioteca.QuotedStr(pCodigo) + ")" +
                                        " and (P.ID_UNIDADE_PRODUTO = U.ID)";
                    } break;
                case 3:
                    {     //  pesquisa pelo CODIGO_INTERNO ou GTIN
                        ClausulaWhere = "where " +
                                        " ((P.CODIGO_INTERNO = " + Biblioteca.QuotedStr(pCodigo) + ")" +
                                        " or  (P.GTIN = " + Biblioteca.QuotedStr(pCodigo.Substring(14, 1)) + "))" +
                                        " and (P.ID_UNIDADE_PRODUTO = U.ID)";
                    } break;
                case 4:
                    {     //  pesquisa pelo Id
                        ClausulaWhere = "where " +
                                        " (P.ID = " + Biblioteca.QuotedStr(pCodigo) + ") " +
                                        " and (P.ID_UNIDADE_PRODUTO = U.ID) ";
                    } break;
                case 5:
                    {     //  pesquisa pelo Id
                        ClausulaWhere = "where " +
                                        " (P.NOME = " + Biblioteca.QuotedStr(pCodigo) + ") " +
                                        " and (P.ID_UNIDADE_PRODUTO = U.ID) ";
                    } break;
            }

            ConsultaSQL =
                            "select " +
                            " P.ID, " +
                            " P.ID_UNIDADE_PRODUTO, " +
                            " P.GTIN, " +
                            " P.CODIGO_INTERNO, " +
                            " P.NOME AS NOME_PRODUTO, " +
                            " P.DESCRICAO, " +
                            " P.DESCRICAO_PDV, " +
                            " P.VALOR_VENDA, " +
                            " P.QTD_ESTOQUE, " +
                            " P.QTD_ESTOQUE_ANTERIOR, " +
                            " P.ESTOQUE_MIN, " +
                            " P.ESTOQUE_MAX, " +
                            " P.IAT, " +
                            " P.IPPT, " +
                            " P.NCM, " +
                            " P.TIPO_ITEM_SPED, " +
                            " P.DATA_ESTOQUE, " +
                            " P.TAXA_IPI, " +
                            " P.TAXA_ISSQN, " +
                            " P.TAXA_PIS, " +
                            " P.TAXA_COFINS, " +
                            " P.TAXA_ICMS, " +
                            " P.CST, " +
                            " P.CSOSN, " +
                            " P.TOTALIZADOR_PARCIAL, " +
                            " P.ECF_ICMS_ST, " +
                            " P.CODIGO_BALANCA, " +
                            " P.PAF_P_ST, " +
                            " P.HASH_TRIPA, " +
                            " P.HASH_INCREMENTO, " +
                            " U.NOME AS NOME_UNIDADE, " +
                            " U.PODE_FRACIONAR " +
                            "from " +
                            " PRODUTO P, " +
                            " UNIDADE_PRODUTO U " +
                            ClausulaWhere;

            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    ProdutoVO Produto = new ProdutoVO();
                    Produto.Id = Convert.ToInt32(leitor["ID"]);
                    Produto.IdUnidade = Convert.ToInt32(leitor["ID_UNIDADE_PRODUTO"]);
                    Produto.GTIN = Convert.ToString(leitor["GTIN"]);
                    Produto.CodigoInterno = Convert.ToString(leitor["CODIGO_INTERNO"]);
                    Produto.Nome = Convert.ToString(leitor["NOME_PRODUTO"]);
                    Produto.Descricao = Convert.ToString(leitor["DESCRICAO"]);
                    Produto.DescricaoPDV = Convert.ToString(leitor["DESCRICAO_PDV"]);
                    Produto.ValorVenda = Convert.IsDBNull(leitor["VALOR_VENDA"]) ? 0 : Convert.ToDecimal(leitor["VALOR_VENDA"]);
                    Produto.QtdeEstoque = Convert.IsDBNull(leitor["QTD_ESTOQUE"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE"]);
                    Produto.QtdeEstoqueAnterior = Convert.IsDBNull(leitor["QTD_ESTOQUE_ANTERIOR"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE_ANTERIOR"]);
                    Produto.EstoqueMinimo = Convert.IsDBNull(leitor["ESTOQUE_MIN"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MIN"]);
                    Produto.EstoqueMaximo = Convert.IsDBNull(leitor["ESTOQUE_MAX"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MAX"]);
                    Produto.IAT = Convert.ToString(leitor["IAT"]);
                    Produto.IPPT = Convert.ToString(leitor["IPPT"]);
                    Produto.NCM = Convert.ToString(leitor["NCM"]);
                    Produto.TipoItemSped = Convert.ToString(leitor["TIPO_ITEM_SPED"]);
                    Produto.DataEstoque = Convert.IsDBNull(leitor["DATA_ESTOQUE"]) ? new DateTime() : (DateTime)(leitor["DATA_ESTOQUE"]);
                    Produto.AliquotaIPI = Convert.IsDBNull(leitor["TAXA_IPI"]) ? 0 : Convert.ToDecimal(leitor["TAXA_IPI"]);
                    Produto.AliquotaISSQN = Convert.IsDBNull(leitor["TAXA_ISSQN"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ISSQN"]);
                    Produto.AliquotaPIS = Convert.IsDBNull(leitor["TAXA_PIS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_PIS"]);
                    Produto.AliquotaCOFINS = Convert.IsDBNull(leitor["TAXA_COFINS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_COFINS"]);
                    Produto.AliquotaICMS = Convert.IsDBNull(leitor["TAXA_ICMS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ICMS"]);
                    Produto.Cst = Convert.ToString(leitor["CST"]);
                    Produto.Csosn = Convert.ToString(leitor["CSOSN"]);
                    Produto.TotalizadorParcial = Convert.ToString(leitor["TOTALIZADOR_PARCIAL"]);
                    Produto.ECFICMS = Convert.ToString(leitor["ECF_ICMS_ST"]);
                    Produto.CodigoBalanca = Convert.IsDBNull(leitor["CODIGO_BALANCA"]) ? 0 : Convert.ToInt32(leitor["CODIGO_BALANCA"]);
                    Produto.PafProdutoST = Convert.ToString(leitor["PAF_P_ST"]);
                    Produto.HashTripa = Convert.ToString(leitor["HASH_TRIPA"]);
                    Produto.HashIncremento = Convert.IsDBNull(leitor["HASH_INCREMENTO"]) ? 1 : Convert.ToInt32(leitor["HASH_INCREMENTO"]);
                    Produto.UnidadeProduto = Convert.ToString(leitor["NOME_UNIDADE"]);
                    Produto.PodeFracionarUnidade = Convert.ToString(leitor["PODE_FRACIONAR"]);
                    return Produto;
                }
                else
                {
                    return null;
                }
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


        public ProdutoVO ConsultaId(int pId)
        {
            ConsultaSQL =
                            "select " +
                            " P.ID, " +
                            " P.ID_UNIDADE_PRODUTO, " +
                            " P.GTIN, " +
                            " P.CODIGO_INTERNO, " +
                            " P.NOME AS NOME_PRODUTO, " +
                            " P.DESCRICAO, " +
                            " P.DESCRICAO_PDV, " +
                            " P.VALOR_VENDA, " +
                            " P.QTD_ESTOQUE, " +
                            " P.QTD_ESTOQUE_ANTERIOR, " +
                            " P.ESTOQUE_MIN, " +
                            " P.ESTOQUE_MAX, " +
                            " P.IAT, " +
                            " P.IPPT, " +
                            " P.NCM, " +
                            " P.TIPO_ITEM_SPED, " +
                            " P.DATA_ESTOQUE, " +
                            " P.TAXA_IPI, " +
                            " P.TAXA_ISSQN, " +
                            " P.TAXA_PIS, " +
                            " P.TAXA_COFINS, " +
                            " P.TAXA_ICMS, " +
                            " P.CST, " +
                            " P.CSOSN, " +
                            " P.TOTALIZADOR_PARCIAL, " +
                            " P.ECF_ICMS_ST, " +
                            " P.CODIGO_BALANCA, " +
                            " P.PAF_P_ST, " +
                            " P.HASH_TRIPA, " +
                            " P.HASH_INCREMENTO, " +
                            " U.NOME AS NOME_UNIDADE, " +
                            " U.PODE_FRACIONAR " +
                            "from " +
                            " PRODUTO P, " +
                            " UNIDADE_PRODUTO U " +
                            "where " +
                            " (P.ID = " + Convert.ToString(pId) + ") " +
                            " and (P.ID_UNIDADE_PRODUTO = U.ID) ";
            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    ProdutoVO Produto = new ProdutoVO();
                    Produto.Id = Convert.ToInt32(leitor["ID"]);
                    Produto.IdUnidade = Convert.ToInt32(leitor["ID_UNIDADE_PRODUTO"]);
                    Produto.GTIN = Convert.ToString(leitor["GTIN"]);
                    Produto.CodigoInterno = Convert.ToString(leitor["CODIGO_INTERNO"]);
                    Produto.Nome = Convert.ToString(leitor["NOME_PRODUTO"]);
                    Produto.Descricao = Convert.ToString(leitor["DESCRICAO"]);
                    Produto.DescricaoPDV = Convert.ToString(leitor["DESCRICAO_PDV"]);
                    Produto.ValorVenda = Convert.IsDBNull(leitor["VALOR_VENDA"]) ? 0 : Convert.ToDecimal(leitor["VALOR_VENDA"]);
                    Produto.QtdeEstoque = Convert.IsDBNull(leitor["QTD_ESTOQUE"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE"]);
                    Produto.QtdeEstoqueAnterior = Convert.IsDBNull(leitor["QTD_ESTOQUE_ANTERIOR"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE_ANTERIOR"]);
                    Produto.EstoqueMinimo = Convert.IsDBNull(leitor["ESTOQUE_MIN"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MIN"]);
                    Produto.EstoqueMaximo = Convert.IsDBNull(leitor["ESTOQUE_MAX"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MAX"]);
                    Produto.IAT = Convert.ToString(leitor["IAT"]);
                    Produto.IPPT = Convert.ToString(leitor["IPPT"]);
                    Produto.NCM = Convert.ToString(leitor["NCM"]);
                    Produto.TipoItemSped = Convert.ToString(leitor["TIPO_ITEM_SPED"]);
                    Produto.DataEstoque = Convert.IsDBNull(leitor["DATA_ESTOQUE"]) ? new DateTime() : (DateTime)(leitor["DATA_ESTOQUE"]);
                    Produto.AliquotaIPI = Convert.IsDBNull(leitor["TAXA_IPI"]) ? 0 : Convert.ToDecimal(leitor["TAXA_IPI"]);
                    Produto.AliquotaISSQN = Convert.IsDBNull(leitor["TAXA_ISSQN"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ISSQN"]);
                    Produto.AliquotaPIS = Convert.IsDBNull(leitor["TAXA_PIS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_PIS"]);
                    Produto.AliquotaCOFINS = Convert.IsDBNull(leitor["TAXA_COFINS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_COFINS"]);
                    Produto.AliquotaICMS = Convert.IsDBNull(leitor["TAXA_ICMS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ICMS"]);
                    Produto.Cst = Convert.ToString(leitor["CST"]);
                    Produto.Csosn = Convert.ToString(leitor["CSOSN"]);
                    Produto.TotalizadorParcial = Convert.ToString(leitor["TOTALIZADOR_PARCIAL"]);
                    Produto.ECFICMS = Convert.ToString(leitor["ECF_ICMS_ST"]);
                    Produto.CodigoBalanca = Convert.IsDBNull(leitor["CODIGO_BALANCA"]) ? 0 : Convert.ToInt32(leitor["CODIGO_BALANCA"]);
                    Produto.PafProdutoST = Convert.ToString(leitor["PAF_P_ST"]);
                    Produto.HashTripa = Convert.ToString(leitor["HASH_TRIPA"]);
                    Produto.HashIncremento = Convert.IsDBNull(leitor["HASH_INCREMENTO"]) ? 1 : Convert.ToInt32(leitor["HASH_INCREMENTO"]);
                    Produto.UnidadeProduto = Convert.ToString(leitor["NOME_UNIDADE"]);
                    Produto.PodeFracionarUnidade = Convert.ToString(leitor["PODE_FRACIONAR"]);
                    return Produto;
                }
                else
                {
                    return null;
                }
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


        public bool ConsultaIdProduto(int pId)
        {
            ConsultaSQL = "select ID from PRODUTO where ID = " + Convert.ToString(pId);
            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                leitor.Read();
                if (leitor.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            catch (Exception eError)
            {
                Log.write(eError.ToString());
                return false;
            }
            finally
            {
                if (leitor != null)
                    leitor.Close();
            }
        }


        public List<ProdutoVO> TabelaProduto()
        {
            ConsultaSQL =
                          "select " +
                          " P.ID, " +
                          " P.ID_UNIDADE_PRODUTO, " +
                          " P.GTIN, " +
                          " P.CODIGO_INTERNO, " +
                          " P.NOME AS NOME_PRODUTO, " +
                          " P.DESCRICAO, " +
                          " P.DESCRICAO_PDV, " +
                          " P.VALOR_VENDA, " +
                          " P.QTD_ESTOQUE, " +
                          " P.QTD_ESTOQUE_ANTERIOR, " +
                          " P.ESTOQUE_MIN, " +
                          " P.ESTOQUE_MAX, " +
                          " P.IAT, " +
                          " P.IPPT, " +
                          " P.NCM, " +
                          " P.TIPO_ITEM_SPED, " +
                          " P.DATA_ESTOQUE, " +
                          " P.TAXA_IPI, " +
                          " P.TAXA_ISSQN, " +
                          " P.TAXA_PIS, " +
                          " P.TAXA_COFINS, " +
                          " P.TAXA_ICMS, " +
                          " P.CST, " +
                          " P.CSOSN, " +
                          " P.TOTALIZADOR_PARCIAL, " +
                          " P.ECF_ICMS_ST, " +
                          " P.CODIGO_BALANCA, " +
                          " P.PAF_P_ST, " +
                          " P.HASH_TRIPA, " +
                          " P.HASH_INCREMENTO, " +
                          " U.NOME AS NOME_UNIDADE, " +
                          " U.PODE_FRACIONAR " +
                          "from " +
                          " PRODUTO P, UNIDADE_PRODUTO U " +
                          "where " +
                          " (P.ID_UNIDADE_PRODUTO = U.ID)";
            try
            {
                List<ProdutoVO> ListaProduto = new List<ProdutoVO>();

                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    ProdutoVO Produto = new ProdutoVO();

                    Produto.Id = Convert.ToInt32(leitor["ID"]);
                    Produto.IdUnidade = Convert.ToInt32(leitor["ID_UNIDADE_PRODUTO"]);
                    Produto.GTIN = Convert.ToString(leitor["GTIN"]);
                    Produto.CodigoInterno = Convert.ToString(leitor["CODIGO_INTERNO"]);
                    Produto.Nome = Convert.ToString(leitor["NOME_PRODUTO"]);
                    Produto.Descricao = Convert.ToString(leitor["DESCRICAO"]);
                    Produto.DescricaoPDV = Convert.ToString(leitor["DESCRICAO_PDV"]);
                    Produto.ValorVenda = Convert.IsDBNull(leitor["VALOR_VENDA"]) ? 0 : Convert.ToDecimal(leitor["VALOR_VENDA"]);
                    Produto.QtdeEstoque = Convert.IsDBNull(leitor["QTD_ESTOQUE"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE"]);
                    Produto.QtdeEstoqueAnterior = Convert.IsDBNull(leitor["QTD_ESTOQUE_ANTERIOR"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE_ANTERIOR"]);
                    Produto.EstoqueMinimo = Convert.IsDBNull(leitor["ESTOQUE_MIN"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MIN"]);
                    Produto.EstoqueMaximo = Convert.IsDBNull(leitor["ESTOQUE_MAX"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MAX"]);
                    Produto.IAT = Convert.ToString(leitor["IAT"]);
                    Produto.IPPT = Convert.ToString(leitor["IPPT"]);
                    Produto.NCM = Convert.ToString(leitor["NCM"]);
                    Produto.TipoItemSped = Convert.ToString(leitor["TIPO_ITEM_SPED"]);
                    Produto.DataEstoque = Convert.IsDBNull(leitor["DATA_ESTOQUE"]) ? new DateTime() : (DateTime)(leitor["DATA_ESTOQUE"]);
                    Produto.AliquotaIPI = Convert.IsDBNull(leitor["TAXA_IPI"]) ? 0 : Convert.ToDecimal(leitor["TAXA_IPI"]);
                    Produto.AliquotaISSQN = Convert.IsDBNull(leitor["TAXA_ISSQN"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ISSQN"]);
                    Produto.AliquotaPIS = Convert.IsDBNull(leitor["TAXA_PIS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_PIS"]);
                    Produto.AliquotaCOFINS = Convert.IsDBNull(leitor["TAXA_COFINS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_COFINS"]);
                    Produto.AliquotaICMS = Convert.IsDBNull(leitor["TAXA_ICMS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ICMS"]);
                    Produto.Cst = Convert.ToString(leitor["CST"]);
                    Produto.Csosn = Convert.ToString(leitor["CSOSN"]);
                    Produto.TotalizadorParcial = Convert.ToString(leitor["TOTALIZADOR_PARCIAL"]);
                    Produto.ECFICMS = Convert.ToString(leitor["ECF_ICMS_ST"]);
                    Produto.CodigoBalanca = Convert.IsDBNull(leitor["CODIGO_BALANCA"]) ? 0 : Convert.ToInt32(leitor["CODIGO_BALANCA"]);
                    Produto.PafProdutoST = Convert.ToString(leitor["PAF_P_ST"]);
                    Produto.HashTripa = Convert.ToString(leitor["HASH_TRIPA"]);
                    Produto.HashIncremento = Convert.IsDBNull(leitor["HASH_INCREMENTO"]) ? 1 : Convert.ToInt32(leitor["HASH_INCREMENTO"]);
                    Produto.UnidadeProduto = Convert.ToString(leitor["NOME_UNIDADE"]);
                    Produto.PodeFracionarUnidade = Convert.ToString(leitor["PODE_FRACIONAR"]);

                    ListaProduto.Add(Produto);
                }
                return ListaProduto;

            }

            catch (Exception eError)
            {
                Log.write(eError.ToString() + "[ GTIN=" + Convert.ToString(leitor["GTIN"]) + " ]");
                return null;
            }
            finally
            {
                if (leitor != null)
                    leitor.Close();
            }
        }

        public List<ProdutoVO> TabelaProduto(string pNome)
        {
            ConsultaSQL =
                          "select " +
                          " P.ID, " +
                          " P.ID_UNIDADE_PRODUTO, " +
                          " P.GTIN, " +
                          " P.CODIGO_INTERNO, " +
                          " P.NOME AS NOME_PRODUTO, " +
                          " P.DESCRICAO, " +
                          " P.DESCRICAO_PDV, " +
                          " P.VALOR_VENDA, " +
                          " P.QTD_ESTOQUE, " +
                          " P.QTD_ESTOQUE_ANTERIOR, " +
                          " P.ESTOQUE_MIN, " +
                          " P.ESTOQUE_MAX, " +
                          " P.IAT, " +
                          " P.IPPT, " +
                          " P.NCM, " +
                          " P.TIPO_ITEM_SPED, " +
                          " P.DATA_ESTOQUE, " +
                          " P.TAXA_IPI, " +
                          " P.TAXA_ISSQN, " +
                          " P.TAXA_PIS, " +
                          " P.TAXA_COFINS, " +
                          " P.TAXA_ICMS, " +
                          " P.CST, " +
                          " P.CSOSN, " +
                          " P.TOTALIZADOR_PARCIAL, " +
                          " P.ECF_ICMS_ST, " +
                          " P.CODIGO_BALANCA, " +
                          " P.PAF_P_ST, " +
                          " P.HASH_TRIPA, " +
                          " P.HASH_INCREMENTO, " +
                          " U.NOME AS NOME_UNIDADE, " +
                          " U.PODE_FRACIONAR " +
                          "from " +
                          " PRODUTO P, UNIDADE_PRODUTO U " +
                          "where " +
                          " (P.NOME like " + Biblioteca.QuotedStr(pNome) + ") " +
                          " and (P.ID_UNIDADE_PRODUTO = U.ID)";
            try
            {
                List<ProdutoVO> ListaProduto = new List<ProdutoVO>();

                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    ProdutoVO Produto = new ProdutoVO();

                    Produto.Id = Convert.ToInt32(leitor["ID"]);
                    Produto.IdUnidade = Convert.ToInt32(leitor["ID_UNIDADE_PRODUTO"]);
                    Produto.GTIN = Convert.ToString(leitor["GTIN"]);
                    Produto.CodigoInterno = Convert.ToString(leitor["CODIGO_INTERNO"]);
                    Produto.Nome = Convert.ToString(leitor["NOME_PRODUTO"]);
                    Produto.Descricao = Convert.ToString(leitor["DESCRICAO"]);
                    Produto.DescricaoPDV = Convert.ToString(leitor["DESCRICAO_PDV"]);
                    Produto.ValorVenda = Convert.IsDBNull(leitor["VALOR_VENDA"]) ? 0 : Convert.ToDecimal(leitor["VALOR_VENDA"]);
                    Produto.QtdeEstoque = Convert.IsDBNull(leitor["QTD_ESTOQUE"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE"]);
                    Produto.QtdeEstoqueAnterior = Convert.IsDBNull(leitor["QTD_ESTOQUE_ANTERIOR"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE_ANTERIOR"]);
                    Produto.EstoqueMinimo = Convert.IsDBNull(leitor["ESTOQUE_MIN"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MIN"]);
                    Produto.EstoqueMaximo = Convert.IsDBNull(leitor["ESTOQUE_MAX"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MAX"]);
                    Produto.IAT = Convert.ToString(leitor["IAT"]);
                    Produto.IPPT = Convert.ToString(leitor["IPPT"]);
                    Produto.NCM = Convert.ToString(leitor["NCM"]);
                    Produto.TipoItemSped = Convert.ToString(leitor["TIPO_ITEM_SPED"]);
                    Produto.DataEstoque = Convert.IsDBNull(leitor["DATA_ESTOQUE"]) ? new DateTime() : (DateTime)(leitor["DATA_ESTOQUE"]);
                    Produto.AliquotaIPI = Convert.IsDBNull(leitor["TAXA_IPI"]) ? 0 : Convert.ToDecimal(leitor["TAXA_IPI"]);
                    Produto.AliquotaISSQN = Convert.IsDBNull(leitor["TAXA_ISSQN"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ISSQN"]);
                    Produto.AliquotaPIS = Convert.IsDBNull(leitor["TAXA_PIS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_PIS"]);
                    Produto.AliquotaCOFINS = Convert.IsDBNull(leitor["TAXA_COFINS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_COFINS"]);
                    Produto.AliquotaICMS = Convert.IsDBNull(leitor["TAXA_ICMS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ICMS"]);
                    Produto.Cst = Convert.ToString(leitor["CST"]);
                    Produto.Csosn = Convert.ToString(leitor["CSOSN"]);
                    Produto.TotalizadorParcial = Convert.ToString(leitor["TOTALIZADOR_PARCIAL"]);
                    Produto.ECFICMS = Convert.ToString(leitor["ECF_ICMS_ST"]);
                    Produto.CodigoBalanca = Convert.IsDBNull(leitor["CODIGO_BALANCA"]) ? 0 : Convert.ToInt32(leitor["CODIGO_BALANCA"]);
                    Produto.PafProdutoST = Convert.ToString(leitor["PAF_P_ST"]);
                    Produto.HashTripa = Convert.ToString(leitor["HASH_TRIPA"]);
                    Produto.HashIncremento = Convert.IsDBNull(leitor["HASH_INCREMENTO"]) ? 1 : Convert.ToInt32(leitor["HASH_INCREMENTO"]);
                    Produto.UnidadeProduto = Convert.ToString(leitor["NOME_UNIDADE"]);
                    Produto.PodeFracionarUnidade = Convert.ToString(leitor["PODE_FRACIONAR"]);

                    ListaProduto.Add(Produto);
                }
                return ListaProduto;

            }

            catch (Exception eError)
            {
                Log.write(eError.ToString() + "[ GTIN=" + Convert.ToString(leitor["GTIN"]) + " ]");
                return null;
            }
            finally
            {
                if (leitor != null)
                    leitor.Close();
            }
        }

        public List<ProdutoVO> TabelaProduto(int pCodigoInicio, int pCodigoFim)
        {
            ConsultaSQL =
                          "select " +
                          " P.ID, " +
                          " P.ID_UNIDADE_PRODUTO, " +
                          " P.GTIN, " +
                          " P.CODIGO_INTERNO, " +
                          " P.NOME AS NOME_PRODUTO, " +
                          " P.DESCRICAO, " +
                          " P.DESCRICAO_PDV, " +
                          " P.VALOR_VENDA, " +
                          " P.QTD_ESTOQUE, " +
                          " P.QTD_ESTOQUE_ANTERIOR, " +
                          " P.ESTOQUE_MIN, " +
                          " P.ESTOQUE_MAX, " +
                          " P.IAT, " +
                          " P.IPPT, " +
                          " P.NCM, " +
                          " P.TIPO_ITEM_SPED, " +
                          " P.DATA_ESTOQUE, " +
                          " P.TAXA_IPI, " +
                          " P.TAXA_ISSQN, " +
                          " P.TAXA_PIS, " +
                          " P.TAXA_COFINS, " +
                          " P.TAXA_ICMS, " +
                          " P.CST, " +
                          " P.CSOSN, " +
                          " P.TOTALIZADOR_PARCIAL, " +
                          " P.ECF_ICMS_ST, " +
                          " P.CODIGO_BALANCA, " +
                          " P.PAF_P_ST, " +
                          " P.HASH_TRIPA, " +
                          " P.HASH_INCREMENTO, " +
                          " U.NOME AS NOME_UNIDADE, " +
                          " U.PODE_FRACIONAR " +
                          "from " +
                          " PRODUTO P, UNIDADE_PRODUTO U " +
                          "where " +
                          " (P.ID_UNIDADE_PRODUTO = U.ID) " +
                          "and P.ID between " + Convert.ToString(pCodigoInicio) + " and " + Convert.ToString(pCodigoFim);
            try
            {

                List<ProdutoVO> ListaProduto = new List<ProdutoVO>();

                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    ProdutoVO Produto = new ProdutoVO();

                    Produto.Id = Convert.ToInt32(leitor["ID"]);
                    Produto.IdUnidade = Convert.ToInt32(leitor["ID_UNIDADE_PRODUTO"]);
                    Produto.GTIN = Convert.ToString(leitor["GTIN"]);
                    Produto.CodigoInterno = Convert.ToString(leitor["CODIGO_INTERNO"]);
                    Produto.Nome = Convert.ToString(leitor["NOME_PRODUTO"]);
                    Produto.Descricao = Convert.ToString(leitor["DESCRICAO"]);
                    Produto.DescricaoPDV = Convert.ToString(leitor["DESCRICAO_PDV"]);
                    Produto.ValorVenda = Convert.IsDBNull(leitor["VALOR_VENDA"]) ? 0 : Convert.ToDecimal(leitor["VALOR_VENDA"]);
                    Produto.QtdeEstoque = Convert.IsDBNull(leitor["QTD_ESTOQUE"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE"]);
                    Produto.QtdeEstoqueAnterior = Convert.IsDBNull(leitor["QTD_ESTOQUE_ANTERIOR"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE_ANTERIOR"]);
                    Produto.EstoqueMinimo = Convert.IsDBNull(leitor["ESTOQUE_MIN"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MIN"]);
                    Produto.EstoqueMaximo = Convert.IsDBNull(leitor["ESTOQUE_MAX"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MAX"]);
                    Produto.IAT = Convert.ToString(leitor["IAT"]);
                    Produto.IPPT = Convert.ToString(leitor["IPPT"]);
                    Produto.NCM = Convert.ToString(leitor["NCM"]);
                    Produto.TipoItemSped = Convert.ToString(leitor["TIPO_ITEM_SPED"]);
                    Produto.DataEstoque = Convert.IsDBNull(leitor["DATA_ESTOQUE"]) ? new DateTime() : (DateTime)(leitor["DATA_ESTOQUE"]);
                    Produto.AliquotaIPI = Convert.IsDBNull(leitor["TAXA_IPI"]) ? 0 : Convert.ToDecimal(leitor["TAXA_IPI"]);
                    Produto.AliquotaISSQN = Convert.IsDBNull(leitor["TAXA_ISSQN"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ISSQN"]);
                    Produto.AliquotaPIS = Convert.IsDBNull(leitor["TAXA_PIS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_PIS"]);
                    Produto.AliquotaCOFINS = Convert.IsDBNull(leitor["TAXA_COFINS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_COFINS"]);
                    Produto.AliquotaICMS = Convert.IsDBNull(leitor["TAXA_ICMS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ICMS"]);
                    Produto.Cst = Convert.ToString(leitor["CST"]);
                    Produto.Csosn = Convert.ToString(leitor["CSOSN"]);
                    Produto.TotalizadorParcial = Convert.ToString(leitor["TOTALIZADOR_PARCIAL"]);
                    Produto.ECFICMS = Convert.ToString(leitor["ECF_ICMS_ST"]);
                    Produto.CodigoBalanca = Convert.IsDBNull(leitor["CODIGO_BALANCA"]) ? 0 : Convert.ToInt32(leitor["CODIGO_BALANCA"]);
                    Produto.PafProdutoST = Convert.ToString(leitor["PAF_P_ST"]);
                    Produto.HashTripa = Convert.ToString(leitor["HASH_TRIPA"]);
                    Produto.HashIncremento = Convert.IsDBNull(leitor["HASH_INCREMENTO"]) ? 1 : Convert.ToInt32(leitor["HASH_INCREMENTO"]);
                    Produto.UnidadeProduto = Convert.ToString(leitor["NOME_UNIDADE"]);
                    Produto.PodeFracionarUnidade = Convert.ToString(leitor["PODE_FRACIONAR"]);

                    ListaProduto.Add(Produto);
                }
                return ListaProduto;

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


        public List<ProdutoVO> TabelaProduto(string pNomeInicio, string pNomeFim)
        {
            ConsultaSQL =
                          "select " +
                          " P.ID, " +
                          " P.ID_UNIDADE_PRODUTO, " +
                          " P.GTIN, " +
                          " P.CODIGO_INTERNO, " +
                          " P.NOME AS NOME_PRODUTO, " +
                          " P.DESCRICAO, " +
                          " P.DESCRICAO_PDV, " +
                          " P.VALOR_VENDA, " +
                          " P.QTD_ESTOQUE, " +
                          " P.QTD_ESTOQUE_ANTERIOR, " +
                          " P.ESTOQUE_MIN, " +
                          " P.ESTOQUE_MAX, " +
                          " P.IAT, " +
                          " P.IPPT, " +
                          " P.NCM, " +
                          " P.TIPO_ITEM_SPED, " +
                          " P.DATA_ESTOQUE, " +
                          " P.TAXA_IPI, " +
                          " P.TAXA_ISSQN, " +
                          " P.TAXA_PIS, " +
                          " P.TAXA_COFINS, " +
                          " P.TAXA_ICMS, " +
                          " P.CST, " +
                          " P.CSOSN, " +
                          " P.TOTALIZADOR_PARCIAL, " +
                          " P.ECF_ICMS_ST, " +
                          " P.CODIGO_BALANCA, " +
                          " P.PAF_P_ST, " +
                          " P.HASH_TRIPA, " +
                          " P.HASH_INCREMENTO, " +
                          " U.NOME AS NOME_UNIDADE, " +
                          " U.PODE_FRACIONAR " +
                          "from " +
                          " PRODUTO P, UNIDADE_PRODUTO U " +
                          " where (P.ID_UNIDADE_PRODUTO = U.ID) " +
                          " and (P.NOME like '%" + pNomeInicio.Trim() + "%' or P.NOME like '%" + pNomeFim.Trim() + "%')";
            try
            {

                List<ProdutoVO> ListaProduto = new List<ProdutoVO>();

                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    ProdutoVO Produto = new ProdutoVO();

                    Produto.Id = Convert.ToInt32(leitor["ID"]);
                    Produto.IdUnidade = Convert.ToInt32(leitor["ID_UNIDADE_PRODUTO"]);
                    Produto.GTIN = Convert.ToString(leitor["GTIN"]);
                    Produto.CodigoInterno = Convert.ToString(leitor["CODIGO_INTERNO"]);
                    Produto.Nome = Convert.ToString(leitor["NOME_PRODUTO"]);
                    Produto.Descricao = Convert.ToString(leitor["DESCRICAO"]);
                    Produto.DescricaoPDV = Convert.ToString(leitor["DESCRICAO_PDV"]);
                    Produto.ValorVenda = Convert.IsDBNull(leitor["VALOR_VENDA"]) ? 0 : Convert.ToDecimal(leitor["VALOR_VENDA"]);
                    Produto.QtdeEstoque = Convert.IsDBNull(leitor["QTD_ESTOQUE"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE"]);
                    Produto.QtdeEstoqueAnterior = Convert.IsDBNull(leitor["QTD_ESTOQUE_ANTERIOR"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE_ANTERIOR"]);
                    Produto.EstoqueMinimo = Convert.IsDBNull(leitor["ESTOQUE_MIN"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MIN"]);
                    Produto.EstoqueMaximo = Convert.IsDBNull(leitor["ESTOQUE_MAX"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MAX"]);
                    Produto.IAT = Convert.ToString(leitor["IAT"]);
                    Produto.IPPT = Convert.ToString(leitor["IPPT"]);
                    Produto.NCM = Convert.ToString(leitor["NCM"]);
                    Produto.TipoItemSped = Convert.ToString(leitor["TIPO_ITEM_SPED"]);
                    Produto.DataEstoque = Convert.IsDBNull(leitor["DATA_ESTOQUE"]) ? new DateTime() : (DateTime)(leitor["DATA_ESTOQUE"]);
                    Produto.AliquotaIPI = Convert.IsDBNull(leitor["TAXA_IPI"]) ? 0 : Convert.ToDecimal(leitor["TAXA_IPI"]);
                    Produto.AliquotaISSQN = Convert.IsDBNull(leitor["TAXA_ISSQN"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ISSQN"]);
                    Produto.AliquotaPIS = Convert.IsDBNull(leitor["TAXA_PIS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_PIS"]);
                    Produto.AliquotaCOFINS = Convert.IsDBNull(leitor["TAXA_COFINS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_COFINS"]);
                    Produto.AliquotaICMS = Convert.IsDBNull(leitor["TAXA_ICMS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ICMS"]);
                    Produto.Cst = Convert.ToString(leitor["CST"]);
                    Produto.Csosn = Convert.ToString(leitor["CSOSN"]);
                    Produto.TotalizadorParcial = Convert.ToString(leitor["TOTALIZADOR_PARCIAL"]);
                    Produto.ECFICMS = Convert.ToString(leitor["ECF_ICMS_ST"]);
                    Produto.CodigoBalanca = Convert.IsDBNull(leitor["CODIGO_BALANCA"]) ? 0 : Convert.ToInt32(leitor["CODIGO_BALANCA"]);
                    Produto.PafProdutoST = Convert.ToString(leitor["PAF_P_ST"]);
                    Produto.HashTripa = Convert.ToString(leitor["HASH_TRIPA"]);
                    Produto.HashIncremento = Convert.IsDBNull(leitor["HASH_INCREMENTO"]) ? 1 : Convert.ToInt32(leitor["HASH_INCREMENTO"]);
                    Produto.UnidadeProduto = Convert.ToString(leitor["NOME_UNIDADE"]);
                    Produto.PodeFracionarUnidade = Convert.ToString(leitor["PODE_FRACIONAR"]);

                    ListaProduto.Add(Produto);
                }
                return ListaProduto;

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


        public List<ProdutoVO> ConsultaProdutoSPED(string pDataInicial, string pDataFinal, int pPerfilApresentacao)
        {
            switch (pPerfilApresentacao)
            {
                case 0:
                    {
                        //  Perfil A
                        ClausulaWhere =
                                      " where v.DATA_VENDA between (" + Biblioteca.QuotedStr(pDataInicial) + " and " + Biblioteca.QuotedStr(pDataFinal) +
                                      ") and D.CANCELADO <> " + Biblioteca.QuotedStr("S") +
                                      " and (P.ID_UNIDADE_PRODUTO = U.ID)" +
                                      " and (v.id=d.id_ecf_venda_cabecalho)" +
                                      " and (d.id_ecf_produto=p.id)";
                    } break;
                case 1:
                    {
                        //  Perfil B
                        ClausulaWhere =
                                      " where v.DATA_VENDA between (" + Biblioteca.QuotedStr(pDataInicial) + " and " + Biblioteca.QuotedStr(pDataFinal) +
                                      ") and (P.ID_UNIDADE_PRODUTO = U.ID)" +
                                      " and (v.id=d.id_ecf_venda_cabecalho)" +
                                      " and (d.id_ecf_produto=p.id)";
                    } break;
                case 2:
                    {
                        //  Perfil C
                        ClausulaWhere =
                                      " where v.DATA_VENDA between (" + Biblioteca.QuotedStr(pDataInicial) + " and " + Biblioteca.QuotedStr(pDataFinal) +
                                      ") and (P.ID_UNIDADE_PRODUTO = U.ID)" +
                                      " and (v.id=d.id_ecf_venda_cabecalho)" +
                                      " and (d.id_ecf_produto=p.id)";
                    } break;
            }

            ConsultaSQL =
                          "select distinct " +
                          " P.ID, " +
                          " P.ID_UNIDADE_PRODUTO, " +
                          " P.GTIN, " +
                          " P.CODIGO_INTERNO, " +
                          " P.NOME AS NOME_PRODUTO, " +
                          " P.DESCRICAO, " +
                          " P.DESCRICAO_PDV, " +
                          " P.VALOR_VENDA, " +
                          " P.QTD_ESTOQUE, " +
                          " P.QTD_ESTOQUE_ANTERIOR, " +
                          " P.ESTOQUE_MIN, " +
                          " P.ESTOQUE_MAX, " +
                          " P.IAT, " +
                          " P.IPPT, " +
                          " P.NCM, " +
                          " P.TIPO_ITEM_SPED, " +
                          " P.DATA_ESTOQUE, " +
                          " P.TAXA_IPI, " +
                          " P.TAXA_ISSQN, " +
                          " P.TAXA_PIS, " +
                          " P.TAXA_COFINS, " +
                          " P.TAXA_ICMS, " +
                          " P.CST, " +
                          " P.CSOSN, " +
                          " P.TOTALIZADOR_PARCIAL, " +
                          " P.ECF_ICMS_ST, " +
                          " P.CODIGO_BALANCA, " +
                          " P.PAF_P_ST, " +
                          " P.HASH_TRIPA, " +
                          " U.NOME AS NOME_UNIDADE, " +
                          " U.PODE_FRACIONAR " +
                          "from " +
                          " PRODUTO P, UNIDADE_PRODUTO U, ECF_VENDA_CABECALHO V, ECF_VENDA_DETALHE D" +
                          ClausulaWhere;

            try
            {

                List<ProdutoVO> ListaProduto = new List<ProdutoVO>();

                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    ProdutoVO Produto = new ProdutoVO();

                    Produto.Id = Convert.ToInt32(leitor["ID"]);
                    Produto.IdUnidade = Convert.ToInt32(leitor["ID_UNIDADE_PRODUTO"]);
                    Produto.GTIN = Convert.ToString(leitor["GTIN"]);
                    Produto.CodigoInterno = Convert.ToString(leitor["CODIGO_INTERNO"]);
                    Produto.Nome = Convert.ToString(leitor["NOME_PRODUTO"]);
                    Produto.Descricao = Convert.ToString(leitor["DESCRICAO"]);
                    Produto.DescricaoPDV = Convert.ToString(leitor["DESCRICAO_PDV"]);
                    Produto.ValorVenda = Convert.IsDBNull(leitor["VALOR_VENDA"]) ? 0 : Convert.ToDecimal(leitor["VALOR_VENDA"]);
                    Produto.QtdeEstoque = Convert.IsDBNull(leitor["QTD_ESTOQUE"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE"]);
                    Produto.QtdeEstoqueAnterior = Convert.IsDBNull(leitor["QTD_ESTOQUE_ANTERIOR"]) ? 0 : Convert.ToDecimal(leitor["QTD_ESTOQUE_ANTERIOR"]);
                    Produto.EstoqueMinimo = Convert.IsDBNull(leitor["ESTOQUE_MIN"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MIN"]);
                    Produto.EstoqueMaximo = Convert.IsDBNull(leitor["ESTOQUE_MAX"]) ? 0 : Convert.ToDecimal(leitor["ESTOQUE_MAX"]);
                    Produto.IAT = Convert.ToString(leitor["IAT"]);
                    Produto.IPPT = Convert.ToString(leitor["IPPT"]);
                    Produto.NCM = Convert.ToString(leitor["NCM"]);
                    Produto.TipoItemSped = Convert.ToString(leitor["TIPO_ITEM_SPED"]);
                    Produto.DataEstoque = Convert.IsDBNull(leitor["DATA_ESTOQUE"]) ? new DateTime() : (DateTime)(leitor["DATA_ESTOQUE"]);
                    Produto.AliquotaIPI = Convert.IsDBNull(leitor["TAXA_IPI"]) ? 0 : Convert.ToDecimal(leitor["TAXA_IPI"]);
                    Produto.AliquotaISSQN = Convert.IsDBNull(leitor["TAXA_ISSQN"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ISSQN"]);
                    Produto.AliquotaPIS = Convert.IsDBNull(leitor["TAXA_PIS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_PIS"]);
                    Produto.AliquotaCOFINS = Convert.IsDBNull(leitor["TAXA_COFINS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_COFINS"]);
                    Produto.AliquotaICMS = Convert.IsDBNull(leitor["TAXA_ICMS"]) ? 0 : Convert.ToDecimal(leitor["TAXA_ICMS"]);
                    Produto.Cst = Convert.ToString(leitor["CST"]);
                    Produto.Csosn = Convert.ToString(leitor["CSOSN"]);
                    Produto.TotalizadorParcial = Convert.ToString(leitor["TOTALIZADOR_PARCIAL"]);
                    Produto.ECFICMS = Convert.ToString(leitor["ECF_ICMS_ST"]);
                    Produto.CodigoBalanca = Convert.IsDBNull(leitor["CODIGO_BALANCA"]) ? 0 : Convert.ToInt32(leitor["CODIGO_BALANCA"]);
                    Produto.PafProdutoST = Convert.ToString(leitor["PAF_P_ST"]);
                    Produto.HashTripa = Convert.ToString(leitor["HASH_TRIPA"]);
                    Produto.HashIncremento = Convert.IsDBNull(leitor["HASH_INCREMENTO"]) ? 1 : Convert.ToInt32(leitor["HASH_INCREMENTO"]);
                    Produto.UnidadeProduto = Convert.ToString(leitor["NOME_UNIDADE"]);
                    Produto.PodeFracionarUnidade = Convert.ToString(leitor["PODE_FRACIONAR"]);

                    ListaProduto.Add(Produto);
                }
                return ListaProduto;

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


        public bool GravaCargaProduto(string pTupla)
        {

            String[] tupla = pTupla.Split('|');
            int id;
            try
            {
                id = Convert.ToInt32(tupla[1]);   //ID  INTEGER NOT NULL,

                if (!ConsultaIdProduto(id))
                {
                    ConsultaSQL =
                            "INSERT INTO PRODUTO ("
                            + "ID, "
                            + "ID_UNIDADE_PRODUTO, "
                            + "GTIN, "
                            + "CODIGO_INTERNO, "
                            + "NOME, "
                            + "DESCRICAO, "
                            + "DESCRICAO_PDV, "
                            + "VALOR_VENDA, "
                            + "QTD_ESTOQUE, "
                            + "QTD_ESTOQUE_ANTERIOR, "
                            + "ESTOQUE_MIN, "
                            + "ESTOQUE_MAX, "
                            + "IAT, "
                            + "IPPT, "
                            + "NCM, "
                            + "TIPO_ITEM_SPED, "
                            + "DATA_ESTOQUE, "
                            + "TAXA_IPI, "
                            + "TAXA_ISSQN, "
                            + "TAXA_PIS, "
                            + "TAXA_COFINS, "
                            + "TAXA_ICMS, "
                            + "CST, "
                            + "CSOSN, "
                            + "TOTALIZADOR_PARCIAL, "
                            + "ECF_ICMS_ST, "
                            + "CODIGO_BALANCA, "
                            + "PAF_P_ST, "
                            + "HASH_INCREMENTO)"
                            + " values ("
                            + id + ", " //    ID      INTEGER NOT NULL,
                            + tupla[2] + ", " //    ID_UNIDADE_PRODUTO    INTEGER NOT NULL,
                            + tupla[3] + ", " //    GTIN                  VARCHAR(14),
                            + tupla[4] + ", " //    CODIGO_INTERNO        VARCHAR(20),
                            + tupla[5] + ", " //    NOME                  VARCHAR(100),
                            + tupla[6] + ", " //    DESCRICAO             VARCHAR(250),
                            + tupla[7] + ", " //    DESCRICAO_PDV         VARCHAR(30),
                            + tupla[8] + ", " //    VALOR_VENDA           DECIMAL(18,6),
                            + tupla[9] + ", " //    QTD_ESTOQUE           DECIMAL(18,6),
                            + tupla[10] + ", " //    QTD_ESTOQUE_ANTERIOR  DECIMAL(18,6),
                            + tupla[11] + ", " //    ESTOQUE_MIN           DECIMAL(18,6),
                            + tupla[12] + ", " //    ESTOQUE_MAX           DECIMAL(18,6),
                            + tupla[13] + ", " //    IAT                   CHAR(1),
                            + tupla[14] + ", " //    IPPT                  CHAR(1),
                            + tupla[15] + ", " //    NCM                   VARCHAR(8),
                            + tupla[16] + ", " //    TIPO_ITEM_SPED        CHAR(2),
                            + tupla[17] + ", " //    DATA_ESTOQUE          DATE,
                            + tupla[18] + ", " //    TAXA_IPI              DECIMAL(18,6),
                            + tupla[19] + ", " //    TAXA_ISSQN            DECIMAL(18,6),
                            + tupla[20] + ", " //    TAXA_PIS              DECIMAL(18,6),
                            + tupla[21] + ", " //    TAXA_COFINS           DECIMAL(18,6),
                            + tupla[22] + ", " //    TAXA_ICMS             DECIMAL(18,6),
                            + tupla[23] + ", " //    CST                   CHAR(3),
                            + tupla[24] + ", " //    CSOSN                 CHAR(4),
                            + tupla[25] + ", " //    TOTALIZADOR_PARCIAL   VARCHAR(10),
                            + tupla[26] + ", " //    ECF_ICMS_ST           VARCHAR(4),
                            + tupla[27] + ", " //    CODIGO_BALANCA        INTEGER,
                            + tupla[28] + ", " //    PAF_P_ST              CHAR(1),
                            + "-1)";           //    HASH_INCREMENTO       INTEGER
                }
                else
                {
                    ConsultaSQL =
                            "update "
                            + " PRODUTO "
                            + "set "
                            + "ID_UNIDADE_PRODUTO =" + tupla[2] + "," //    ID_UNIDADE_PRODUTO
                            + "GTIN =" + tupla[3] + "," //    GTIN
                            + "CODIGO_INTERNO =" + tupla[4] + "," //    CODIGO_INTERNO
                            + "NOME =" + tupla[5] + "," //    NOME
                            + "DESCRICAO =" + tupla[6] + "," //    DESCRICAO
                            + "DESCRICAO_PDV =" + tupla[7] + "," //    DESCRICAO_PDV
                            + "VALOR_VENDA =" + tupla[8] + "," //    VALOR_VENDA
                            + "QTD_ESTOQUE =" + tupla[9] + "," //    QTD_ESTOQUE
                            + "QTD_ESTOQUE_ANTERIOR =" + tupla[10] + "," //    QTD_ESTOQUE_ANTERIOR
                            + "ESTOQUE_MIN =" + tupla[11] + "," //    ESTOQUE_MIN
                            + "ESTOQUE_MAX =" + tupla[12] + "," //    ESTOQUE_MAX
                            + "IAT =" + tupla[13] + "," //    IAT
                            + "IPPT =" + tupla[14] + "," //    IPPT
                            + "NCM =" + tupla[15] + "," //    NCM
                            + "TIPO_ITEM_SPED =" + tupla[16] + "," //    TIPO_ITEM_SPED
                            + "DATA_ESTOQUE =" + tupla[17] + "," //    DATA_ESTOQUE
                            + "TAXA_IPI =" + tupla[18] + "," //    TAXA_IPI
                            + "TAXA_ISSQN =" + tupla[19] + "," //    TAXA_ISSQN
                            + "TAXA_PIS =" + tupla[20] + "," //    TAXA_PIS
                            + "TAXA_COFINS =" + tupla[21] + "," //    TAXA_COFINS
                            + "TAXA_ICMS =" + tupla[22] + "," //    TAXA_ICMS
                            + "CST =" + tupla[23] + "," //    CST
                            + "CSOSN =" + tupla[24] + "," //    CSOSN
                            + "TOTALIZADOR_PARCIAL =" + tupla[25] + "," //    TOTALIZADOR_PARCIAL
                            + "ECF_ICMS_ST =" + tupla[26] + "," //    ECF_ICMS_ST
                            + "CODIGO_BALANCA =" + tupla[27] + "," //    CODIGO_BALANCA
                            + "PAF_P_ST =" + tupla[28] + "," //    PAF_P_ST
                            + "HASH_INCREMENTO =-1" //    HASH_INCREMENTO
                            + " where "
                            + "ID =" + id;
                }
                comando = new MySqlCommand(ConsultaSQL, conexao);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception eError)
            {
                Log.write(eError.ToString());
                return false;
            }
            finally
            {
            }
        }

    }

}