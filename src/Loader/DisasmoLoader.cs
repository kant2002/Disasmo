﻿using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;

// A small console app to load a specific assembly via ALC and precompile specified methods
//   "Disasmo.Loader MyDll.dll MyType MyMethod"

public class DisasmoLoader
{
    public static void Main(string[] args)
    {
        PrecompileAllMethodsInType(args);
    }

    public static void PrecompileAllMethodsInType(string[] args)
    {
        string assemblyName = args[0];
        string typeName = args[1];
        string methodName = args[2];

        var alc = new AssemblyLoadContext(null);
        Assembly asm = alc.LoadFromAssemblyPath(Path.Combine(Environment.CurrentDirectory, assemblyName));
        foreach (Type type in asm.GetTypes())
        {
            // We replace pluses with dots because 'typeName' is a C#'y name of the type
            // Unfortunately, Roslyn doesn't have a display option to output the runtime name of the type
            // And we do not want to complicate things by formatting the type's name ourselves
            // This is the easiest solution to that problem
            if (type.FullName?.Replace('+', '.').Contains(typeName) == true)
            {
                foreach (var method in type.GetMethods((BindingFlags)60))
                {
                    if (method.IsGenericMethod)
                        continue;

                    try
                    {
                        if (method.DeclaringType == type || method.DeclaringType == null)
                        {
                            if (methodName == "*" || method.Name == methodName)
                            {
                                RuntimeHelpers.PrepareMethod(method.MethodHandle);
                            }
                            else if (method.Name.Contains(">g__" + methodName))
                            {
                                // Special case for local functions
                                RuntimeHelpers.PrepareMethod(method.MethodHandle);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}