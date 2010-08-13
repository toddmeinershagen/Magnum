﻿// Copyright 2007-2010 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Magnum.Servers.Internal
{
	using System;
	using System.Collections.Specialized;
	using System.IO;
	using System.Net;


	public class HttpRequestContext :
		RequestContext
	{
		readonly HttpListenerRequest _request;

		public HttpRequestContext(HttpListenerRequest request)
		{
			_request = request;
		}

		public NameValueCollection Headers
		{
			get { return _request.Headers; }
		}

		public Stream InputStream
		{
			get { return _request.InputStream; }
		}

		public NameValueCollection QueryString
		{
			get { return _request.QueryString; }
		}

		public Uri Url
		{
			get { return _request.Url; }
		}

		public string HttpMethod
		{
			get { return _request.HttpMethod; }
		}

		public string RawUrl
		{
			get { return _request.RawUrl; }
		}
	}
}