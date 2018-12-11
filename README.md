# ASCIIMap
Framework for basic graphics within a Windows console

Unfinished due to Uni work demand.

A basic graphics framework for console applications, primarially using ASCII characters. The framework consists of a Canvas object that stores Layer objects. Layers consist of element objects that can be rendered. Rendering of objects on the canvas uses a different implementation of "Inter-frame" compression, that only renders the changes between frames, instead of the whole frame itself. This is implemented primarially due to the restrictions of Windows CLI write speeds and instructions. The framework allows for simple manipulation of positions, visability, individual characters and colours.
