﻿using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class PutScheduleModel
    {
        [DataMember]
        public string Name { get; set; }
    }
}