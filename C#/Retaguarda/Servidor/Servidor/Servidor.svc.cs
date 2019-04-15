using NHibernate;
using Servidor.DAL;
using Servidor.Model;
using Servidor.NHibernate;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Servidor
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please Select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceServidor : IServidor
    {
        #region Geração do Arquivo
        public byte[] GerarSped(string pDataIni, string pDataFim, string pVersao, string pFinalidade, string pPerfil, string pIdEmpresa, string pInventario, string pIdContador)
        {
            SpedFiscalDAL sped = new SpedFiscalDAL();

            try
            {
                if (sped.GerarArquivoSpedFiscal(pDataIni, pDataFim, int.Parse(pVersao), int.Parse(pFinalidade), int.Parse(pPerfil), int.Parse(pIdEmpresa), int.Parse(pInventario), int.Parse(pIdContador)))
                {
                    FileInfo fi = new FileInfo("C:\\T2Ti\\Arquivos\\SpedFiscal.txt");
                    FileStream fs = fi.OpenRead();
                    MemoryStream ms = new MemoryStream((int)fs.Length);
                    fs.CopyTo(ms);
                    fs.Close();
                    ms.Position = 0L;
                    return ms.ToArray();
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public byte[] GerarSintegra(string pDataIni, string pDataFim, string pCodigoConvenio, string pFinalidade, string pNaturezaInformacao, string pIdEmpresa, string pInventario, string pIdContador)
        {
            SintegraDAL sintegra = new SintegraDAL();

            try
            {
                if (sintegra.GerarArquivoSintegra(pDataIni, pDataFim, int.Parse(pCodigoConvenio), int.Parse(pFinalidade), int.Parse(pNaturezaInformacao), int.Parse(pIdEmpresa), int.Parse(pInventario), int.Parse(pIdContador)))
                {
                    FileInfo fi = new FileInfo("C:\\T2Ti\\Arquivos\\Sintegra.txt");
                    FileStream fs = fi.OpenRead();
                    MemoryStream ms = new MemoryStream((int)fs.Length);
                    fs.CopyTo(ms);
                    fs.Close();
                    ms.Position = 0L;
                    return ms.ToArray();
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Empresa
        public IList<EmpresaDTO> SelectEmpresa(EmpresaDTO empresa)
        {
            try
            {
                IList<EmpresaDTO> resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    EmpresaDAL DAL = new EmpresaDAL(Session);
                    resultado = DAL.Select(empresa);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<EmpresaDTO> SelectEmpresaPagina(int primeiroResultado, int quantidadeResultados, EmpresaDTO empresa)
        {
            try
            {
                IList<EmpresaDTO> resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    EmpresaDAL DAL = new EmpresaDAL(Session);
                    resultado = DAL.SelectPagina(primeiroResultado, quantidadeResultados, empresa);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Contador

        public IList<ContadorDTO> SelectContador(ContadorDTO contador)
        {
            try
            {
                IList<ContadorDTO> resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<ContadorDTO> DAL = new NHibernateDAL<ContadorDTO>(Session);
                    resultado = DAL.Select(contador);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<ContadorDTO> SelectContadorPagina(int primeiroResultado, int quantidadeResultados, ContadorDTO contador)
        {
            try
            {
                IList<ContadorDTO> resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<ContadorDTO> DAL = new NHibernateDAL<ContadorDTO>(Session);
                    resultado = DAL.SelectPagina<ContadorDTO>(primeiroResultado, quantidadeResultados, contador);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region UnidadeProduto

        public IList<UnidadeProdutoDTO> SelectUnidadeProduto(UnidadeProdutoDTO unidadeProduto)
        {
            try
            {
                IList<UnidadeProdutoDTO> resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<UnidadeProdutoDTO> DAL = new NHibernateDAL<UnidadeProdutoDTO>(Session);
                    resultado = DAL.Select(unidadeProduto);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<UnidadeProdutoDTO> SelectUnidadeProdutoPagina(int primeiroResultado, int quantidadeResultados, UnidadeProdutoDTO unidadeProduto)
        {
            try
            {
                IList<UnidadeProdutoDTO> resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<UnidadeProdutoDTO> DAL = new NHibernateDAL<UnidadeProdutoDTO>(Session);
                    resultado = DAL.SelectPagina<UnidadeProdutoDTO>(primeiroResultado, quantidadeResultados, unidadeProduto);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Produto
        public IList<ProdutoDTO> SelectProduto(ProdutoDTO produto)
        {
            try
            {
                IList<ProdutoDTO> resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoDTO> DAL = new NHibernateDAL<ProdutoDTO>(Session);
                    resultado = DAL.Select(produto);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<ProdutoDTO> SelectProdutoPagina(int primeiroResultado, int quantidadeResultados, ProdutoDTO produto)
        {
            try
            {
                IList<ProdutoDTO> resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoDTO> DAL = new NHibernateDAL<ProdutoDTO>(Session);
                    resultado = DAL.SelectPagina<ProdutoDTO>(primeiroResultado, quantidadeResultados, produto);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region NfeCabecalho
        public IList<NfeCabecalhoDTO> SelectNfeCabecalho(NfeCabecalhoDTO nfeCabecalho)
        {
            try
            {
                IList<NfeCabecalhoDTO> resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<NfeCabecalhoDTO> DAL = new NHibernateDAL<NfeCabecalhoDTO>(Session);
                    resultado = DAL.Select(nfeCabecalho);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<NfeCabecalhoDTO> SelectNfeCabecalhoPagina(int primeiroResultado, int quantidadeResultados, NfeCabecalhoDTO nfeCabecalho)
        {
            try
            {
                IList<NfeCabecalhoDTO> resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<NfeCabecalhoDTO> DAL = new NHibernateDAL<NfeCabecalhoDTO>(Session);
                    resultado = DAL.SelectPagina<NfeCabecalhoDTO>(primeiroResultado, quantidadeResultados, nfeCabecalho);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region DavCabecalho
        public void DeleteDavCabecalho(DavCabecalhoDTO davCabecalho)
        {
            try
            {
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<DavCabecalhoDTO> DAL = new NHibernateDAL<DavCabecalhoDTO>(Session);
                    DAL.Delete(davCabecalho);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public DavCabecalhoDTO SalvarAtualizarDavCabecalho(DavCabecalhoDTO davCabecalho)
        {
            try
            {
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<DavCabecalhoDTO> DAL = new NHibernateDAL<DavCabecalhoDTO>(Session);
                    DAL.SaveOrUpdate(davCabecalho);
                    Session.Flush();
                }
                return davCabecalho;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<DavCabecalhoDTO> SelectDavCabecalho(DavCabecalhoDTO davCabecalho)
        {
            try
            {
                IList<DavCabecalhoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<DavCabecalhoDTO> DAL = new NHibernateDAL<DavCabecalhoDTO>(Session);
                    Resultado = DAL.Select(davCabecalho);

                    foreach (DavCabecalhoDTO objP in Resultado)
                    {
                        NHibernateDAL<DavDetalheDTO> DALDetalhe = new NHibernateDAL<DavDetalheDTO>(Session);
                        objP.ListaDavDetalhe = DAL.Select<DavDetalheDTO>(new DavDetalheDTO { IdDavCabecalho = objP.Id });

                        if (objP.ListaDavDetalhe == null)
                            objP.ListaDavDetalhe = new List<DavDetalheDTO>();
                    }
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<DavCabecalhoDTO> SelectDavCabecalhoPagina(int primeiroResultado, int quantidadeResultados, DavCabecalhoDTO davCabecalho)
        {
            try
            {
                IList<DavCabecalhoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<DavCabecalhoDTO> DAL = new NHibernateDAL<DavCabecalhoDTO>(Session);
                    Resultado = DAL.SelectPagina<DavCabecalhoDTO>(primeiroResultado, quantidadeResultados, davCabecalho);

                    foreach (DavCabecalhoDTO objP in Resultado)
                    {
                        NHibernateDAL<DavDetalheDTO> DALDetalhe = new NHibernateDAL<DavDetalheDTO>(Session);
                        objP.ListaDavDetalhe = DAL.Select<DavDetalheDTO>(new DavDetalheDTO { IdDavCabecalho = objP.Id });

                        if (objP.ListaDavDetalhe == null)
                            objP.ListaDavDetalhe = new List<DavDetalheDTO>();
                    }
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public DavCabecalhoDTO SelectObjetoDavCabecalho(string pFiltro)
        {
            try
            {
                DavCabecalhoDTO Resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<DavCabecalhoDTO> DAL = new NHibernateDAL<DavCabecalhoDTO>(Session);
                    Resultado = DAL.SelectObjetoSql<DavCabecalhoDTO>(pFiltro);

                    if (Resultado != null)
                    {
                        NHibernateDAL<DavDetalheDTO> DALDetalhe = new NHibernateDAL<DavDetalheDTO>(Session);
                        Resultado.ListaDavDetalhe = DAL.Select<DavDetalheDTO>(new DavDetalheDTO { IdDavCabecalho = Resultado.Id });

                        if (Resultado.ListaDavDetalhe == null)
                            Resultado.ListaDavDetalhe = new List<DavDetalheDTO>();
                    }
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        #endregion 

        #region PreVendaCabecalho
        public void DeletePreVendaCabecalho(PreVendaCabecalhoDTO preVendaCabecalho)
        {
            try
            {
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<PreVendaCabecalhoDTO> DAL = new NHibernateDAL<PreVendaCabecalhoDTO>(Session);
                    DAL.Delete(preVendaCabecalho);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public PreVendaCabecalhoDTO SalvarAtualizarPreVendaCabecalho(PreVendaCabecalhoDTO preVendaCabecalho)
        {
            try
            {
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<PreVendaCabecalhoDTO> DAL = new NHibernateDAL<PreVendaCabecalhoDTO>(Session);
                    DAL.SaveOrUpdate(preVendaCabecalho);
                    Session.Flush();
                }
                return preVendaCabecalho;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<PreVendaCabecalhoDTO> SelectPreVendaCabecalho(PreVendaCabecalhoDTO preVendaCabecalho)
        {
            try
            {
                IList<PreVendaCabecalhoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<PreVendaCabecalhoDTO> DAL = new NHibernateDAL<PreVendaCabecalhoDTO>(Session);
                    Resultado = DAL.Select(preVendaCabecalho);

                    foreach (PreVendaCabecalhoDTO objP in Resultado)
                    {
                        NHibernateDAL<PreVendaDetalheDTO> DALDetalhe = new NHibernateDAL<PreVendaDetalheDTO>(Session);
                        objP.ListaPreVendaDetalhe = DAL.Select<PreVendaDetalheDTO>(new PreVendaDetalheDTO { IdPreVendaCabecalho = objP.Id });

                        if (objP.ListaPreVendaDetalhe == null)
                            objP.ListaPreVendaDetalhe = new List<PreVendaDetalheDTO>();
                    }
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<PreVendaCabecalhoDTO> SelectPreVendaCabecalhoPagina(int primeiroResultado, int quantidadeResultados, PreVendaCabecalhoDTO preVendaCabecalho)
        {
            try
            {
                IList<PreVendaCabecalhoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<PreVendaCabecalhoDTO> DAL = new NHibernateDAL<PreVendaCabecalhoDTO>(Session);
                    Resultado = DAL.SelectPagina<PreVendaCabecalhoDTO>(primeiroResultado, quantidadeResultados, preVendaCabecalho);

                    foreach (PreVendaCabecalhoDTO objP in Resultado)
                    {
                        NHibernateDAL<PreVendaDetalheDTO> DALDetalhe = new NHibernateDAL<PreVendaDetalheDTO>(Session);
                        objP.ListaPreVendaDetalhe = DAL.Select<PreVendaDetalheDTO>(new PreVendaDetalheDTO { IdPreVendaCabecalho = objP.Id });

                        if (objP.ListaPreVendaDetalhe == null)
                            objP.ListaPreVendaDetalhe = new List<PreVendaDetalheDTO>();
                    }
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public PreVendaCabecalhoDTO SelectObjetoPreVendaCabecalho(string pFiltro)
        {
            try
            {
                PreVendaCabecalhoDTO Resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<PreVendaCabecalhoDTO> DAL = new NHibernateDAL<PreVendaCabecalhoDTO>(Session);
                    Resultado = DAL.SelectObjetoSql<PreVendaCabecalhoDTO>(pFiltro);

                    if (Resultado != null)
                    {
                        NHibernateDAL<PreVendaDetalheDTO> DALDetalhe = new NHibernateDAL<PreVendaDetalheDTO>(Session);
                        Resultado.ListaPreVendaDetalhe = DAL.Select<PreVendaDetalheDTO>(new PreVendaDetalheDTO { IdPreVendaCabecalho = Resultado.Id });

                        if (Resultado.ListaPreVendaDetalhe == null)
                            Resultado.ListaPreVendaDetalhe = new List<PreVendaDetalheDTO>();
                    }
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        #endregion 



        #region Usuario
        public UsuarioDTO SelectUsuario(String login, String senha)
        {
            try
            {
                UsuarioDTO resultado = null;
                using (ISession Session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    UsuarioDAL DAL = new UsuarioDAL(Session);
                    resultado = DAL.Select(login, senha);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }
        #endregion

                
    }
}
