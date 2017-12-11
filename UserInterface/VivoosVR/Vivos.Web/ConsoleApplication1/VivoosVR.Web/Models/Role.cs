﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ConsoleApplication1.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Role
    {
        /// <summary>
        /// Initializes a new instance of the Role class.
        /// </summary>
        public Role() { }

        /// <summary>
        /// Initializes a new instance of the Role class.
        /// </summary>
        public Role(string code = default(string), string description = default(string), bool? available = default(bool?), IList<Claim> claims = default(IList<Claim>), IList<RoleToUserMap> roleToUserMaps = default(IList<RoleToUserMap>))
        {
            Code = code;
            Description = description;
            Available = available;
            Claims = claims;
            RoleToUserMaps = roleToUserMaps;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Available")]
        public bool? Available { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Claims")]
        public IList<Claim> Claims { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoleToUserMaps")]
        public IList<RoleToUserMap> RoleToUserMaps { get; set; }

    }
}