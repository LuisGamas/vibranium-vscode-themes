# Security Policy

## Reporting Security Vulnerabilities

The safety and security of **Vibranium** users is important to us. If you discover a security vulnerability in this extension, we appreciate your help in disclosing it responsibly.

### 🔒 How to Report a Security Vulnerability

**Please do NOT report security vulnerabilities through public GitHub issues.**

Instead, please report them via email to: **luis.gamas@example.com** (replace with your actual email)

You should receive a response within 48 hours. If for some reason you do not, please follow up via email to ensure we received your original message.

### 📧 What to Include in Your Report

Please include the following information:

- **Type of issue** (e.g., buffer overflow, SQL injection, cross-site scripting, etc.)
- **Full paths of source file(s)** related to the manifestation of the issue
- **Location of the affected source code** (tag/branch/commit or direct URL)
- **Any special configuration** required to reproduce the issue
- **Step-by-step instructions** to reproduce the issue
- **Proof-of-concept or exploit code** (if possible)
- **Impact of the issue**, including how an attacker might exploit it

### 🛡️ Security Best Practices for Contributors

When contributing to Vibranium:

1. **Never commit secrets or credentials**
   - No API keys, passwords, or tokens in code
   - Use environment variables or VS Code settings for sensitive data

2. **Validate all inputs**
   - Sanitize user inputs (especially settings values)
   - Validate alpha values are within acceptable range (1-255)
   - Check step values are positive integers

3. **Platform-specific code**
   - Windows: Ensure C# code handles edge cases
   - Linux: Validate shell command inputs to prevent injection
   - Use safe APIs and avoid deprecated functions

4. **Dependencies**
   - Keep dependencies up to date
   - Review dependency changes before updating
   - Use `npm audit` to check for vulnerabilities

5. **Extension permissions**
   - Vibranium only requires minimal permissions
   - No file system access beyond its own directory
   - No network access required

### 🔐 Supported Versions

| Version | Supported          |
| ------- | ------------------ |
| 1.0.x   | :white_check_mark: |
| < 1.0   | :x:                |

### 📋 Security-Related Configuration

Vibranium has minimal security considerations:

- **Transparency settings**: Alpha values are clamped between 1-255
- **Step values**: Positive integers only
- **Platform detection**: Uses `process.platform` (safe)
- **PowerShell execution** (Windows): Requires appropriate execution policy

### 🚨 Known Security Considerations

1. **Windows PowerShell Execution**
   - The extension uses PowerShell to compile and execute C# code
   - Requires `RemoteSigned` or less restrictive execution policy
   - Users should review and adjust their PowerShell execution policy if needed

2. **Linux Shell Commands**
   - Extension executes `xprop` and `swaymsg` commands
   - Commands are constructed with proper argument handling
   - No user input is directly passed to shell commands

3. **Native Code (SetTransparency.cs)**
   - Uses Win32 API calls (SetLayeredWindowAttributes)
   - Only affects VS Code window transparency
   - No elevated privileges required

### 📞 Contact

For security-related questions or concerns:
- **Email**: luis.gamas@example.com (replace with your actual email)
- **GitHub**: [@LuisGamas](https://github.com/LuisGamas)

---

Thank you for helping keep Vibranium and its users safe!
