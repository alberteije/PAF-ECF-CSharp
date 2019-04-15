using Servidor.Model;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServidor
    {

        #region Geração do Arquivo
        [OperationContract]
        byte[] GerarSped(string pDataIni, string pDataFim, string pVersao, string pFinalidade, string pPerfil, string pIdEmpresa, string pInventario, string pIdContador);
        [OperationContract]
        byte[] GerarSintegra(string pDataIni, string pDataFim, string pCodigoConvenio, string pFinalidade, string pNaturezaInformacao, string pIdEmpresa, string pInventario, string pIdContador);
        #endregion

        #region Empresa
        [OperationContract]
        IList<EmpresaDTO> SelectEmpresa(EmpresaDTO empresa);
        [OperationContract]
        IList<EmpresaDTO> SelectEmpresaPagina(int primeiroResultado, int quantidadeResultados, EmpresaDTO empresa);
        #endregion

        #region Contador
        [OperationContract]
        IList<ContadorDTO> SelectContador(ContadorDTO contador);
        [OperationContract]
        IList<ContadorDTO> SelectContadorPagina(int primeiroResultado, int quantidadeResultados, ContadorDTO contador);
        #endregion

        #region UnidadeProduto
        [OperationContract]
        IList<UnidadeProdutoDTO> SelectUnidadeProduto(UnidadeProdutoDTO unidadeProduto);
        [OperationContract]
        IList<UnidadeProdutoDTO> SelectUnidadeProdutoPagina(int primeiroResultado, int quantidadeResultados, UnidadeProdutoDTO unidadeProduto);
        #endregion

        #region Produto
        [OperationContract]
        IList<ProdutoDTO> SelectProduto(ProdutoDTO produto);
        [OperationContract]
        IList<ProdutoDTO> SelectProdutoPagina(int primeiroResultado, int quantidadeResultados, ProdutoDTO produto);
        #endregion

        #region NfeCabecalho
        [OperationContract]
        IList<NfeCabecalhoDTO> SelectNfeCabecalho(NfeCabecalhoDTO nfeCabecalho);
        [OperationContract]
        IList<NfeCabecalhoDTO> SelectNfeCabecalhoPagina(int primeiroResultado, int quantidadeResultados, NfeCabecalhoDTO nfeCabecalho);
        #endregion

        #region DavCabecalho
        [OperationContract]
        void DeleteDavCabecalho(DavCabecalhoDTO davCabecalho);
        [OperationContract]
        DavCabecalhoDTO SalvarAtualizarDavCabecalho(DavCabecalhoDTO davCabecalho);
        [OperationContract]
        IList<DavCabecalhoDTO> SelectDavCabecalho(DavCabecalhoDTO davCabecalho);
        [OperationContract]
        IList<DavCabecalhoDTO> SelectDavCabecalhoPagina(int primeiroResultado, int quantidadeResultados, DavCabecalhoDTO davCabecalho);
        [OperationContract]
        DavCabecalhoDTO SelectObjetoDavCabecalho(string pFiltro);
        #endregion 

        #region PreVendaCabecalho
        [OperationContract]
        void DeletePreVendaCabecalho(PreVendaCabecalhoDTO preVendaCabecalho);
        [OperationContract]
        PreVendaCabecalhoDTO SalvarAtualizarPreVendaCabecalho(PreVendaCabecalhoDTO preVendaCabecalho);
        [OperationContract]
        IList<PreVendaCabecalhoDTO> SelectPreVendaCabecalho(PreVendaCabecalhoDTO preVendaCabecalho);
        [OperationContract]
        IList<PreVendaCabecalhoDTO> SelectPreVendaCabecalhoPagina(int primeiroResultado, int quantidadeResultados, PreVendaCabecalhoDTO preVendaCabecalho);
        [OperationContract]
        PreVendaCabecalhoDTO SelectObjetoPreVendaCabecalho(string pFiltro);
        #endregion 


        #region Usuario
        [OperationContract]
        UsuarioDTO SelectUsuario(String login, String senha);
        #endregion

    }


    
}
