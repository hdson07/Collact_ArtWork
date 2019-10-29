<<<<<<< HEAD
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Packages.Rider.Editor.Util
{
  internal static class LibcNativeInterop
  {
    [DllImport("libc", SetLastError = true)] 
    public static extern IntPtr realpath(string path, StringBuilder resolved_path);
  }
=======
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Packages.Rider.Editor.Util
{
  internal static class LibcNativeInterop
  {
    [DllImport("libc", SetLastError = true)] 
    public static extern IntPtr realpath(string path, StringBuilder resolved_path);
  }
>>>>>>> ee8cad548e0c46c07d6428cc26597e2b0d6b6da5
}