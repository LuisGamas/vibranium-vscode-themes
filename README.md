# Vibranium

[![Version](https://img.shields.io/badge/version-1.0.0-blue.svg)](https://github.com/LuisGamas/vibranium-vscode-themes)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![VS Code Marketplace](https://img.shields.io/badge/VS%20Code-Extension-green.svg)](https://marketplace.visualstudio.com/items?itemName=vibranium-themes.vibranium)

**Vibranium** is a premium VS Code theme extension that combines the elegant [Catppuccin](https://catppuccin.com/) color palette with dynamic window transparency effects. Inspired by [zed-catppuccin-blur](https://github.com/jenslys/zed-catppuccin-blur) and [GlassIt-VSC](https://github.com/s-nlf-fh/GlassIt-VSC), this extension delivers a visually stunning coding experience with customizable glass-like transparency.

## ✨ Features

- **18 Carefully Crafted Themes**: Six base variants × three blur intensity levels
- **Dynamic Transparency**: Real-time window transparency adjustment with keyboard shortcuts
- **Cross-Platform Support**: Windows (Win32 API) and Linux (X11/Wayland)
- **Fully Configurable**: Customize transparency level, step size, and behavior
- **Catppuccin Palette**: Beautiful pastel colors optimized for syntax highlighting

## 🎨 Theme Variants

Vibranium includes 18 theme combinations across 6 base variants and 3 blur levels:

| Base Variant | Light Blur | Medium Blur (Default) | Heavy Blur |
|--------------|------------|----------------------|------------|
| **Iced Latte** (Light) | Vibranium Iced Latte (Blur) [Light] | Vibranium Iced Latte (Blur) | Vibranium Iced Latte (Blur) [Heavy] |
| **Latte** (Light) | Vibranium Latte (Blur) [Light] | Vibranium Latte (Blur) | Vibranium Latte (Blur) [Heavy] |
| **Frappe** (Dark) | Vibranium Frappe (Blur) [Light] | Vibranium Frappe (Blur) | Vibranium Frappe (Blur) [Heavy] |
| **Macchiato** (Dark) | Vibranium Macchiato (Blur) [Light] | Vibranium Macchiato (Blur) | Vibranium Macchiato (Blur) [Heavy] |
| **Mocha** (Dark) | Vibranium Mocha (Blur) [Light] | Vibranium Mocha (Blur) | Vibranium Mocha (Blur) [Heavy] |
| **Espresso** (Dark) | Vibranium Espresso (Blur) [Light] | Vibranium Espresso (Blur) | Vibranium Espresso (Blur) [Heavy] |

> **Note**: Medium blur is the default variant for each theme (e.g., "Vibranium Mocha (Blur)")

## 🚀 Quick Start

### Installation

#### Option 1: VS Code Marketplace (Recommended)
1. Open VS Code
2. Navigate to Extensions (`Ctrl+Shift+X` / `Cmd+Shift+X`)
3. Search for "Vibranium"
4. Click **Install**

#### Option 2: VSIX Package
```bash
# Package the extension
npm install
vsce package

# Install the generated .vsix file
code --install-extension vibranium-1.0.0.vsix
```

#### Option 3: Build from Source
```bash
git clone https://github.com/LuisGamas/vibranium-vscode-themes.git
cd vibranium-vscode-themes
npm install
code .
# Press F5 to launch Extension Development Host
```

### Activating a Theme
1. Open Command Palette (`Ctrl+Shift+P` / `Cmd+Shift+P`)
2. Type "Color Theme" and select **Preferences: Color Theme**
3. Choose your preferred Vibranium theme
4. Enjoy the beautiful Catppuccin colors!

## ⚙️ Transparency Controls

### Keyboard Shortcuts

| Action | Windows/Linux | macOS | Command Palette |
|--------|---------------|------|-----------------|
| **Increase Transparency** (more transparent) | `Ctrl+Alt+Z` | `Cmd+Alt+Z` | Vibranium: Increase Transparency |
| **Decrease Transparency** (less transparent) | `Ctrl+Alt+C` | `Cmd+Alt+C` | Vibranium: Decrease Transparency |
| **Maximize Transparency** (most transparent) | - | - | Vibranium: Maximize Transparency |
| **Minimize Transparency** (fully opaque) | `Ctrl+Alt+X` | `Cmd+Alt+X` | Vibranium: Minimize Transparency |

### Configuration Options

Access settings via **File > Preferences > Settings** (or `Ctrl+,` / `Cmd+,`):

| Setting | Type | Default | Description |
|---------|------|---------|-------------|
| `vibranium.alpha` | integer | `220` | Transparency level (1-255). Lower = more transparent |
| `vibranium.step` | integer | `5` | Increment/decrement step when using shortcuts |
| `vibranium.force_sway` | boolean | `false` | Force swaymsg on Linux (for Wayland/Sway) |

**Example Configuration:**
```json
{
  "vibranium.alpha": 200,
  "vibranium.step": 10,
  "vibranium.force_sway": false
}
```

## 📋 Requirements

### Windows
- Windows 7 or later
- No additional dependencies required
- PowerShell execution policy may need to be adjusted (see Troubleshooting)

### Linux
**For X11:**
```bash
# Ubuntu/Debian
sudo apt install x11-utils

# Fedora
sudo dnf install xorg-x11-utils

# Arch Linux
sudo pacman -S xorg-xprop
```

**For Wayland/Sway:**
- Ensure `swaymsg` is available
- Set `vibranium.force_sway: true` in settings

### macOS
- Currently not supported (transparency features)
- Themes are still available and work perfectly without transparency

## 🔧 Troubleshooting

### Transparency Not Working

**Windows:**
1. Check PowerShell execution policy:
   ```powershell
   Get-ExecutionPolicy
   ```
   If restricted, run PowerShell as Administrator and execute:
   ```powershell
   Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
   ```

2. Verify the extension is activated:
   - Open Command Palette
   - Run "Developer: Show Running Extensions"
   - Check if "Vibranium" is listed and active

**Linux:**
1. Verify `xprop` is installed:
   ```bash
   which xprop
   ```
   Install if missing (see Requirements section)

2. For Sway/Wayland users:
   - Set `vibranium.force_sway: true` in settings
   - Verify swaymsg is available: `which swaymsg`

3. Check VS Code is running under X11:
   ```bash
   echo $XDG_SESSION_TYPE
   ```

### Theme Not Appearing
1. Reload VS Code window (`Ctrl+Shift+P` → "Developer: Reload Window")
2. Check if extension is installed and enabled
3. Verify you're using VS Code 1.40.0 or later

### Keyboard Shortcuts Conflict
If shortcuts don't work:
1. Check for conflicts: **File > Preferences > Keyboard Shortcuts**
2. Search for "vibranium" to see all assigned shortcuts
3. Customize shortcuts by clicking the pencil icon

### Performance Issues
- Reduce transparency effects by increasing `vibranium.alpha` value
- Switch to a theme with "Light" blur level
- Disable transparency by setting `vibranium.alpha` to 255

### Still Having Issues?
1. Check the [Issues](https://github.com/LuisGamas/vibranium-vscode-themes/issues) page
2. Create a new issue with:
   - Your operating system and version
   - VS Code version (`Help > About`)
   - Steps to reproduce the problem
   - Screenshots if applicable

## 🤝 Contributing

Contributions are welcome and appreciated! Here's how you can help:

### Reporting Bugs
- Use the [GitHub Issues](https://github.com/LuisGamas/vibranium-vscode-themes/issues/new?template=bug_report.md) page
- Fill out the bug report template completely
- Include screenshots and system information

### Suggesting Features
- Open an issue with the [Feature Request](https://github.com/LuisGamas/vibranium-vscode-themes/issues/new?template=feature_request.md) template
- Describe the feature and its use case

### Pull Requests
1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request using the provided template

Please read our [Contributing Guidelines](https://github.com/LuisGamas/vibranium-vscode-themes/blob/main/CONTRIBUTING.md) before submitting.

## 📝 Development

```bash
# Clone the repository
git clone https://github.com/LuisGamas/vibranium-vscode-themes.git
cd vibranium-vscode-themes

# Install dependencies
npm install

# Make changes to extension.js, themes, etc.

# Test the extension
# Open in VS Code and press F5

# Package for distribution
npm install -g @vscode/vsce
vsce package
```

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Credits & Acknowledgments

- **Catppuccin Team** - For the beautiful [Catppuccin](https://catppuccin.com/) color palette
- **Jens Lystad** - For the original [zed-catppuccin-blur](https://github.com/jenslys/zed-catppuccin-blur) theme
- **s-nlf-fh** - For the transparency implementation in [GlassIt-VSC](https://github.com/s-nlf-fh/GlassIt-VSC)
- **VS Code Team** - For the excellent extension API

## 📧 Contact

**Author:** Luis Gamas  
**Project Link:** [https://github.com/LuisGamas/vibranium-vscode-themes](https://github.com/LuisGamas/vibranium-vscode-themes)

---

<p align="center">
  Made with ❤️ by <a href="https://github.com/LuisGamas">Luis Gamas</a>
</p>
