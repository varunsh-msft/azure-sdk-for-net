// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Decomposes compound words found in many Germanic languages. This token
    /// filter is implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/compound/DictionaryCompoundWordTokenFilter.html" />
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.DictionaryDecompounderTokenFilter")]
    public partial class DictionaryDecompounderTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DictionaryDecompounderTokenFilter class.
        /// </summary>
        public DictionaryDecompounderTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the
        /// DictionaryDecompounderTokenFilter class.
        /// </summary>
        public DictionaryDecompounderTokenFilter(string name, IList<string> wordList, int? minWordSize = default(int?), int? minSubwordSize = default(int?), int? maxSubwordSize = default(int?), bool? onlyLongestMatch = default(bool?))
            : base(name)
        {
            WordList = wordList;
            MinWordSize = minWordSize;
            MinSubwordSize = minSubwordSize;
            MaxSubwordSize = maxSubwordSize;
            OnlyLongestMatch = onlyLongestMatch;
        }

        /// <summary>
        /// Gets or sets the list of words to match against.
        /// </summary>
        [JsonProperty(PropertyName = "wordList")]
        public IList<string> WordList { get; set; }

        /// <summary>
        /// Gets or sets the minimum word size. Only words longer than this
        /// get processed. Default is 5. Maximum is 300.
        /// </summary>
        [JsonProperty(PropertyName = "minWordSize")]
        public int? MinWordSize { get; set; }

        /// <summary>
        /// Gets or sets the minimum subword size. Only subwords longer than
        /// this are outputted. Default is 2. Maximum is 300.
        /// </summary>
        [JsonProperty(PropertyName = "minSubwordSize")]
        public int? MinSubwordSize { get; set; }

        /// <summary>
        /// Gets or sets the maximum subword size. Only subwords shorter than
        /// this are outputted. Default is 15. Maximum is 300.
        /// </summary>
        [JsonProperty(PropertyName = "maxSubwordSize")]
        public int? MaxSubwordSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to add only the longest
        /// matching subword to the output. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "onlyLongestMatch")]
        public bool? OnlyLongestMatch { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (WordList == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WordList");
            }
            if (this.MinWordSize > 300)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MinWordSize", 300);
            }
            if (this.MinSubwordSize > 300)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MinSubwordSize", 300);
            }
            if (this.MaxSubwordSize > 300)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxSubwordSize", 300);
            }
        }
    }
}
