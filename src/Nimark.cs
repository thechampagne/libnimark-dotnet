/*
* Copyright (c) 2023 XXIV
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*/
#nullable enable
using System;
using System.Runtime.InteropServices;

public class Nimark
{
#if Windows
    private const string LIB = "libnimark.dll";
#elif OSX
    private const string LIB = "libnimark.dylib";
#else
    private const string LIB = "libnimark.so";
#endif

    [DllImport (LIB)]
    private static extern void free(IntPtr ptr);
	
    [DllImport (LIB)]
    private static extern void nimark_init();
    
    [DllImport (LIB)]
    private static extern IntPtr nimark_markdown(string lines);

    public Nimark()
    {
	nimark_init();
    }
    
    public string? Markdown(string lines)
    {
	var res = nimark_markdown(lines);
	if (res == IntPtr.Zero)
	{
	    return null;
	}
	var str = Marshal.PtrToStringAnsi(res);
	free(res);
	return str;
    }
}
