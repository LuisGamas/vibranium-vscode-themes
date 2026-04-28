# Changelog

All notable changes to the **Vibranium** extension will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added
- Enhanced documentation and GitHub templates
- Professional README with badges and troubleshooting guide
- Code of Conduct and Contributing guidelines
- Issue and Pull Request templates

---

## [1.0.0] - 2024-04-27

### Added
- Initial release of Vibranium theme extension
- **18 Catppuccin theme variants**:
  - 6 base variants: Iced Latte, Latte, Frappe, Macchiato, Mocha, Espresso
  - 3 blur levels per variant: Light, Medium (default), Heavy
- **Dynamic transparency controls**:
  - Keyboard shortcuts for real-time transparency adjustment
  - `Ctrl+Alt+Z` / `Cmd+Alt+Z` - Increase transparency
  - `Ctrl+Alt+C` / `Cmd+Alt+C` - Decrease transparency
  - `Ctrl+Alt+X` / `Cmd+Alt+X` - Minimize transparency (fully opaque)
- **Cross-platform support**:
  - Windows: Win32 API via C# (SetTransparency.cs)
  - Linux: xprop for X11, swaymsg for Wayland/Sway
- **Configurable settings**:
  - `vibranium.alpha` (default: 220) - Transparency level (1-255)
  - `vibranium.step` (default: 5) - Increment/decrement step
  - `vibranium.force_sway` (default: false) - Force swaymsg on Linux
- Complete VS Code theme integration:
  - Syntax highlighting (tokenColors)
  - UI theming (activity bar, side bar, status bar, etc.)
  - Terminal colors (ANSI)
  - Editor colors (background, foreground, selection, etc.)

### Technical Details
- Extension size: ~XX KB (excluding node_modules)
- Dependencies: node-powershell (^4.0.0)
- Target VS Code version: ^1.40.0
- License: MIT

### Credits
- Original Zed theme: [zed-catppuccin-blur](https://github.com/jenslys/zed-catppuccin-blur) by Jens Lystad
- Transparency implementation: [GlassIt-VSC](https://github.com/s-nlf-fh/GlassIt-VSC) by s-nlf-fh
- Color palette: [Catppuccin](https://catppuccin.com/)

---

## [0.0.1] - 2024-04-27 (Pre-release)

### Added
- Project scaffolding
- Basic theme structure
- Transparency proof-of-concept

---

## Template for Future Releases

### Added
- New features

### Changed
- Changes in existing functionality

### Deprecated
- Soon-to-be removed features

### Removed
- Now removed features

### Fixed
- Any bug fixes

### Security
- Security fixes
