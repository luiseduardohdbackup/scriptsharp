﻿// AssemblyInfo.cs
//

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyTitle("App")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Script# Samples")]
[assembly: AssemblyCopyright("Copyright © 2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: ScriptAssembly("app")]

// A script template allows customization of the generated script.
[assembly: ScriptTemplate(@"
/*! {name}.js {version}
 * {description}
 * {copyright}
 */

""use strict"";

define('{name}', [{requires}], function({dependencies}) {
  var $global = this;

  {script}
});

// Generated with Script# {compiler}
")]
