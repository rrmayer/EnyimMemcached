﻿using System;

namespace Enyim.Caching.Memcached.Results.StatusCodes
{
    public enum StatusCode
    {
        NodeNotFound = -2,
        UnspecifiedError = -1,
        NoError = 0,
        KeyNotFound = 1,
        KeyExists = 2,
        ValueTooLarge = 3,
        InvalidArguments = 4,
        ItemNotStored = 5,
        IncrDecrOnNonNumericValue = 6,
        Unauthorized = 0x20,
        ContinueAuthentication = 0x21,
        UnknownCommand = 0x81,
        OutOfMemory = 0x82
    }

    public static class Converter
    {
        public static StatusCode ToStatusCode(this int input)
        {
            if (input >= -2 && input <= 6 || input == 0x20 || input == 0x21 || input == 0x81 || input == 0x82)
                return (StatusCode)input;

            return StatusCode.UnspecifiedError;
        }
    }
}

#region [ License information          ]
/* ************************************************************
 * 
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2012 Couchbase, Inc.
 *    @copyright 2012 Attila Kiskó, enyim.com
 *    
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *    
 *        http://www.apache.org/licenses/LICENSE-2.0
 *    
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *    
 * ************************************************************/
#endregion
