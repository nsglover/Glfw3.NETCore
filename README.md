# Glfw3.NETCore
Glfw3.NETCore is an up-to-date set of cross-platform C# bindings for GLFW 3 targeting .NET Core.

To maintain full compatibility with macOS, Vulkan-related GLFW functions have been temporarily omitted from the bindings. They will be restored alongside some new GLFW features in the first official release (3.3.0) of Glfw3.NETCore, which is still waiting on the completion of [GLFW 3.3](https://github.com/glfw/glfw/milestone/12).

# Installation

A NuGet package is on its way. For now, please install Glfw3.NETCore manually.

To install manually, first install [GLFW](http://www.glfw.org/) and then clone this repository, build the assembly, and reference the resulting .dll from your project.

In the likely case that it doesn't find the GLFW binares, make sure that they are in a common location (where your package manager typically installs things) or in the same directory as your project's executable.
