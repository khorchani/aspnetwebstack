﻿using System.IO;

namespace System.Web.WebPages.Deployment.Test
{
    internal static class DeploymentUtil
    {
        public static string GetBinDirectory()
        {
            var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            return Path.Combine(tempDirectory, "bin");
        }
    }
}