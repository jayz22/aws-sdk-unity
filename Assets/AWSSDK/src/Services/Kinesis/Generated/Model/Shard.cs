//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

/*
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// A uniquely identified group of data records in an Amazon Kinesis stream.
    /// </summary>
    public partial class Shard
    {
        private string _adjacentParentShardId;
        private HashKeyRange _hashKeyRange;
        private string _parentShardId;
        private SequenceNumberRange _sequenceNumberRange;
        private string _shardId;

        /// <summary>
        /// Gets and sets the property AdjacentParentShardId. 
        /// <para>
        /// The shard Id of the shard adjacent to the shard's parent.
        /// </para>
        /// </summary>
        public string AdjacentParentShardId
        {
            get { return this._adjacentParentShardId; }
            set { this._adjacentParentShardId = value; }
        }

        // Check to see if AdjacentParentShardId property is set
        internal bool IsSetAdjacentParentShardId()
        {
            return this._adjacentParentShardId != null;
        }

        /// <summary>
        /// Gets and sets the property HashKeyRange. 
        /// <para>
        /// The range of possible hash key values for the shard, which is a set of ordered contiguous
        /// positive integers.
        /// </para>
        /// </summary>
        public HashKeyRange HashKeyRange
        {
            get { return this._hashKeyRange; }
            set { this._hashKeyRange = value; }
        }

        // Check to see if HashKeyRange property is set
        internal bool IsSetHashKeyRange()
        {
            return this._hashKeyRange != null;
        }

        /// <summary>
        /// Gets and sets the property ParentShardId. 
        /// <para>
        /// The shard Id of the shard's parent.
        /// </para>
        /// </summary>
        public string ParentShardId
        {
            get { return this._parentShardId; }
            set { this._parentShardId = value; }
        }

        // Check to see if ParentShardId property is set
        internal bool IsSetParentShardId()
        {
            return this._parentShardId != null;
        }

        /// <summary>
        /// Gets and sets the property SequenceNumberRange. 
        /// <para>
        /// The range of possible sequence numbers for the shard.
        /// </para>
        /// </summary>
        public SequenceNumberRange SequenceNumberRange
        {
            get { return this._sequenceNumberRange; }
            set { this._sequenceNumberRange = value; }
        }

        // Check to see if SequenceNumberRange property is set
        internal bool IsSetSequenceNumberRange()
        {
            return this._sequenceNumberRange != null;
        }

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The unique identifier of the shard within the Amazon Kinesis stream.
        /// </para>
        /// </summary>
        public string ShardId
        {
            get { return this._shardId; }
            set { this._shardId = value; }
        }

        // Check to see if ShardId property is set
        internal bool IsSetShardId()
        {
            return this._shardId != null;
        }

    }
}