using System;
using System.Data;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml;

namespace GesplanCash.Models
{
    public class WebServiceCall
    {

        #region Tratativas relacionadas aos serviços de Leitura e Escrita de Registros
        public DataSet LerRegistro(string userName, string password, string dataServer, string registro, string context)
        {
            var ret = new DataSet();

            string retorno = string.Empty;

            try
            {
                wsDataServer.IwsDataServerClient servico = new wsDataServer.IwsDataServerClient();

                servico.ClientCredentials.UserName.UserName = userName.ToString();
                servico.ClientCredentials.UserName.Password = password.ToString();

                using (new OperationContextScope(servico.InnerChannel))
                {
                    string auth = "Basic " + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(servico.ClientCredentials.UserName.UserName + ":" + servico.ClientCredentials.UserName.Password));

                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                    requestMessage.Headers["Authorization"] = auth;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;
                    retorno = servico.ReadRecord(dataServer, registro, context);
                }

                XmlTextReader xtr = new XmlTextReader(new System.IO.StringReader(retorno));

                //ret = retorno.Substring(0, retorno.LastIndexOf("</GUSUARIO>"));

                ret.ReadXml(xtr);
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable("MyTable");
                dt.Columns.Add(new DataColumn("id", typeof(int)));
                dt.Columns.Add(new DataColumn("message", typeof(string)));

                DataRow errorLine = dt.NewRow();

                errorLine["id"] = 1;
                errorLine["message"] = "Erro na chamada de serviço. Mensagem: " + ex.Message;
                dt.Rows.Add(errorLine);
                ret.Tables.Add(dt);
            }

            return ret;
        }

        public DataSet LerVisao(string userName, string password, string dataServer, string filter, string context)
        {
            var ret = new DataSet();

            wsDataServer.IwsDataServerClient servico = new wsDataServer.IwsDataServerClient();

            servico.ClientCredentials.UserName.UserName = userName.ToString();
            servico.ClientCredentials.UserName.Password = password.ToString();

            string retorno = string.Empty;

            try
            {
                using (new OperationContextScope(servico.InnerChannel))
                {
                    string auth = "Basic " + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(servico.ClientCredentials.UserName.UserName + ":" + servico.ClientCredentials.UserName.Password));

                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                    requestMessage.Headers["Authorization"] = auth;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;
                    retorno = servico.ReadView(dataServer, filter, context);
                }

                XmlTextReader xtr = new XmlTextReader(new System.IO.StringReader(retorno));

                //ret = retorno.Substring(0, retorno.LastIndexOf("</GUSUARIO>"));

                ret.ReadXml(xtr);
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable("MyTable");
                dt.Columns.Add(new DataColumn("id", typeof(int)));
                dt.Columns.Add(new DataColumn("message", typeof(string)));

                DataRow errorLine = dt.NewRow();

                errorLine["id"] = 1;
                errorLine["message"] = "Erro na chamada de serviço. Mensagem: " + ex.Message;
                dt.Rows.Add(errorLine);
                ret.Tables.Add(dt);
            }

            return ret;
        }
        #endregion

        #region Tratativas relacionadas aos processo de Geração de Acordos
        public string ValidaProcesso(string userName, string password)
        {
            var ret = string.Empty;

            wsProcess.IwsProcessClient servico = new wsProcess.IwsProcessClient();

            servico.ClientCredentials.UserName.UserName = userName.ToString();
            servico.ClientCredentials.UserName.Password = password.ToString();

            var xmlEntrada = string.Empty;

            try
            {
                using (new OperationContextScope(servico.InnerChannel))
                {
                    string auth = "Basic " + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(servico.ClientCredentials.UserName.UserName + ":" + servico.ClientCredentials.UserName.Password));

                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                    requestMessage.Headers["Authorization"] = auth;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;
                    xmlEntrada = servico.AutenticaAcesso();
                }

                ret = xmlEntrada;
            }
            catch (Exception ex)
            {
                throw new Exception(ret = "Erro ao autenticar acesso ao webService de Processos. Mensagem de erro: " + ex.Message);
            }

            return ret;
        }

        public string ExecutaProcesso(string userName, string password, string dataServer, string xml)
        {
            var ret = string.Empty;

            wsProcess.IwsProcessClient servico = new wsProcess.IwsProcessClient();

            servico.ClientCredentials.UserName.UserName = userName.ToString();
            servico.ClientCredentials.UserName.Password = password.ToString();

            var xmlEntrada = string.Empty;

            try
            {
                using (new OperationContextScope(servico.InnerChannel))
                {
                    string auth = "Basic " + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(servico.ClientCredentials.UserName.UserName + ":" + servico.ClientCredentials.UserName.Password));

                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                    requestMessage.Headers["Authorization"] = auth;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;
                    xmlEntrada = servico.ExecuteWithXmlParams(dataServer, xml);
                }

                ret = xmlEntrada;
            }
            catch (Exception ex)
            {
                throw new Exception(ret = "Erro ao Executar Processo. Mensagem de erro: " + ex.Message);
            }

            return ret;
        }

        public string RetornaStatusProcesso(string userName, string password, int jobId, int exec)
        {
            var ret = string.Empty;

            wsProcess.IwsProcessClient servico = new wsProcess.IwsProcessClient();

            servico.ClientCredentials.UserName.UserName = userName.ToString();
            servico.ClientCredentials.UserName.Password = password.ToString();

            var xmlEntrada = string.Empty;

            try
            {
                using (new OperationContextScope(servico.InnerChannel))
                {
                    string auth = "Basic " + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(servico.ClientCredentials.UserName.UserName + ":" + servico.ClientCredentials.UserName.Password));

                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                    requestMessage.Headers["Authorization"] = auth;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;
                    xmlEntrada = servico.GetProcessStatus(jobId, exec);
                }

                ret = xmlEntrada;
            }
            catch (Exception ex)
            {
                throw new Exception(ret = "Erro ao Executar Processo. Mensagem de erro: " + ex.Message);
            }

            return ret;
        }
        #endregion

        #region Tratativas relacionadas aos serviços de Consulta à Base de Informações
        public string ExecutaConsultaBase(string userName, string password, string codSentenca, int coligada, string sistema, string parametros)
        {
            var ret = string.Empty;

            wsConsultaSQL.IwsConsultaSQLClient servico = new wsConsultaSQL.IwsConsultaSQLClient();

            servico.ClientCredentials.UserName.UserName = userName.ToString();
            servico.ClientCredentials.UserName.Password = password.ToString();

            string retorno = string.Empty;

            try
            {
                using (new OperationContextScope(servico.InnerChannel))
                {
                    string auth = "Basic " + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(servico.ClientCredentials.UserName.UserName + ":" + servico.ClientCredentials.UserName.Password));

                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                    requestMessage.Headers["Authorization"] = auth;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;
                    retorno = servico.RealizarConsultaSQL(codSentenca, coligada, sistema, parametros);
                }

                XmlTextReader xtr = new XmlTextReader(new System.IO.StringReader(retorno));

                //ret = retorno.Substring(0, retorno.LastIndexOf("</GUSUARIO>"));

                ret = retorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ret;
        }
        #endregion
    }
}