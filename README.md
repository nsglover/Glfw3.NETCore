# Glfw3.NETCore
Glfw3.NETCore is a set of cross-platform C# bindings for GLFW 3 targeting .NET Core.

To maintain full compatibility with macOS, Vulkan-related GLFW functions have been temporarily omitted from the bindings.

# Installation

NuGet Package: https://www.nuget.org/packages/Glfw3.NETCore/

To install manually, first install [GLFW](http://www.glfw.org/) and then clone this repository, build the assembly, and reference the resulting .dll from your project.

In the likely case that it doesn't find the GLFW binares, make sure that they are in a common location (where your package manager typically installs things) or in the same directory as your project's executable.
