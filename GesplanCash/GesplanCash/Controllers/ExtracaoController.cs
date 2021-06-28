using GesplanCash.Models;
using Newtonsoft.Json.Linq;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Xml;

namespace GesplanCash.Controllers
{
    public class ExtracaoController : ApiController
    {
        /// <summary>
        /// Método responsável pela extração de informações financeiras para alimentação do CASH
        /// </summary>
        /// <param name="param">XML de chamada do serviço</param>
        /// <remarks>
        /// Informar usuário e senha de autenticação no Header da Requisição
        /// Exemplo de entrada:
        /// 
        /// ExtracaoCash
        /// 
        ///     coligada 0 /coligada
        ///     codSistema F /codSistema
        ///     codSentenca SQL.GESPLAN.001 /codSentenca
        ///		parametros DT_INICIO_D=2021-04-30 15:17:00;DT_FIM_D=2021-04-30 15:20:00 /parametros
        ///		
        /// /ExtracaoCash
        ///     
        /// </remarks>
        /// <returns>Retorna execução da consulta em XML</returns> 
        [HttpPost]
        public HttpResponseMessage DadosCash(ExtracaoCash param)
        {
            HttpContext httpContext = HttpContext.Current;
            string authHeader = httpContext.Request.Headers["Authorization"];

            if (authHeader != null && authHeader.StartsWith("Basic"))
            {
                #region Leitura do Header para identificação da autenticação
                string encodedUsernamePassword = authHeader.Substring("Basic ".Length).Trim();
                Encoding encoding = Encoding.GetEncoding("iso-8859-1");
                string usernamePassword = encoding.GetString(Convert.FromBase64String(encodedUsernamePassword));
                #endregion

                int seperatorIndex = usernamePassword.IndexOf(':');

                var username = usernamePassword.Substring(0, seperatorIndex);
                var password = usernamePassword.Substring(seperatorIndex + 1);

                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    throw new Exception("Usuário ou senha não informado para autenticação");
                }
                else
                {
                    var ret = string.Empty;

                    #region Propriedades Herdadas do XML de entrada
                    var coligada = 0;
                    var codSentenca = string.Empty;
                    var codSistema = string.Empty;
                    var parametros = string.Empty;

                    coligada = param.coligada;
                    codSentenca = param.codSentenca;
                    codSistema = param.codSistema;
                    parametros = param.parametros;
                    #endregion

                    ret = ExtracaoCash.RetornoExtracao(username, password, coligada, codSistema, codSentenca, parametros);

                    return new HttpResponseMessage(HttpStatusCode.Accepted) { Content = new StringContent(ret, Encoding.UTF8, "application/xml") };
                }
            }
            else
            {
                throw new Exception("Configuração de autorização não preenchida. Autorização > Basic > Usuário/Senha");
            }
        }
    }
}