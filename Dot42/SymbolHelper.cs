﻿using Mono.Cecil.Pdb;

namespace TallComponents.Dot42
{
    public static class SymbolHelper
    {
        public static string GetPdbFileName(string assemblyFileName)
        {
            return PdbHelper.GetPdbFileName(assemblyFileName);
        }
    }
}
