/********************************************************************************
Title: AlbertEijePDV
Description: Classe de controle do cliente

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

    public class ClienteController
    {

        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataReader leitor;
        public string ConsultaSQL;

        public ClienteController()
        {
            conexao = dbConnection.conectar();
        }

        public ClienteVO ConsultaCPFCNPJ(string pCPFouCNPJ)
        {

            ConsultaSQL = "select * from CLIENTE where CPF_CNPJ=" + Biblioteca.QuotedStr(pCPFouCNPJ);
            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                if (leitor.Read())
                {
                    ClienteVO Cliente = new ClienteVO();

                    Cliente.Id = Convert.ToInt32(leitor["ID"]);
                    Cliente.IdSituacaoCliente = leitor["ID_SITUACAO_CLIENTE"] as int?;
                    Cliente.Nome = leitor["NOME"].ToString();
                    Cliente.Fantasia = leitor["FANTASIA"].ToString();
                    Cliente.Email = leitor["EMAIL"].ToString();
                    Cliente.CpfOuCnpj = leitor["CPF_CNPJ"].ToString();
                    Cliente.Rg = leitor["RG"].ToString();
                    Cliente.OrgaoRg = leitor["ORGAO_RG"].ToString();
                    Cliente.DataEmissaoRg = leitor["DATA_EMISSAO_RG"] as DateTime?;
                    Cliente.Sexo = leitor["SEXO"].ToString();
                    Cliente.InscricaoEstadual = leitor["INSCRICAO_ESTADUAL"].ToString();
                    Cliente.InscricaoMunicipal = leitor["INSCRICAO_MUNICIPAL"].ToString();
                    Cliente.TipoPessoa = leitor["TIPO_PESSOA"].ToString();
                    Cliente.DataCadastro = leitor["DATA_CADASTRO"] as DateTime?;
                    Cliente.Contato = leitor["CONTATO"].ToString();
                    Cliente.Logradouro = leitor["LOGRADOURO"].ToString();
                    Cliente.Numero = leitor["NUMERO"].ToString();
                    Cliente.Complemento = leitor["COMPLEMENTO"].ToString();
                    Cliente.Cep = leitor["CEP"].ToString();
                    Cliente.Bairro = leitor["BAIRRO"].ToString();
                    Cliente.Cidade = leitor["CIDADE"].ToString();
                    Cliente.Uf = leitor["UF"].ToString();
                    Cliente.Fone1 = leitor["FONE1"].ToString();
                    Cliente.Fone2 = leitor["FONE2"].ToString();
                    Cliente.Celular = leitor["CELULAR"].ToString();
                    Cliente.CodigoIbgeCidade = leitor["CODIGO_IBGE_CIDADE"] as int?;
                    Cliente.CodigoIbgeUf = leitor["CODIGO_IBGE_UF"] as int?;

                    return Cliente;
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



        public ClienteVO ConsultaPeloID(int pId)
        {
            ConsultaSQL = "select * from CLIENTE where ID=" + Convert.ToString(pId);

            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                if (leitor.Read())
                {
                    ClienteVO Cliente = new ClienteVO();

                    Cliente.Id = Convert.ToInt32(leitor["ID"]);
                    Cliente.IdSituacaoCliente = leitor["ID_SITUACAO_CLIENTE"] as int?;
                    Cliente.Nome = leitor["NOME"].ToString();
                    Cliente.Fantasia = leitor["FANTASIA"].ToString();
                    Cliente.Email = leitor["EMAIL"].ToString();
                    Cliente.CpfOuCnpj = leitor["CPF_CNPJ"].ToString();
                    Cliente.Rg = leitor["RG"].ToString();
                    Cliente.OrgaoRg = leitor["ORGAO_RG"].ToString();
                    Cliente.DataEmissaoRg = leitor["DATA_EMISSAO_RG"] as DateTime?;
                    Cliente.Sexo = leitor["SEXO"].ToString();
                    Cliente.InscricaoEstadual = leitor["INSCRICAO_ESTADUAL"].ToString();
                    Cliente.InscricaoMunicipal = leitor["INSCRICAO_MUNICIPAL"].ToString();
                    Cliente.TipoPessoa = leitor["TIPO_PESSOA"].ToString();
                    Cliente.DataCadastro = leitor["DATA_CADASTRO"] as DateTime?;
                    Cliente.Contato = leitor["CONTATO"].ToString();
                    Cliente.Logradouro = leitor["LOGRADOURO"].ToString();
                    Cliente.Numero = leitor["NUMERO"].ToString();
                    Cliente.Complemento = leitor["COMPLEMENTO"].ToString();
                    Cliente.Cep = leitor["CEP"].ToString();
                    Cliente.Bairro = leitor["BAIRRO"].ToString();
                    Cliente.Cidade = leitor["CIDADE"].ToString();
                    Cliente.Uf = leitor["UF"].ToString();
                    Cliente.Fone1 = leitor["FONE1"].ToString();
                    Cliente.Fone2 = leitor["FONE2"].ToString();
                    Cliente.Celular = leitor["CELULAR"].ToString();
                    Cliente.CodigoIbgeCidade = leitor["CODIGO_IBGE_CIDADE"] as int?;
                    Cliente.CodigoIbgeUf = leitor["CODIGO_IBGE_UF"] as int?;

                    return Cliente;
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


        public List<ClienteVO> TabelaCliente(string pNome)
        {
            List<ClienteVO> ListaCliente = new List<ClienteVO>();

            ConsultaSQL = " select " +
                            " c.ID, " +
                            " c.NOME, " +
                            " c.ID_SITUACAO_CLIENTE, " +
                            " c.ORGAO_RG, " +
                            " c.CPF_CNPJ, " +
                            " c.RG, " +
                            " c.INSCRICAO_MUNICIPAL, " +
                            " c.DATA_CADASTRO " +
                            " from " +
                            " CLIENTE c " +
                            " where " +
                            " c.NOME like " + Biblioteca.QuotedStr(pNome);

            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    ClienteVO Cliente = new ClienteVO();

                    Cliente.Id = Convert.ToInt32(leitor["ID"]);
                    Cliente.Nome = leitor["NOME"].ToString();
                    Cliente.IdSituacaoCliente = Convert.ToInt32(leitor["ID_SITUACAO_CLIENTE"]);
                    Cliente.CpfOuCnpj = leitor["CPF_CNPJ"].ToString();
                    Cliente.Rg = leitor["RG"].ToString();
                    Cliente.OrgaoRg = leitor["ORGAO_RG"].ToString();
                    Cliente.InscricaoMunicipal = leitor["INSCRICAO_MUNICIPAL"].ToString();
                    Cliente.DataCadastro = leitor["DATA_CADASTRO"] as DateTime?;

                    ListaCliente.Add(Cliente);
                }
                return ListaCliente;
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


        public List<ClienteVO> ConsultaClienteSPED(string pDataInicial, string pDataFinal)
        {
            List<ClienteVO> ListaCliente = new List<ClienteVO>();

            ConsultaSQL = " select " +
                            " c.nome, " +
                            " c.rg, " +
                            " c.orgao_rg, " +
                            " c.cpf_cnpj, " +
                            " c.tipo, " +
                            " c.inscricao_estadual, " +
                            " c.inscricao_municipal, " +
                            " c.data_cadastro, " +
                            " p.codigo_ibge_cidade, " +
                            " p.logradouro, " +
                            " p.numero, " +
                            " p.complemento, " +
                            " p.bairro, " +
                            " p.uf " +
                            " from " +
                            " pessoa c, pessoa_endereco p " +
                            " where " +
                            " c.id in (select ID  from NFE_CABECALHO where DATA_EMISSAO between " + Biblioteca.QuotedStr(pDataInicial) + " and " + Biblioteca.QuotedStr(pDataFinal) + ")";

            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    ClienteVO Cliente = new ClienteVO();

                    Cliente.Id = Convert.ToInt32(leitor["ID"]);
                    Cliente.TipoPessoa = leitor["TIPO_PESSOA"].ToString();
                    Cliente.Nome = leitor["NOME"].ToString();
                    Cliente.CpfOuCnpj = leitor["CPF_CNPJ"].ToString();
                    Cliente.Rg = leitor["RG"].ToString();
                    Cliente.OrgaoRg = leitor["ORGAO_RG"].ToString();
                    Cliente.InscricaoEstadual = leitor["INSCRICAO_ESTADUAL"].ToString();
                    Cliente.InscricaoMunicipal = leitor["INSCRICAO_MUNICIPAL"].ToString();
                    Cliente.DataCadastro = leitor["DATA_CADASTRO"] as DateTime?;
                    Cliente.Logradouro = leitor["LOGRADOURO"].ToString();
                    Cliente.Numero = leitor["NUMERO"].ToString();
                    Cliente.Complemento = leitor["COMPLEMENTO"].ToString();
                    Cliente.Cep = leitor["CEP"].ToString();
                    Cliente.Bairro = leitor["BAIRRO"].ToString();
                    Cliente.Cidade = leitor["CIDADE"].ToString();
                    Cliente.Uf = leitor["UF"].ToString();
                    Cliente.CodigoIbgeCidade = leitor["CODIGO_IBGE_CIDADE"] as int?;

                    ListaCliente.Add(Cliente);
                }
                return ListaCliente;
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


        public bool ConsultaIdCliente(int pId)
        {

            ConsultaSQL = "select ID from Cliente where (ID = ?pID) ";

            try
            {
                comando = new MySqlCommand(ConsultaSQL, conexao);
                comando.Parameters.AddWithValue("?pId", pId);
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


        public bool GravaCargaCliente(string pTupla)
        {
            string[] tupla = pTupla.Split('|');
            int id;
            try
            {
                id = Convert.ToInt32(tupla[1]);   //ID  INTEGER NOT NULL,

                if (!ConsultaIdCliente(id))
                {
                    ConsultaSQL =
                            "insert into"
                            + " CLIENTE "
                            + "(ID, "
                            + "ID_SITUACAO_CLIENTE, "//2
                            + "NOME, "//3
                            + "FANTASIA, "//4
                            + "EMAIL, "//5
                            + "CPF_CNPJ, "//6
                            + "RG, "//7
                            + "ORGAO_RG, "//8
                            + "DATA_EMISSAO_RG, "//9
                            + "SEXO, "//10
                            + "INSCRICAO_ESTADUAL, "//11
                            + "INSCRICAO_MUNICIPAL, "//12
                            + "TIPO_PESSOA, "//13
                            + "DATA_CADASTRO, "//14
                            + "LOGRADOURO, "//15
                            + "NUMERO, "//16
                            + "COMPLEMENTO, "//17
                            + "CEP, "//18
                            + "BAIRRO, "//19
                            + "CIDADE, "//20
                            + "UF, "//21
                            + "FONE1, "//22
                            + "FONE2, "//23
                            + "CELULAR, "//24
                            + "CONTATO, "//25
                            + "CODIGO_IBGE_CIDADE, "//26
                            + "CODIGO_IBGE_UF) "//27
                            + "values ("
                            + id + ", " //    ID      INTEGER NOT NULL,
                            + tupla[2] + ", " //   ID_SITUACAO_CLIENTE  INTEGER NOT NULL,
                            + tupla[3] + ", " //   NOME                 VARCHAR(150),
                            + tupla[4] + ", " //   FANTASIA             VARCHAR(150),
                            + tupla[5] + ", " //   EMAIL                VARCHAR(250),
                            + tupla[6] + ", " //   CPF_CNPJ             VARCHAR(14),
                            + tupla[7] + ", " //   RG                   VARCHAR(20),
                            + tupla[8] + ", " //   ORGAO_RG             VARCHAR(20),
                            + tupla[9] + ", " //   DATA_EMISSAO_RG      DATE,
                            + tupla[10] + ", " //   SEXO                 CHAR(1),
                            + tupla[11] + ", " //   INSCRICAO_ESTADUAL   VARCHAR(30),
                            + tupla[12] + ", " //   INSCRICAO_MUNICIPAL  VARCHAR(30),
                            + tupla[13] + ", " //   TIPO_PESSOA          CHAR(1),
                            + tupla[14] + ", " //   DATA_CADASTRO        DATE,
                            + tupla[15] + ", " //   LOGRADOURO           VARCHAR(250),
                            + tupla[16] + ", " //   NUMERO               VARCHAR(6),
                            + tupla[17] + ", " //   COMPLEMENTO          VARCHAR(50),
                            + tupla[18] + ", " //   CEP                  VARCHAR(8),
                            + tupla[19] + ", " //   BAIRRO               VARCHAR(100),
                            + tupla[20] + ", " //   CIDADE               VARCHAR(100),
                            + tupla[21] + ", " //   UF                   CHAR(2),
                            + tupla[22] + ", " //   FONE1                VARCHAR(10),
                            + tupla[23] + ", " //   FONE2                VARCHAR(10),
                            + tupla[24] + ", " //   CELULAR              VARCHAR(10),
                            + tupla[25] + ", " //   CONTATO              VARCHAR(50),
                            + tupla[26] + ", " //   CODIGO_IBGE_CIDADE   INTEGER,
                            + tupla[27] + ")";     //   CODIGO_IBGE_UF       INTEGER
                }
                else
                {
                    ConsultaSQL =
                            "update "
                            + " CLIENTE "
                            + "set "
                            + "ID_SITUACAO_CLIENTE =" + tupla[2] + ", " //   ID_SITUACAO_CLIENTE  INTEGER NOT NULL,
                            + "NOME =" + tupla[3] + ", " //   NOME                 VARCHAR(150),
                            + "FANTASIA =" + tupla[4] + ", " //   FANTASIA             VARCHAR(150),
                            + "EMAIL =" + tupla[5] + ", " //   EMAIL                VARCHAR(250),
                            + "CPF_CNPJ =" + tupla[6] + ", " //   CPF_CNPJ             VARCHAR(14),
                            + "RG =" + tupla[7] + ", " //   RG                   VARCHAR(20),
                            + "ORGAO_RG =" + tupla[8] + ", " //   ORGAO_RG             VARCHAR(20),
                            + "DATA_EMISSAO_RG =" + tupla[9] + ", " //   DATA_EMISSAO_RG      DATE,
                            + "SEXO =" + tupla[10] + ", " //   SEXO                 CHAR(1),
                            + "INSCRICAO_ESTADUAL =" + tupla[11] + ", " //   INSCRICAO_ESTADUAL   VARCHAR(30),
                            + "INSCRICAO_MUNICIPAL =" + tupla[12] + ", " //   INSCRICAO_MUNICIPAL  VARCHAR(30),
                            + "TIPO_PESSOA =" + tupla[13] + ", " //   TIPO_PESSOA          CHAR(1),
                            + "DATA_CADASTRO =" + tupla[14] + ", " //   DATA_CADASTRO        DATE,
                            + "LOGRADOURO =" + tupla[15] + ", " //   LOGRADOURO           VARCHAR(250),
                            + "NUMERO =" + tupla[16] + ", " //   NUMERO               VARCHAR(6),
                            + "COMPLEMENTO =" + tupla[17] + ", " //   COMPLEMENTO          VARCHAR(50),
                            + "CEP =" + tupla[18] + ", " //   CEP                  VARCHAR(8),
                            + "BAIRRO =" + tupla[19] + ", " //   BAIRRO               VARCHAR(100),
                            + "CIDADE =" + tupla[20] + ", " //   CIDADE               VARCHAR(100),
                            + "UF =" + tupla[21] + ", " //   UF                   CHAR(2),
                            + "FONE1 =" + tupla[22] + ", " //   FONE1                VARCHAR(10),
                            + "FONE2 =" + tupla[23] + ", " //   FONE2                VARCHAR(10),
                            + "CELULAR =" + tupla[24] + ", " //   CELULAR              VARCHAR(10),
                            + "CONTATO =" + tupla[25] + ", " //   CONTATO              VARCHAR(50),
                            + "CODIGO_IBGE_CIDADE =" + tupla[26] + ", " //   CODIGO_IBGE_CIDADE   INTEGER,
                            + "CODIGO_IBGE_UF =" + tupla[27] //   CODIGO_IBGE_UF       INTEGER
                            + " where "
                            + " ID =" + id;
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
