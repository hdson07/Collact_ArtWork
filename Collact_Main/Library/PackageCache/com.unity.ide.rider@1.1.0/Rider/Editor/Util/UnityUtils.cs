<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> master
using System;
using System.Linq;
using UnityEngine;

namespace Packages.Rider.Editor.Util
{
  public static class UnityUtils
  {
    internal static readonly string UnityApplicationVersion = Application.unityVersion;
    
    public static Version UnityVersion
    {
      get
      {
        var ver = UnityApplicationVersion.Split(".".ToCharArray()).Take(2).Aggregate((a, b) => a + "." + b);
        return new Version(ver);
      }
    }
  }
<<<<<<< HEAD
=======
=======
using System;
using System.Linq;
using UnityEngine;

namespace Packages.Rider.Editor.Util
{
  public static class UnityUtils
  {
    internal static readonly string UnityApplicationVersion = Application.unityVersion;
    
    public static Version UnityVersion
    {
      get
      {
        var ver = UnityApplicationVersion.Split(".".ToCharArray()).Take(2).Aggregate((a, b) => a + "." + b);
        return new Version(ver);
      }
    }
  }
>>>>>>> ee8cad548e0c46c07d6428cc26597e2b0d6b6da5
>>>>>>> master
}