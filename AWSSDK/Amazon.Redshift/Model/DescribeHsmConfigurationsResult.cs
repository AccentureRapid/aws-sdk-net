/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeHsmConfigurationsResult
    {
        
        private string marker;
        private List<HsmConfiguration> hsmConfigurations = new List<HsmConfiguration>();

        /// <summary>
        /// A value that indicates the starting point for the next set of response records in a subsequent request. If a value is returned in a
        /// response, you can retrieve the next set of records by providing this returned marker value in the <c>Marker</c> parameter and retrying the
        /// command. If the <c>Marker</c> field is empty, all response records have been retrieved for the request.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeHsmConfigurationsResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of Amazon Redshift HSM configurations.
        ///  
        /// </summary>
        public List<HsmConfiguration> HsmConfigurations
        {
            get { return this.hsmConfigurations; }
            set { this.hsmConfigurations = value; }
        }
        /// <summary>
        /// Adds elements to the HsmConfigurations collection
        /// </summary>
        /// <param name="hsmConfigurations">The values to add to the HsmConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeHsmConfigurationsResult WithHsmConfigurations(params HsmConfiguration[] hsmConfigurations)
        {
            foreach (HsmConfiguration element in hsmConfigurations)
            {
                this.hsmConfigurations.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the HsmConfigurations collection
        /// </summary>
        /// <param name="hsmConfigurations">The values to add to the HsmConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeHsmConfigurationsResult WithHsmConfigurations(IEnumerable<HsmConfiguration> hsmConfigurations)
        {
            foreach (HsmConfiguration element in hsmConfigurations)
            {
                this.hsmConfigurations.Add(element);
            }

            return this;
        }

        // Check to see if HsmConfigurations property is set
        internal bool IsSetHsmConfigurations()
        {
            return this.hsmConfigurations.Count > 0;
        }
    }
}