﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Network.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class PSNetworkInterfaceIPConfiguration : PSIPConfiguration
    {
        [JsonProperty(Order = 2)]
        public List<PSBackendAddressPool> LoadBalancerBackendAddressPools { get; set; }

        [JsonProperty(Order = 2)]
        public List<PSInboundNatRule> LoadBalancerInboundNatRules { get; set; }

        [JsonProperty(Order = 2)]
        public List<PSInboundNatPool> LoadBalancerInboundNatPools { get; set; }

        [JsonIgnore]
        public string LoadBalancerBackendAddressPoolsText
        {
            get { return JsonConvert.SerializeObject(LoadBalancerBackendAddressPools, Formatting.Indented); }
        }

        [JsonIgnore]
        public string LoadBalancerInboundNatRulesText
        {
            get { return JsonConvert.SerializeObject(LoadBalancerInboundNatRules, Formatting.Indented); }
        }

        [JsonIgnore]
        public string LoadBalancerInboundNatPoolsText
        {
            get { return JsonConvert.SerializeObject(LoadBalancerInboundNatPools, Formatting.Indented); }
        }
    }
}
