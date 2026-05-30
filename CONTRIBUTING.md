# Contributing to Vibranium

Thank you for your interest in contributing to Vibranium! This document provides guidelines and instructions for contributing to the project.

## 📋 Table of Contents

- [Code of Conduct](#code-of-conduct)
- [How Can I Contribute?](#how-can-i-contribute)
- [Development Setup](#development-setup)
- [Making Changes](#making-changes)
- [Pull Request Guidelines](#pull-request-guidelines)
- [Coding Standards](#coding-standards)
- [Theme Guidelines](#theme-guidelines)

## 📜 Code of Conduct

By participating in this project, you agree to abide by our [Code of Conduct](CODE_OF_CONDUCT.md). Please read it to understand what behavior is expected.

## 🤝 How Can I Contribute?

### 🐛 Reporting Bugs

Before creating bug reports, please check [existing issues](https://github.com/luisgamas/vibranium-vscode-themes/issues) to avoid duplicates.

When creating a bug report, use the [Bug Report Template](.github/ISSUE_TEMPLATE/bug_report.md) and include:
- Clear description of the issue
- Steps to reproduce
- Expected vs actual behavior
- Screenshots if applicable
- Your environment (OS, VS Code version, Vibranium version)

### ✨ Suggesting Features

Use the [Feature Request Template](.github/ISSUE_TEMPLATE/feature_request.md) to suggest enhancements.

### 🔧 Pull Requests

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Make your changes
4. Test thoroughly
5. Submit a pull request using the [PR Template](.github/PULL_REQUEST_TEMPLATE/pull_request_template.md)

## 🛠️ Development Setup

### Prerequisites

- [Node.js](https://nodejs.org/) (v14 or later)
- [VS Code](https://code.visualstudio.com/) (v1.40.0 or later)
- [Git](https://git-scm.com/)

### Getting Started

1. **Fork and clone the repository:**
   ```bash
   git clone https://github.com/YOUR_USERNAME/vibranium-vscode-themes.git
   cd vibranium-vscode-themes
   ```

2. **Install dependencies:**
   ```bash
   npm install
   ```

3. **Open in VS Code:**
   ```bash
   code .
   ```

4. **Launch Extension Development Host:**
   - Press `F5` or go to **Run > Start Debugging**
   - A new VS Code window will open with the extension loaded
   - Test your changes in this window

## 🔨 Making Changes

### Project Structure

```
Vibranium/
├── themes/              # VS Code theme JSON files
├── extension.js         # Main extension code (transparency logic)
├── SetTransparency.cs   # Windows native transparency code
├── package.json         # Extension manifest
├── README.md            # Documentation
└── ...
```

### Editing Themes

Theme files are located in the `themes/` directory. Each file follows VS Code's [Color Theme Format](https://code.visualstudio.com/api/extension-guides/color-theme).

**To modify a theme:**
1. Open the corresponding JSON file in `themes/`
2. Modify colors in the `"colors"` section
3. Modify syntax highlighting in the `"tokenColors"` section
4. Test by launching Extension Development Host (`F5`)

**To add a new theme variant:**
1. Create a new JSON file in `themes/`
2. Add the theme entry to `package.json` under `contributes.themes`
3. Update documentation in `README.md`

### Editing Transparency Logic

The transparency functionality is implemented in:
- `extension.js` - Main extension code (platform detection, commands)
- `SetTransparency.cs` - Windows-specific transparency (Win32 API)

**Important files:**
- `extension.js` lines 1-50: Platform detection and initialization
- `extension.js` lines 51-100: Transparency functions
- `extension.js` lines 101-145: Command registration

## 📋 Pull Request Guidelines

### Before Submitting

- [ ] Ensure your code follows the project's coding standards
- [ ] Test your changes on all applicable platforms (Windows/Linux)
- [ ] Update documentation if needed
- [ ] Add/update tests if applicable
- [ ] Verify all 18 theme variants still work
- [ ] Check that transparency controls function correctly

### PR Description

Use the [Pull Request Template](.github/PULL_REQUEST_TEMPLATE/pull_request_template.md) and include:
- Clear description of changes
- Reference to related issues ("Fixes #123")
- Screenshots for UI/theme changes
- Test results

### Review Process

1. Maintainers will review your PR
2. Automated checks must pass
3. Address any requested changes
4. Once approved, your PR will be merged

## 📏 Coding Standards

### JavaScript (extension.js)

- Use ES6+ syntax
- Use meaningful variable and function names
- Add comments for complex logic
- Handle errors gracefully
- Follow existing code style

**Example:**
```javascript
// Good
function setAlpha(alpha) {
    // Clamp alpha value between 1 and 255
    if (alpha < 1) {
        alpha = 1;
    } else if (alpha > 255) {
        alpha = 255;
    }
    // Apply transparency...
}
```

### C# (SetTransparency.cs)

- Follow C# naming conventions
- Use XML documentation comments
- Handle platform-specific edge cases

### JSON (Theme files)

- Use proper indentation (2 spaces)
- Group related properties
- Use comments sparingly (JSON doesn't officially support comments)

## 🎨 Theme Guidelines

When modifying or adding themes:

### Color Palette

Vibranium uses the [Catppuccin](https://catppuccin.com/) color palette. Stick to these colors:

**All Variants:**
- Rosewater, Flamingo, Pink, Mauve, Red, Maroon, Peach, Yellow, Green, Teal, Sky, Sapphire, Blue, Lavender

**Light Variants (Latte, Iced Latte):**
- Base: `#eff1f5` / `#e8f4ff`
- Text: `#4c4f69`
- Surface: `#ccd0da` / `#ddeeff`

**Dark Variants (Frappe, Macchiato, Mocha, Espresso):**
- Base: `#303446`, `#24273a`, `#1e1e2e`, `#000000`
- Text: `#c6d0f5`, `#cad3f5`, `#cdd6f4`, `#cad3f5`
- Surface: `#414559`, `#363a4f`, `#313244`, `#363a4f`

### Transparency Levels

Maintain consistency with blur levels:
- **Light Blur**: More transparent (alpha: ~60%)
- **Medium Blur**: Balanced (alpha: ~85%)
- **Heavy Blur**: Less transparent (alpha: ~88%)

### Testing Themes

For each theme variant, verify:
- [ ] Syntax highlighting is readable
- [ ] UI elements are visible
- [ ] Terminal colors work correctly
- [ ] Transparency applies correctly
- [ ] No contrast issues

## 💬 Questions?

Feel free to:
- Open a [Discussion](https://github.com/luisgamas/vibranium-vscode-themes/discussions)
- Ask in issues (use the question label)
- Contact the maintainer: [Luis Gamas](https://github.com/luisgamas)

---

Thank you for contributing to Vibranium! 🎉
