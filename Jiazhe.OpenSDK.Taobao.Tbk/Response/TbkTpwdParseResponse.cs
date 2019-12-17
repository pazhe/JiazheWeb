using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    public class TbkTpwdParseResponse : TopResponse
    {
        /// <summary>
        /// data
        /// </summary>
        [XmlElement("data")]
        public MapDataDomain Data { get; set; }

        /// <summary>
        /// MapDataDomain Data Structure.
        /// </summary>
        [Serializable]

        public class MapDataDomain : TopObject
        {
            /// <summary>
            /// password
            /// </summary>
            [XmlElement("model")]
            public string Model { get; set; }
        }

    }
}
