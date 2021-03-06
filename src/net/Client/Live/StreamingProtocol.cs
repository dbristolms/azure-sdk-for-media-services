﻿// Copyright 2012 Microsoft Corporation
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    /// <summary>
    /// The ingest streaming protocol.
    /// </summary>
    public enum StreamingProtocol
    {
        /// <summary>
        /// Smooth Streaming.
        /// </summary>
        FragmentedMP4 = 0,

        /// <summary>
        /// RTMP.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        RTMP = 1,

        /// <summary>
        /// MPEG-2 TS over RTP.
        /// </summary>
        RTPMPEG2TS = 2
    }
}
