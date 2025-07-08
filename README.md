# 📌 Portfolio

Modern portfolio website built with **Blazor WebAssembly** and **Bootstrap 5**.

## 📦 成果物・外部公開リンク

- 🌐 **ポートフォリオサイト（このページ）**: [https://baku2san.github.io/Portfolio](https://baku2san.github.io/Portfolio)

- 🔗 **ブックマークレット集**: [https://baku2san.github.io/bookmarklet-gallery/](https://baku2san.github.io/bookmarklet-gallery/)
    - ブラウザでそのまま使える便利なブックマークレットを多数掲載したギャラリーです。日常のWeb操作を効率化する小さなツールをまとめています。

    ![ブックマークレット集 トップページ](./src/Portfolio/wwwroot/images/bookmarklet-gallery-top.png)

（今後追加予定のリンクもこちらにまとめてください）

## 🚀 Features

- **Responsive Design**: Mobile-first approach with Bootstrap 5
- **Modern UI**: Clean and professional design
- **Fast Loading**: Blazor WebAssembly for optimal performance
- **SEO Friendly**: Proper meta tags and structured content
- **Easy Customization**: Component-based architecture
- **GitHub Pages**: Automated deployment with GitHub Actions

## 🛠️ Tech Stack

- **Framework**: Blazor WebAssembly (.NET 9.0)
- **UI Framework**: Bootstrap 5
- **Icons**: Bootstrap Icons 1.13.1
- **Language**: C# & Razor
- **Hosting**: GitHub Pages
- **CI/CD**: GitHub Actions

## 📂 Project Structure

```text
src/Portfolio/
├── Components/      # Reusable UI components
│   └── UI/
├── Features/        # Feature-based pages
│   ├── Home/
│   ├── Profile/
│   ├── Skills/
│   ├── Projects/
│   └── Contact/
├── Models/          # Data models
├── Services/        # Business logic
├── Shared/          # Shared components
│   └── Layout/
├── wwwroot/         # Static files
│   ├── css/
│   ├── images/
│   └── index.html
└── Portfolio.csproj
```

## 🚀 Getting Started

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio Code](https://code.visualstudio.com/) with C# extension

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/your-username/Portfolio.git
   cd Portfolio
   ```

2. **Navigate to project directory**

   ```bash
   cd src/Portfolio
   ```

3. **Restore dependencies**

   ```bash
   dotnet restore
   ```

4. **Run the application**

   ```bash
   dotnet watch run
   ```

5. **Open your browser**
   Navigate to `https://localhost:5001` or `http://localhost:5000`

## 🚀 Deployment to GitHub Pages

This project is configured for automatic deployment to GitHub Pages using GitHub Actions.

### Setup Instructions

1. **Enable GitHub Pages**
   - Go to your repository Settings > Pages
   - Set Source to "GitHub Actions"

2. **Configure Repository Settings**
   - Update the `base href` in `wwwroot/index.html` if using a custom domain
   - For `username.github.io/repository-name`, use `<base href="/repository-name/" />`

3. **Deploy**
   - Push to the `main` branch
   - GitHub Actions will automatically build and deploy your site
   - Visit `https://username.github.io/repository-name`

### Manual Deployment

```bash
# Build for production
dotnet publish -c Release

# The output will be in bin/Release/net9.0/publish/wwwroot/
# Upload the contents to your web server
```

## 🔧 Development

### VS Code Setup

This project includes optimized VS Code settings:

- **Extensions**: Recommended extensions are listed in `.vscode/extensions.json`
- **Debugging**: Pre-configured debug settings for Blazor WebAssembly
- **Code Formatting**: EditorConfig and C# formatting rules
- **Snippets**: Custom Blazor snippets for faster development

### Recommended Extensions

- C# Dev Kit
- Blazor WebAssembly Debugging
- GitHub Copilot
- EditorConfig for VS Code

### Code Style

- Follow .NET naming conventions
- Use EditorConfig settings (`.editorconfig`)
- Format code on save (configured in VS Code settings)
- Use nullable reference types

## 📱 Customization

### Updating Content

1. **Personal Information**: Edit `Pages/Profile.razor`
2. **Skills**: Modify `Pages/Skills.razor`
3. **Projects**: Update `Pages/Projects.razor`
4. **Contact**: Change `Pages/Contact.razor`

### Styling

- **Global Styles**: `wwwroot/css/app.css`
- **Component Styles**: `ComponentName.razor.css`
- **Bootstrap Theme**: Customize Bootstrap variables

### Adding New Pages

1. Create a new `.razor` file in the `Pages/` folder
2. Add `@page "/route"` directive
3. Update `Layout/NavMenu.razor` if needed

## 🚀 Deployment

### Build for Production

```bash
dotnet publish -c Release -o publish
```

The output will be in the `publish/wwwroot` folder.

### GitHub Pages Deployment

This project is configured for GitHub Pages deployment. The build process will generate static files that can be served directly.

## 🔧 Tools & Configuration

### Copilot Integration

- Custom Copilot instructions in `.copilot-instructions.md`
- Optimized for Blazor development patterns
- Context-aware code suggestions

### EditorConfig

- Consistent code formatting across editors
- C# and Razor-specific rules
- Automated code style enforcement

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🤝 Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📞 Support

If you have any questions or need help, please open an issue in the GitHub repository.

---

Built with ❤️ using Blazor WebAssembly
