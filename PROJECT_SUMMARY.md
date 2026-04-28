# Vibranium Project Summary

## Overview
Vibranium is a VS Code extension that combines:
- **Catppuccin themes** from `zed-catppuccin-blur` (6 variants × 3 blur levels = 18 themes)
- **Transparency/blur functionality** from `GlassIt-VSC` (window transparency with keyboard shortcuts)

## Project Structure
```
Vibranium/
├── .vscode/
│   └── launch.json
├── themes/
│   ├── vibranium-iced-latte.json (and -light, -heavy)
│   ├── vibranium-latte.json (and -light, -heavy)
│   ├── vibranium-frappe.json (and -light, -heavy)
│   ├── vibranium-macchiato.json (and -light, -heavy)
│   ├── vibranium-mocha.json (and -light, -heavy)
│   └── vibranium-espresso.json (and -light, -heavy)
├── node_modules/ (dependencies)
├── .gitignore
├── .vscodeignore
├── CHANGELOG.md
├── extension.js (transparency logic)
├── jsconfig.json
├── LICENSE
├── package.json (manifest with 18 themes)
├── README.md
└── SetTransparency.cs (Windows native code)
```

## Key Features

### 1. Theme Variants (18 total)
- **6 base variants**: Iced Latte, Latte, Frappe, Macchiato, Mocha, Espresso
- **3 blur levels each**: Light, Medium (default), Heavy

### 2. Transparency Controls
- **Keyboard shortcuts**:
  - `Ctrl+Alt+Z` / `Cmd+Alt+Z` - Increase transparency (more transparent)
  - `Ctrl+Alt+C` / `Cmd+Alt+C` - Decrease transparency (less transparent)
  - `Ctrl+Alt+X` / `Cmd+Alt+X` - Minimize transparency (fully opaque)

### 3. Configuration Options
- `vibranium.alpha` (1-255, default: 220) - Transparency level
- `vibranium.step` (default: 5) - Increment/decrement step
- `vibranium.force_sway` (default: false) - For Wayland/Sway on Linux

### 4. Platform Support
- **Windows**: Uses Win32 API via C# (SetTransparency.cs)
- **Linux**: Uses xprop for X11 or swaymsg for Sway/Wayland
- **macOS**: Not supported yet (would need separate implementation)

## How It Works

1. **Themes**: VS Code theme files define the Catppuccin colors for syntax highlighting, UI elements, terminal colors, etc.

2. **Transparency**: The extension.js file:
   - On activation, reads the `vibranium.alpha` setting
   - Calls platform-specific code to set window transparency
   - Windows: Compiles and runs C# code that uses SetLayeredWindowAttributes
   - Linux: Executes xprop or swaymsg commands

3. **Keyboard shortcuts**: Registered commands that adjust alpha value and apply transparency

## Installation & Testing

### To test the extension:
1. Open the Vibranium folder in VS Code
2. Press F5 to launch Extension Development Host
3. In the new window, go to File > Preferences > Color Theme
4. Select any Vibranium theme
5. Use keyboard shortcuts to adjust transparency

### To package for distribution:
```bash
npm install -g @vscode/vsce
vsce package
```

This creates a `.vsix` file that can be installed in VS Code.

## Credits
- Original Zed theme: [zed-catppuccin-blur](https://github.com/jenslys/zed-catppuccin-blur) by Jens Lystad
- Transparency code: [GlassIt-VSC](https://github.com/s-nlf-fh/GlassIt-VSC) by s-nlf-fh
- Catppuccin palette: [Catppuccin](https://catppuccin.com/)
