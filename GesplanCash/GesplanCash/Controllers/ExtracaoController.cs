using ConectorRM.Models;
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

namespace ConectorRM.Controllers
{
    public class ExtracaoController : ApiController
    {
        /// <summary>
        /// Método responsável pela execução de Consulta SQL no RM via WebService para extração de dados
        /// </summary>
        /// <param name="param">XML de chamada do serviço</param>
        /// <remarks>
        /// Informar usuário e senha de autenticação no Header da Requisição
        /// Exemplo de entrada:
        /// 
        /// ExtracaoRM
        /// 
        ///     coligada 0 /coligada
        ///     codSistema F /codSistema
        ///     codSentenca SQL.GESPLAN.001 /codSentenca
        ///		parametros DT_INICIO_D=2021-04-30 15:17:00;DT_FIM_D=2021-04-30 15:20:00 /parametros
        ///		
        /// /ExtracaoRM
        ///     
        /// </remarks>
        /// <returns>Retorna execução da consulta em XML</returns> 
        [HttpPost]
        public HttpResponseMessage wsConsultaSQL(ExtracaoRM param)
        {
            if(param != null)
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
                        return new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("Usuário ou senha não informados ou inválidos.") };
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
                        try
                        {
                            ret = ExtracaoRM.RetornoExtracao(username, password, coligada, codSistema, codSentenca, parametros);

                            if (!ret.Contains("Resultado"))
                            {
                                throw new Exception(ret);
                            }

                            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(WebUtility.HtmlDecode(ret), Encoding.UTF8, "application/xml") };
                        }
                        catch (Exception ex)
                        {
                            if (!ret.Contains("NewDataSet"))
                            {
                                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(ex.Message, Encoding.UTF8, "application/xml") };
                            }
                            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("<NewDataSet><Resultado></Resultado></NewDataSet>", Encoding.UTF8, "application/xml") };
                        }
                    }
                }
                else
                {
                    return new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("Configuração de autorização não preenchida. Autorização > Basic > Usuário/Senha.") };
                }
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("XML não informado ou é inválido.") };
            }
        }
    }
}