using System;
using System.Data;
using System.Runtime.Serialization;
using System.Xml;

namespace GesplanCash.Models
{
    [DataContract(Namespace = "")]
    public class ExtracaoCash
    {
        [DataMember(Order = 0)]
        public int coligada { get; set; }

        [DataMember(Order = 1)]
        public string codSistema { get; set; }

        [DataMember(Order = 2)]
        public string codSentenca { get; set; }

        [DataMember(Order = 3)]
        public string parametros { get; set; }

        public static string RetornoExtracao(string usr, string pwd, int coligada, string codSistema, string codSentenca, string parametros)
        {
            var ret = string.Empty;

            WebServiceCall ws = new WebServiceCall();

            var context = string.Format("codcoligada={0};codusuario={1}", coligada, usr);

            var wsReturn = ws.ExecutaConsultaBase(usr, pwd, codSentenca, coligada, codSistema, parametros);

            ret = wsReturn;

            return ret;
        }
    }
}