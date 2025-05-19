# Aloe.Utils.Win32.Drawing

`Aloe.Utils.Win32.Drawing` is a library that provides direct access to Windows drawing-related Win32 APIs from .NET applications.
It can be used when you need to perform graphics processing and drawing operations programmatically.

## Key Features

* Direct access to Windows drawing APIs
* Graphics processing support

## Supported Environments

* .NET 9 and later
* Windows OS

## Usage Example

```csharp
using System.Drawing;
using Aloe.Utils.Win32.Drawing;

// Load image file (loads into memory, so no file lock)
var image = ImageLoader.Load("path/to/image.png");

// Convert image to icon
var icon = image.ToIcon();

// Example of using the icon
using var drawing = new Win32Drawing();

// Create window
var hwnd = drawing.CreateWindow(
    className: "MyWindowClass",
    windowName: "Icon Display Test",
    width: 400,
    height: 300);

// Get drawing context
using var dc = drawing.GetDC(hwnd);

// Draw icon
drawing.DrawIcon(dc, 100, 100, icon.Handle);

// Update drawing
drawing.UpdateWindow(hwnd);

// Release resources
icon.Dispose();
image.Dispose();
```

## License

MIT License
