﻿using System;
using System.IO;
using System.Security.Cryptography;

namespace AsyncWorkshop.UsagePatterns.Helpers
{
    public static class FileHasher
    {
        public static string CalculateMd5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}
