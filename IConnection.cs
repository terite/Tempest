﻿// The MIT License
//
// Copyright (c) 2010 Eric Maupin
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

using System;
using System.Linq;
using System.Net;

namespace Tempest
{
	/// <summary>
	/// Base connection contract.
	/// </summary>
	public interface IConnection
	{
		/// <summary>
		/// Gets the remote endpoint for this connection.
		/// </summary>
		EndPoint RemoteEndPoint { get; }

		/// <summary>
		/// Gets whether the connection is alive or not.
		/// </summary>
		bool IsConnected { get; }

		/// <summary>
		/// Gets whether the connection is asynchronous or not.
		/// </summary>
		bool IsAsync { get; }

		/// <summary>
		/// Queues a message to send to this connection.
		/// </summary>
		/// <param name="message">The message to send.</param>
		/// <exception cref="ArgumentNullException"><paramref name="message"/> is <c>null</c>.</exception>
		void Send (Message message);

		/// <summary>
		/// Closes the connection.
		/// </summary>
		void Disconnect();
	}
}