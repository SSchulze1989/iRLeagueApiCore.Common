using System;
using System.Runtime.Serialization;
using iRLeagueApiCore.Common.Enums;
using System.Collections.Generic;
#if NETCOREAPP
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
#endif

namespace iRLeagueApiCore.Common.Models
{
    /// <summary>
    /// Scheme for creating and updating a session entry
    /// </summary>
    [DataContract]
    public class PutSessionModel
    {
        /// <summary>
        /// Name of the session
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Session type specifier - 0 = Undefined, 1 = Practice, 2 = Qualifying, 3 = Race, 4 = HeatEvent, 5 = Heat, 6 = Warmup
        /// </summary>
        [DataMember]
#if NETCOREAPP
        [EnumDataType(typeof(SessionType))]
        [JsonConverter(typeof(JsonStringEnumConverter))]
#endif
        public SessionType SessionType { get; set; }
    }
}
