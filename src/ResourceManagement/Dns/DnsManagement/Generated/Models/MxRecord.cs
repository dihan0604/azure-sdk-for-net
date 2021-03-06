// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Dns.Models
{
    /// <summary>
    /// An MX record.
    /// </summary>
    public partial class MxRecord
    {
        private string _exchange;
        
        /// <summary>
        /// Required. Gets or sets the domain name of the mail host, without a
        /// terminating dot.
        /// </summary>
        public string Exchange
        {
            get { return this._exchange; }
            set { this._exchange = value; }
        }
        
        private int _preference;
        
        /// <summary>
        /// Required. Gets or sets the preference metric for this record.
        /// </summary>
        public int Preference
        {
            get { return this._preference; }
            set { this._preference = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MxRecord class.
        /// </summary>
        public MxRecord()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the MxRecord class with required
        /// arguments.
        /// </summary>
        public MxRecord(int preference, string exchange)
            : this()
        {
            if (exchange == null)
            {
                throw new ArgumentNullException("exchange");
            }
            this.Preference = preference;
            this.Exchange = exchange;
        }
    }
}
