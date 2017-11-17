﻿//
// Message.cs
//
// Author: Kees van Spelde <sicos2002@hotmail.com>
//
// Copyright (c) 2017 Magic-Sessions. (www.magic-sessions.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChromeHtmlToPdfLib.Protocol
{
    /// <summary>
    /// The JSON message that is sent to Chrome
    /// </summary>
    public class Message : MessageBase
    {
        #region Properties
        /// <summary>
        /// The parameters that we want to feed into the <see cref="Method"/>
        /// </summary>
        [JsonProperty("params")]
        public Dictionary<string, object> Parameters { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Creates this object and sets it's needed properties
        /// </summary>
        public Message()
        {
            Id = 1;
            Parameters = new Dictionary<string, object>();
        }
        #endregion

        #region AddParaneter
        /// <summary>
        /// Add's a parameter to <see cref="Parameters"/>
        /// </summary>
        /// <param name="name">The name</param>
        /// <param name="value">The value</param>
        public void AddParameter(string name, object value)
        {
            Parameters.Add(name, value);   
        }
        #endregion

        #region ToJson
        /// <summary>
        /// Returns this object as a JSON string
        /// </summary>
        /// <returns></returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            });
        }
        #endregion
    }
}
