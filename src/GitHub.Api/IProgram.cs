﻿using System.Reflection;
using Octokit;

namespace GitHub.Api
{
    // Represents the currently executing program.
    public interface IProgram
    {
        string ApplicationName { get; }
        string ApplicationDescription { get; }
        AssemblyName AssemblyName { get; }
        ProductHeaderValue ProductHeader { get; }
    }
}