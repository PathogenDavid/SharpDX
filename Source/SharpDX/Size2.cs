// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel
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
using System.Runtime.InteropServices;

namespace SharpDX
{
    /// <summary>
    /// Structure using the same layout than <see cref="System.Drawing.Size"/>.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Size2
    {
        /// <summary>
        /// A zero size with (width, height) = (0,0)
        /// </summary>
        public static readonly Size2 Zero = new Size2(0, 0);

        /// <summary>
        /// A zero size with (width, height) = (0,0)
        /// </summary>
        public static readonly Size2 Empty = Zero;

        /// <summary>
        /// Initializes a new instance of the <see cref="Size2"/> struct.
        /// </summary>
        /// <param name="width">The x.</param>
        /// <param name="height">The y.</param>
        public Size2(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Width.
        /// </summary>
        public int Width;

        /// <summary>
        /// Height.
        /// </summary>
        public int Height;
    }
}