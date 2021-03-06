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

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// Tenant Configuration Synchronization State.
    /// </summary>
    public partial class TenantConfigurationSyncStateContract
    {
        private string _branch;
        
        /// <summary>
        /// Optional. Gets or sets the name of Git branch.
        /// </summary>
        public string Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }
        
        private string _commitId;
        
        /// <summary>
        /// Optional. Gets or sets the latest commit Id.
        /// </summary>
        public string CommitId
        {
            get { return this._commitId; }
            set { this._commitId = value; }
        }
        
        private System.DateTime? _configurationChangeDate;
        
        /// <summary>
        /// Optional. Gets or sets the date of the latest configuration change,
        /// in ISO 8601 format.
        /// </summary>
        public System.DateTime? ConfigurationChangeDate
        {
            get { return this._configurationChangeDate; }
            set { this._configurationChangeDate = value; }
        }
        
        private bool _isExport;
        
        /// <summary>
        /// Optional. Gets or sets value indicating if last sync was save
        /// (true) or deploy (false) operation.
        /// </summary>
        public bool IsExport
        {
            get { return this._isExport; }
            set { this._isExport = value; }
        }
        
        private bool _isGitEnabled;
        
        /// <summary>
        /// Optional. Gets or sets value indicating whether Git configuration
        /// access is enabled.
        /// </summary>
        public bool IsGitEnabled
        {
            get { return this._isGitEnabled; }
            set { this._isGitEnabled = value; }
        }
        
        private bool _isSynced;
        
        /// <summary>
        /// Optional. Gets or sets value indicating if last synchronization was
        /// later than the configuration change.
        /// </summary>
        public bool IsSynced
        {
            get { return this._isSynced; }
            set { this._isSynced = value; }
        }
        
        private System.DateTime? _syncDate;
        
        /// <summary>
        /// Optional. Gets or sets the date of the latest synchronization, in
        /// ISO 8601 format.
        /// </summary>
        public System.DateTime? SyncDate
        {
            get { return this._syncDate; }
            set { this._syncDate = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// TenantConfigurationSyncStateContract class.
        /// </summary>
        public TenantConfigurationSyncStateContract()
        {
        }
    }
}
