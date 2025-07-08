using Portfolio.Models;

namespace Portfolio.Services;

/// <summary>
/// ポートフォリオデータを管理するサービス
/// </summary>
public interface IPortfolioDataService
{
    /// <summary>
    /// ポートフォリオの基本情報を取得します
    /// </summary>
    /// <returns>ポートフォリオの基本情報</returns>
    PortfolioInfo GetPortfolioInfo();

    /// <summary>
    /// 機能カードの一覧を取得します
    /// </summary>
    /// <returns>機能カードのリスト</returns>
    List<FeatureCard> GetFeatureCards();

    /// <summary>
    /// スキルの一覧を取得します
    /// </summary>
    /// <returns>スキルのリスト</returns>
    List<Skill> GetSkills();

    /// <summary>
    /// プロジェクトの一覧を取得します
    /// </summary>
    /// <returns>プロジェクトのリスト</returns>
    List<Project> GetProjects();

    /// <summary>
    /// 指定されたIDのプロジェクトを取得します
    /// </summary>
    /// <param name="id">プロジェクトID</param>
    /// <returns>指定されたプロジェクト、見つからない場合はnull</returns>
    Project? GetProject(string id);

    /// <summary>
    /// 注目プロジェクトの一覧を取得します
    /// </summary>
    /// <returns>注目プロジェクトのリスト</returns>
    List<Project> GetFeaturedProjects();

    /// <summary>
    /// 連絡先情報を取得します
    /// </summary>
    /// <returns>連絡先情報</returns>
    ContactInfo GetContactInfo();
}

/// <summary>
/// ポートフォリオデータサービスの実装
/// </summary>
public class PortfolioDataService : IPortfolioDataService
{
    /// <summary>
    /// ポートフォリオの基本情報を取得します
    /// </summary>
    /// <returns>ポートフォリオの基本情報</returns>
    public PortfolioInfo GetPortfolioInfo()
    {
        return new PortfolioInfo
        {
            Name = "Portfolio Developer",
            Title = "C# .NET 開発者",
            Description = "C# .NET開発者として、革新的なソリューションの開発に情熱を注いでいます。このサイトでは、私のスキル、経験、プロジェクトをご紹介します。",
            ProfileImageUrl = "/images/profile.jpg"
        };
    }

    /// <summary>
    /// 機能カードの一覧を取得します
    /// </summary>
    /// <returns>機能カードのリスト</returns>
    public List<FeatureCard> GetFeatureCards()
    {
        return new List<FeatureCard>
        {
            new()
            {
                Icon = "bi bi-code-slash",
                Title = "技術スキル",
                Description = "C#、.NET、Blazor、ASP.NET Core、Entity Framework など、モダンな技術スタックを活用した開発"
            },
            new()
            {
                Icon = "bi bi-lightbulb",
                Title = "イノベーション",
                Description = "課題解決に向けた創造的なアプローチと、継続的な学習による技術力向上"
            },
            new()
            {
                Icon = "bi bi-people",
                Title = "コラボレーション",
                Description = "チームワークを重視し、オープンソースコミュニティへの積極的な貢献"
            }
        };
    }

    /// <summary>
    /// スキルの一覧を取得します
    /// </summary>
    /// <returns>スキルのリスト</returns>
    public List<Skill> GetSkills()
    {
        return new List<Skill>
        {
            new() { Name = "C#", Category = "Programming Languages", Level = 5, Description = "メイン開発言語として使用" },
            new() { Name = ".NET Core/.NET 5+", Category = "Frameworks", Level = 5, Description = "Web API、コンソールアプリケーション開発" },
            new() { Name = "Blazor", Category = "Web Technologies", Level = 4, Description = "SPAアプリケーション開発" },
            new() { Name = "ASP.NET Core", Category = "Web Technologies", Level = 5, Description = "Web API、MVCアプリケーション開発" },
            new() { Name = "Entity Framework Core", Category = "Databases", Level = 4, Description = "データアクセス層の実装" },
            new() { Name = "SQL Server", Category = "Databases", Level = 4, Description = "リレーショナルデータベース設計・運用" },
            new() { Name = "Azure", Category = "Cloud Platforms", Level = 3, Description = "クラウドインフラストラクチャ" },
            new() { Name = "Git", Category = "Tools", Level = 5, Description = "バージョン管理" }
        };
    }

    /// <summary>
    /// プロジェクトの一覧を取得します
    /// </summary>
    /// <returns>プロジェクトのリスト</returns>
    public List<Project> GetProjects()
    {
        return new List<Project>
        {
            new()
            {
                Id = "portfolio-blazor",
                Name = "Blazor Portfolio Website",
                Description = "Blazor WebAssemblyを使用して構築されたモダンなポートフォリオウェブサイト。レスポンシブデザイン、Bootstrap 5、カスタムコンポーネントを特徴としています。",
                ShortDescription = "Blazor WebAssemblyで構築されたポートフォリオサイト",
                Technologies = new() { "Blazor WebAssembly", "C#", "Bootstrap 5", "CSS3", "HTML5" },
                ImageUrl = "/images/projects/portfolio.jpg",
                GitHubUrl = "https://github.com/yourusername/portfolio",
                DemoUrl = "https://yourportfolio.github.io",
                CreatedDate = new DateTime(2024, 1, 15),
                IsFeatured = true
            },
            new()
            {
                Id = "api-management",
                Name = "API Management System",
                Description = "ASP.NET Core Web APIを使用したRESTful APIの管理システム。JWT認証、Swagger統合、Entity Framework Coreを使用。",
                ShortDescription = "ASP.NET CoreによるAPI管理システム",
                Technologies = new() { "ASP.NET Core", "Entity Framework Core", "SQL Server", "JWT", "Swagger" },
                ImageUrl = "/images/projects/api-management.jpg",
                GitHubUrl = "https://github.com/yourusername/api-management",
                CreatedDate = new DateTime(2023, 8, 10),
                IsFeatured = true
            },
            new()
            {
                Id = "bookmarklet-gallery",
                Name = "ブックマークレット集",
                Description = "ブラウザでそのまま使える便利なブックマークレットを多数掲載したギャラリーです。日常のWeb操作を効率化する小さなツールをまとめています。JavaScriptやHTML/CSSで実装し、インストール不要で利用できます。",
                ShortDescription = "Web操作を効率化するブックマークレット集",
                Technologies = new() { "JavaScript", "HTML", "CSS" },
                ImageUrl = "/images/bookmarklet-gallery-top.png",
                GitHubUrl = null,
                DemoUrl = "https://baku2san.github.io/bookmarklet-gallery/",
                CreatedDate = new DateTime(2025, 7, 1),
                IsFeatured = false
            }
        };
    }

    /// <summary>
    /// 指定されたIDのプロジェクトを取得します
    /// </summary>
    /// <param name="id">プロジェクトID</param>
    /// <returns>指定されたプロジェクト、見つからない場合はnull</returns>
    public Project? GetProject(string id)
    {
        return GetProjects().FirstOrDefault(p => p.Id == id);
    }

    /// <summary>
    /// 注目プロジェクトの一覧を取得します
    /// </summary>
    /// <returns>注目プロジェクトのリスト</returns>
    public List<Project> GetFeaturedProjects()
    {
        return GetProjects().Where(p => p.IsFeatured).ToList();
    }

    /// <summary>
    /// 連絡先情報を取得します
    /// </summary>
    /// <returns>連絡先情報</returns>
    public ContactInfo GetContactInfo()
    {
        return new ContactInfo
        {
            Email = "contact@portfolio-developer.dev",
            LinkedIn = "https://linkedin.com/in/portfolio-developer",
            GitHub = "https://github.com/portfolio-developer",
            Twitter = "https://twitter.com/portfolio_dev",
            Website = "https://portfolio-developer.dev"
        };
    }
}
