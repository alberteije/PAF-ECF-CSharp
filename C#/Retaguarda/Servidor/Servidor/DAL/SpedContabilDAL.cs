using System;
using System.Collections.Generic;
using ACBrFramework.Sped;
using System.IO;
using NHibernate;
using Servidor.NHibernate;
using System.Collections;
using Servidor.Model;


namespace Servidor.DAL
{

    public class SpedContabilDAL
    {

        #region Informa��es Importantes
        /*
        Fonte: Manual de Orienta��o da ECD

        S�o previstas as seguintes formas de escritura��o:
        G - Di�rio Geral;
        R - Di�rio com Escritura��o Resumida (vinculado a livro auxiliar);
        A - Di�rio Auxiliar;
        Z - Raz�o Auxiliar; e
        B - Livro de Balancetes Di�rios e Balan�os.

          - Todas as empresas devem utilizar o livro Di�rio contemplando todos os fatos cont�beis. Este livro �
            classificado, no Sped Cont�bil, como G - Livro Di�rio (completo, sem escritura��o auxiliar).
            � o livro Di�rio que independe de qualquer outro. Portanto, ele n�o pode coexistir, em rela��o a um mesmo
            per�odo, com quaisquer dos outros livros (R, A, Z ou B).

          - R - Livro Di�rio com Escritura��o Resumida (com escritura��o auxiliar): � o livro Di�rio que contem
            escritura��o resumida, nos termos do � 1o do art. 1.184 do C�digo Civil, acima transcrito. Ele obriga a
            exist�ncia de livros auxiliares (A ou Z) e n�o pode coexistir, em rela��o a um mesmo per�odo, com os livros G
            e B.

          - A - Livro Di�rio Auxiliar ao Di�rio com Escritura��o Resumida: � o livro auxiliar previsto no nos termos do
            � 1o do art. 1.184 do C�digo Civil supramencionado, contendo os lan�amentos individualizados das opera��es
            lan�adas no Di�rio com Escritura��o Resumida.

          - Z � Raz�o Auxiliar (Livro Cont�bil Auxiliar conforme leiaute definido pelo titular da escritura��o): O livro Z
            um livro auxiliar a ser utilizado quando o leiaute do livro Di�rio Auxiliar n�o se mostrar adequado. � uma
            �tabela� onde o titular da escritura��o define cada coluna e seu conte�do.

          - B - Livro Balancetes Di�rios e Balan�os: Somente o Banco Central regulamentou a utiliza��o deste livro e,
            praticamente, s� � encontrado em institui��es financeiras. A legisla��o n�o obsta a utiliza��o concomitante do
            livro �Balancetes Di�rios e Balan�os� e de livros auxiliares. Existe a controv�rsia sobre a obrigatoriedade de
            autentica��o, pelas empresas n�o regulamentadas pelo Banco Central, das fichas de lan�amento, conforme
            estabelecido no art. 1.181 do C�digo Civil, transcrito abaixo:
            Art. 1.181. Salvo disposi��o especial de lei, os livros obrigat�rios e, se for o caso, as fichas, antes de postos
            em uso, devem ser autenticados no Registro P�blico de Empresas Mercantis.

          - Se��o 1.7. Regras de Conviv�ncia entre os Livros Abrangidos pelo Sped Cont�bil

            A escritura��o G, Di�rio Geral, n�o pode conviver com nenhuma outra escritura��o no mesmo per�odo, ou
            seja, as escritura��es principais (G, R ou B) n�o podem coexistir.
            A escritura��o G n�o possui livros auxiliares (A ou Z), e, consequentemente, n�o pode conviver com esses
            tipos de escritura��o.
            A escritura��o resumida R pode conviver com os livros auxiliares (A ou Z).
            O livro de balancetes e balan�os di�rios B pode conviver com os livros auxiliares (A ou Z).
        */
        #endregion


        private static string path = "C:\\teste\\LogSped.txt";
        //public ACBrFramework.Sped.ACBrSpedContabil ACBrSpedContabil { get; set; }

        private EmpresaDTO Empresa;
        private int FormaEscrituracao, LayoutVersao, IdEmpresa;
        private String DataInicial, DataFinal, Arquivo, FiltroLocal;
        private ISession Session;

        public SpedContabilDAL()
        {
            /*
            ACBrSpedContabil = new ACBrFramework.Sped.ACBrSpedContabil();

            ACBrSpedContabil.Arquivo = "";
            ACBrSpedContabil.CurMascara = "#0.00";
            ACBrSpedContabil.Delimitador = "|";
            ACBrSpedContabil.DT_FIN = new System.DateTime(1899, 12, 30, 0, 0, 0, 0);
            ACBrSpedContabil.DT_INI = new System.DateTime(1899, 12, 30, 0, 0, 0, 0);
            ACBrSpedContabil.LinhasBuffer = 1000;
            ACBrSpedContabil.Path = "C:\\T2Ti\\Arquivos\\";
            ACBrSpedContabil.Arquivo = "SpedContabil.txt";
            ACBrSpedContabil.TrimString = true;
            ACBrSpedContabil.OnError += new System.EventHandler<ACBrFramework.Sped.ErrorEventArgs>(ACBrSpedContabil_OnError);
             */
        }

        private void ACBrSpedContabil_OnError(object sender, ACBrFramework.Sped.ErrorEventArgs e)
        {
            File.AppendAllText(path, DateTime.Now.ToShortDateString() + " " +
                DateTime.Now.ToLongTimeString() + ":\t" + e.MsgErro + Environment.NewLine);
        }


        #region Bloco 0 - Abertura, Identifica��o e Refer�ncias
        public void GerarBloco0()
        {
            /*
            ACBrSpedContabil.Bloco_0.LimpaRegistros;
            using ACBrSpedContabil.Bloco_0 
            {
                // REGISTRO 0000: ABERTURA DO ARQUIVO DIGITAL E IDENTIFICA��O DO EMPRES�RIO OU DA SOCIEDADE EMPRES�RIA
                using Registro0000 
                {
                    DT_INI = TextoParaData(DataInicial);
                    DT_FIN = TextoParaData(DataFinal);

                    NOME = Empresa.RazaoSocial;
                    CNPJ = Empresa.CNPJ;
                    UF = Empresa.ListaEnderecoVO.Items[0].UF;
                    IE = Empresa.InscricaoEstadual;
                    COD_MUN = IntToStr(Empresa.CodigoIbgeCidade);
                    IM = Empresa.InscricaoMunicipal;
                    IND_SIT_ESP = "";
                }

                // REGISTRO 0001: ABERTURA DO BLOCO 0
                Registro0001.IND_DAD = 0; // bloco com dados informados = 0 | sem dados inf = 1

                // REGISTRO 0007: OUTRAS INSCRI��ES CADASTRAIS DA PESSOA JUR�DICA
                //{ Implementado a crit�rio do Participante do T2Ti ERP }

                // REGISTRO 0020: ESCRITURA��O CONT�BIL DESCENTRALIZADA
                //{ Implementado a crit�rio do Participante do T2Ti ERP - Para o treinamento a escritura��o ser� centralizada }

                // REGISTRO 0150: TABELA DE CADASTRO DO PARTICIPANTE
                //{ Implementado a crit�rio do Participante do T2Ti ERP }

                // REGISTRO 0180: IDENTIFICA��O DO RELACIONAMENTO COM O PARTICIPANTE
                //{ Implementado a crit�rio do Participante do T2Ti ERP }
            }
             */
        }
        #endregion

        #region Bloco I - Lan�amentos Cont�beis
        public void GerarBlocoI()
        {
            /*
              Credito = 0;
              Debito = 0;
              SaldoAnterior = 0;
              Niveis = TStringList.Create;
              ACBrSpedContabil.Bloco_I.LimpaRegistros;

              using ACBrSpedContabil.Bloco_I do
              {
                // REGISTRO I001: ABERTURA DO BLOCO I
                RegistroI001.IND_DAD = 0;

                // REGISTRO I010: IDENTIFICA��O DA ESCRITURA��O CONT�BIL
                case FormaEscrituracao of
                  0:
                    RegistroI010.IND_ESC = "G";
                  1:
                    RegistroI010.IND_ESC = "R";
                  2:
                    RegistroI010.IND_ESC = "A";
                  3:
                    RegistroI010.IND_ESC = "B";
                  4:
                    RegistroI010.IND_ESC = "Z";
                };
                EscrituracaoForma = RegistroI010.IND_ESC;

                case VersaoLayout of
                  0:
                    RegistroI010.COD_VER_LC = "1.00";
                  1:
                    RegistroI010.COD_VER_LC = "2.00";
                };

                // REGISTRO I012: LIVROS AUXILIARES AO DI�RIO
                { Implementado a crit�rio do Participante do T2Ti ERP }

                // REGISTRO I015: IDENTIFICA��O DAS CONTAS DA ESCRITURA��O RESUMIDA A QUE SE REFERE A ESCRITURA��O AUXILIAR
                { Implementado a crit�rio do Participante do T2Ti ERP }

                // REGISTRO I020: CAMPOS ADICIONAIS
                { Implementado a crit�rio do Participante do T2Ti ERP }

                // REGISTRO I030: TERMO DE ABERTURA
                ContabilLivro = TT2TiORM.ConsultarUmObjeto<TContabilLivroVO>("FORMA_ESCRITURACAO = " + QuotedStr(EscrituracaoForma) +  " and COMPETENCIA=" + QuotedStr(FormatDateTime("MM/YYYY", TextoParaData(DataInicial))), False);
                if Assigned(ContabilLivro) then
                {
                  TermoLivro = TT2TiORM.ConsultarUmObjeto<TContabilTermoVO>("ID_CONTABIL_LIVRO=" + IntToStr(ContabilLivro.Id) + " and ABERTURA_ENCERRAMENTO=" + QuotedStr("A"), False);
                  RegistroCartorio = TT2TiORM.ConsultarUmObjeto<TRegistroCartorioVO>("ID_EMPRESA=" + IntToStr(Sessao(SessaoAtual).IdEmpresa), False);

                  using RegistroI030 do
                  {
                    NUM_ORD = TermoLivro.NumeroRegistro;
                    NAT_LIVR = ContabilLivro.Descricao;
                    QTD_LIN = ACBrSpedContabil.Bloco_9.Registro9999.QTD_LIN;
                    NOME = Empresa.RazaoSocial;
                    NIRE = RegistroCartorio.NIRE;
                    CNPJ = Empresa.CNPJ;
                    DT_ARQ = RegistroCartorio.DataRegistro;
                    DESC_MUN = Empresa.Lista}erecoVO.Items[0].Cidade;
                  };
                };


                // REGISTRO I050: PLANO DE CONTAS
                PlanoConta = TT2TiORM.ConsultarUmObjeto<TPlanoContaVO>("ID_EMPRESA=" + IntToStr(Sessao(SessaoAtual).IdEmpresa), False);
                if Assigned(PlanoConta) then
                {
                  ListaPlanoConta = TT2TiORM.Consultar<TContabilContaVO>("ID_PLANO_CONTA=" + IntToStr(PlanoConta.Id), False);
                  if assigned(ListaPlanoConta) then
                  {
                    for i = 0 to ListaPlanoConta.Count - 1 do
                    {
                      using RegistroI050.New do
                      {
                        DT_ALT = TContabilContaVO(ListaPlanoConta.Items[i]).DataInclusao;
                        COD_NAT = TContabilContaVO(ListaPlanoConta.Items[i]).CodigoEfd;
                        IND_CTA = TContabilContaVO(ListaPlanoConta.Items[i]).Tipo;
                        Split(".", TContabilContaVO(ListaPlanoConta.Items[i]).Classificacao, Niveis);
                        NIVEL = IntToStr(Niveis.Count);
                        COD_CTA = TContabilContaVO(ListaPlanoConta.Items[i]).Classificacao;
                        COD_CTA_SUP = "";
                        CTA = TContabilContaVO(ListaPlanoConta.Items[i]).Descricao;

                        // REGISTRO I051: PLANO DE CONTAS REFERENCIAL
                        {
                        Observa��o: A partir da vers�o 3.X e altera��es posteriores do PVA do Sped Cont�bil, n�o haver� o plano de
                        contas referencial da RFB . Portanto, para as empresas que utilizavam esse plano, n�o ser� necess�rio o preenchimento
                        do registro I051.

                        Fonte: Manual de Orienta��o da ECD
                        }
                      };
                    };
                  };
                };

                // REGISTRO I052: INDICA��O DOS C�DIGOS DE AGLUTINA��O
                { Implementado a crit�rio do Participante do T2Ti ERP }


                // REGISTRO I075: TABELA DE HIST�RICO PADRONIZADO
                ListaHistorico = TT2TiORM.Consultar<TContabilHistoricoVO>("ID_EMPRESA=" + IntToStr(Sessao(SessaoAtual).IdEmpresa), False);
                if assigned(ListaHistorico) then
                {
                  for i = 0 to ListaHistorico.Count - 1 do
                  {
                    using RegistroI075.New do
                    {
                      COD_HIST = IntToStr(TContabilHistoricoVO(ListaHistorico.Items[i]).Id);
                      DESCR_HIST = TContabilHistoricoVO(ListaHistorico.Items[i]).Historico;
                    };
                  };
                };

                // REGISTRO I100: CENTRO DE CUSTOS
                { Implementado a crit�rio do Participante do T2Ti ERP }

                // REGISTRO I150: SALDOS PERI�DICOS � IDENTIFICA��O DO PER�ODO
                using RegistroI150.New do
                {
                  DT_INI = TextoParaData(DataInicial);
                  DT_FIN = TextoParaData(DataFinal);

                  // REGISTRO I151: Hash dos Arquivos que Cont�m as Fichas de Lan�amento Utilizadas no Per�odo
                  { Implementado a crit�rio do Participante do T2Ti ERP }

                  // REGISTRO I155: DETALHE DOS SALDOS PERI�DICOS
                  using RegistroI155.New do
                  {
                    for i = 0 to ListaPlanoConta.Count - 1 do
                    {
                      // Saldo Anterior
                      FiltroLocal = "MES_ANO=" + QuotedStr(PeriodoAnterior(FormatDateTime("MM/YYYY", TextoParaData(DataInicial)))) + " and TIPO=" + QuotedStr("C");
                      RegistroI155C = TT2TiORM.ConsultarUmObjeto<TViewSpedI155VO>(FiltroLocal, False);
                      if Assigned(RegistroI155C) then
                        Credito = RegistroI155C.SomaValor
                      else
                        Credito = 0;

                      FiltroLocal = "MES_ANO=" + QuotedStr(PeriodoAnterior(FormatDateTime("MM/YYYY", TextoParaData(DataInicial)))) + " and TIPO=" + QuotedStr("D");
                      RegistroI155D = TT2TiORM.ConsultarUmObjeto<TViewSpedI155VO>(FiltroLocal, False);
                      if Assigned(RegistroI155D) then
                        Debito = RegistroI155D.SomaValor
                      else
                        Debito = 0;

                      SaldoAnterior = Credito - Debito;

                      COD_CTA = TContabilContaVO(ListaPlanoConta.Items[i]).Classificacao;
                      COD_CCUS = "";
                      VL_SLD_INI = SaldoAnterior;

                      if SaldoAnterior < 0 then
                        IND_DC_INI = "D"
                      else
                        IND_DC_INI = "C";

                      // Saldo Atual
                      FiltroLocal = "MES_ANO=" + QuotedStr(FormatDateTime("MM/YYYY", TextoParaData(DataInicial))) + " and TIPO=" + QuotedStr("C");
                      RegistroI155C = TT2TiORM.ConsultarUmObjeto<TViewSpedI155VO>(FiltroLocal, False);
                      if Assigned(RegistroI155C) then
                        Credito = RegistroI155C.SomaValor
                      else
                        Credito = 0;

                      FiltroLocal = "MES_ANO=" + QuotedStr(FormatDateTime("MM/YYYY", TextoParaData(DataInicial))) + " and TIPO=" + QuotedStr("D");
                      RegistroI155D = TT2TiORM.ConsultarUmObjeto<TViewSpedI155VO>(FiltroLocal, False);
                      if Assigned(RegistroI155D) then
                        Debito = RegistroI155D.SomaValor
                      else
                        Debito = 0;

                      VL_DEB = Debito;
                      VL_CRED = Credito;
                      VL_SLD_FIN = Credito - Debito;

                      if (Credito - Debito) < 0 then
                        IND_DC_FIN = "D"
                      else
                        IND_DC_FIN = "C";

                      // REGISTRO I157: TRANSFER�NCIA DE SALDOS DE PLANO DE CONTAS ANTERIOR
                      { Implementado a crit�rio do Participante do T2Ti ERP }
                    };
                  };
                };

                // REGISTRO I200: LAN�AMENTO CONT�BIL
                FiltroLocal = "ID_EMPRESA=" + IntToStr(Sessao(SessaoAtual).IdEmpresa) + " and (DATA_LANCAMENTO BETWEEN " + QuotedStr(DataInicial) + " and " + QuotedStr(DataFinal) + ")";
                ListaLancamentoCabecalho = TT2TiORM.Consultar<TContabilLancamentoCabecalhoVO>(FiltroLocal, False);
                if assigned(ListaLancamentoCabecalho) then
                {
                  for i = 0 to ListaLancamentoCabecalho.Count - 1 do
                  {
                    using RegistroI200.New do
                    {
                      NUM_LCTO = IntToStr(TContabilLancamentoCabecalhoVO(ListaLancamentoCabecalho.Items[i]).Id);
                      DT_LCTO = TContabilLancamentoCabecalhoVO(ListaLancamentoCabecalho.Items[i]).DataLancamento;
                      VL_LCTO = TContabilLancamentoCabecalhoVO(ListaLancamentoCabecalho.Items[i]).Valor;
                      IND_LCTO = "N";

                      // REGISTRO I250: PARTIDAS DO LAN�AMENTO
                      ListaLancamentoDetalhe = TT2TiORM.Consultar<TContabilLancamentoDetalheVO>("ID_CONTABIL_LANCAMENTO_CAB=" + NUM_LCTO, False);
                      if assigned(ListaLancamentoDetalhe) then
                      {
                        for j = 0 to ListaLancamentoDetalhe.Count - 1 do
                        {
                          using RegistroI250.New do
                          {
                            ContaContabil = TT2TiORM.ConsultarUmObjeto<TContabilContaVO>("ID=" + IntToStr(TContabilLancamentoDetalheVO(ListaLancamentoDetalhe.Items[i]).IdContabilConta), False);

                            COD_CTA = ContaContabil.Classificacao;
                            VL_DC = TContabilLancamentoDetalheVO(ListaLancamentoDetalhe.Items[i]).Valor;
                            IND_DC = TContabilLancamentoDetalheVO(ListaLancamentoDetalhe.Items[i]).Tipo;
                            COD_HIST_PAD = IntToStr(TContabilLancamentoDetalheVO(ListaLancamentoDetalhe.Items[i]).IdContabilHistorico);
                            HIST = TContabilLancamentoDetalheVO(ListaLancamentoDetalhe.Items[i]).Historico;
                          };
                        };
                      };
                    };
                  };
                };

                // REGISTRO I300: BALANCETES DI�RIOS � IDENTIFICA��O DA DATA
                // REGISTRO I310: DETALHES DO BALANCETE DI�RIO
                { Implementados a crit�rio do Participante do T2Ti ERP }

                // REGISTRO I350: SALDOS DAS CONTAS DE RESULTADO ANTES DO ENCERRAMENTO � IDENTIFICA��O DA DATA
                // REGISTRO I355: DETALHES DOS SALDOS DAS CONTAS DE RESULTADO ANTES DO ENCERRAMENTO
                { Implementados a crit�rio do Participante do T2Ti ERP }

                // REGISTRO I500: PAR�METROS DE IMPRESS�O E VISUALIZA��O DO LIVRO RAZ�O AUXILIAR COM LEIAUTE PARAMETRIZ�VEL
                // REGISTRO I510: DEFINI��O DE CAMPOS DO LIVRO RAZ�O AUXILIAR COM LEIAUTE PARAMETRIZ�VEL
                // REGISTRO I550: DETALHES DO LIVRO AUXILIAR COM LEIAUTE PARAMETRIZ�VEL
                // REGISTRO I555: TOTAIS NO LIVRO AUXILIAR COM LEIAUTE PARAMETRIZ�VEL
                { Implementados a crit�rio do Participante do T2Ti ERP }
              };
            */
        }

        #endregion

        #region Bloco J - Demonstra��es Cont�beis
        public void GerarBlocoJ()
        {
            /*
              ACBrSpedContabil.Bloco_J.LimpaRegistros;

              using ACBrSpedContabil.Bloco_J do
              {
                // REGISTRO J001: ABERTURA DO BLOCO J
                RegistroJ001.IND_DAD = 0;

                // REGISTRO J005: DEMONSTRA��ES CONT�BEIS
                { Implementado a crit�rio do Participante do T2Ti ERP }

                // REGISTRO J100: BALAN�O PATRIMONIAL
                { Implementado a crit�rio do Participante do T2Ti ERP }

                //REGISTRO J150: DEMONSTRA��O DO RESULTADO DO EXERC�CIO
                { Implementado a crit�rio do Participante do T2Ti ERP }
                ListaDreDetalhe = TT2TiORM.Consultar<TContabilDreDetalheVO>("ID>0", False);
                if assigned(ListaDreDetalhe) then
                {
                  for i = 0 to ListaDreDetalhe.Count - 1 do
                  {
                  };
                };

                // REGISTRO J200: TABELA DE HIST�RICO DE FATOS CONT�BEIS QUE MODIFICAM A CONTA LUCROS ACUMULADOS OU A CONTA PREJU�ZOS ACUMULADOS OU TODO O PATRIM�NIO L�QUIDO
                // REGISTRO J210: DLPA � DEMONSTRA��O DE LUCROS OU PREJU�ZOS ACUMULADOS/DMPL � DEMONSTRA��O DE MUTA��ES DO PATRIM�NIO L�QUIDO
                // REGISTRO J215: FATO CONT�BIL QUE ALTERA A CONTA LUCROS ACUMULADOS OU A CONTA PREJU�ZOS ACUMULADOS OU TODO O PATRIM�NIO L�QUIDO
                { Implementados a crit�rio do Participante do T2Ti ERP }

                // REGISTRO J310: DEMONSTRA��O DO FLUXO DE CAIXA
                { Implementado a crit�rio do Participante do T2Ti ERP }

                // REGISTRO J410: DEMONSTRA��O DO VALOR ADICIONADO
                { Implementado a crit�rio do Participante do T2Ti ERP }

                // REGISTRO J800: OUTRAS INFORMA��ES
                { Implementado a crit�rio do Participante do T2Ti ERP }

                // REGISTRO J900: TERMO DE ENCERRAMENTO
                ContabilLivro = TT2TiORM.ConsultarUmObjeto<TContabilLivroVO>("FORMA_ESCRITURACAO = " + QuotedStr(EscrituracaoForma) +  " and COMPETENCIA=" + QuotedStr(FormatDateTime("MM/YYYY", TextoParaData(DataInicial))), False);
                if Assigned(ContabilLivro) then
                {
                  TermoLivro = TT2TiORM.ConsultarUmObjeto<TContabilTermoVO>("ID_CONTABIL_LIVRO=" + IntToStr(ContabilLivro.Id) + " and ABERTURA_ENCERRAMENTO=" + QuotedStr("E"), False);
                  RegistroCartorio = TT2TiORM.ConsultarUmObjeto<TRegistroCartorioVO>("ID_EMPRESA=" + IntToStr(Sessao(SessaoAtual).IdEmpresa), False);

                  using RegistroJ900 do
                  {
                    NUM_ORD = TermoLivro.NumeroRegistro;
                    NAT_LIVRO = ContabilLivro.Descricao;
                    QTD_LIN = ACBrSpedContabil.Bloco_9.Registro9999.QTD_LIN;
                    NOME = Empresa.RazaoSocial;
                    DT_INI_ESCR = TermoLivro.EscrituracaoInicio;
                    DT_FIN_ESCR = TermoLivro.EscrituracaoFim;
                  };
                };

                // REGISTRO J930: IDENTIFICA��O DOS SIGNAT�RIOS DA ESCRITURA��O
                Contador = TT2TiORM.ConsultarUmObjeto<TContadorVO>("ID=1", True);
                using RegistroJ930.New do
                {
                  IDENT_NOM = Contador.PessoaNome;
                  IDENT_CPF = Contador.PessoaVO.PessoaFisicaVO.Cpf;
                  IDENT_QUALIF = "Contador";
                  COD_ASSIN = "900";
                  IND_CRC = Contador.InscricaoCrc;
                };
              };
            */
        }
        
        #endregion

        #region Gerar Arquivo
        public bool GerarArquivoSpedContabil(string pDataIni, string pDataFim, int pFormaEscrituracao, int pLayoutVersao, int pIdEmpresa)
        {
            /*
            DataInicial = pDataIni;
            DataFinal = pDataFim;
            IdEmpresa = pIdEmpresa;

            ACBrSpedContabil.DT_INI = Convert.ToDateTime(pDataIni);
            ACBrSpedContabil.DT_FIN = Convert.ToDateTime(pDataFim);

            using (Session = NHibernateHelper.getSessionFactory().OpenSession())
            {
                GerarBloco0;
                GerarBlocoI;
                GerarBlocoJ;
            }

            ACBrSpedContabil.SaveFileTXT();
             */
            return true;
        }
        #endregion

    }

}
