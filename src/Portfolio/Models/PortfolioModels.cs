namespace Portfolio.Models;

/// <summary>
/// ポートフォリオの基本情報を表すモデル
/// </summary>
public record PortfolioInfo
{
    /// <summary>
    /// 開発者の名前
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    /// 開発者の職種・肩書き
    /// </summary>
    public string Title { get; init; } = string.Empty;

    /// <summary>
    /// 開発者の説明・自己紹介
    /// </summary>
    public string Description { get; init; } = string.Empty;

    /// <summary>
    /// プロフィール画像のURL
    /// </summary>
    public string ProfileImageUrl { get; init; } = string.Empty;
}

/// <summary>
/// 機能カードの情報を表すモデル
/// </summary>
public record FeatureCard
{
    /// <summary>
    /// Bootstrap Icons クラス名
    /// </summary>
    public string Icon { get; init; } = string.Empty;

    /// <summary>
    /// 機能カードのタイトル
    /// </summary>
    public string Title { get; init; } = string.Empty;

    /// <summary>
    /// 機能カードの説明
    /// </summary>
    public string Description { get; init; } = string.Empty;
}

/// <summary>
/// スキル情報を表すモデル
/// </summary>
public record Skill
{
    /// <summary>
    /// スキル名
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    /// スキルのカテゴリー
    /// </summary>
    public string Category { get; init; } = string.Empty;

    /// <summary>
    /// スキルレベル (1-5)
    /// </summary>
    public int Level { get; init; } // 1-5 レベル

    /// <summary>
    /// スキルの説明
    /// </summary>
    public string Description { get; init; } = string.Empty;
}

/// <summary>
/// プロジェクト情報を表すモデル
/// </summary>
public record Project
{
    /// <summary>
    /// プロジェクトの一意識別子
    /// </summary>
    public string Id { get; init; } = string.Empty;

    /// <summary>
    /// プロジェクト名
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    /// プロジェクトの詳細説明
    /// </summary>
    public string Description { get; init; } = string.Empty;

    /// <summary>
    /// プロジェクトの短い説明
    /// </summary>
    public string ShortDescription { get; init; } = string.Empty;

    /// <summary>
    /// 使用技術のリスト
    /// </summary>
    public List<string> Technologies { get; init; } = new();

    /// <summary>
    /// プロジェクトの画像URL
    /// </summary>
    public string ImageUrl { get; init; } = string.Empty;

    /// <summary>
    /// GitHubリポジトリのURL
    /// </summary>
    public string? GitHubUrl { get; init; }

    /// <summary>
    /// デモサイトのURL
    /// </summary>
    public string? DemoUrl { get; init; }

    /// <summary>
    /// プロジェクトの作成日時
    /// </summary>
    public DateTime CreatedDate { get; init; }

    /// <summary>
    /// 注目プロジェクトかどうか
    /// </summary>
    public bool IsFeatured { get; init; }
}

/// <summary>
/// 連絡先情報を表すモデル
/// </summary>
public record ContactInfo
{
    /// <summary>
    /// メールアドレス
    /// </summary>
    public string Email { get; init; } = string.Empty;

    /// <summary>
    /// LinkedInプロフィールのURL
    /// </summary>
    public string? LinkedIn { get; init; }

    /// <summary>
    /// GitHubプロフィールのURL
    /// </summary>
    public string? GitHub { get; init; }

    /// <summary>
    /// TwitterプロフィールのURL
    /// </summary>
    public string? Twitter { get; init; }

    /// <summary>
    /// 個人ウェブサイトのURL
    /// </summary>
    public string? Website { get; init; }

    /// <summary>
    /// QiitaプロフィールのURL
    /// </summary>
    public string? Qiita { get; init; }
}

/// <summary>
/// 連絡フォームのモデル
/// </summary>
public class ContactForm
{
    /// <summary>
    /// 送信者の名前
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 送信者のメールアドレス
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// メッセージの件名
    /// </summary>
    public string Subject { get; set; } = string.Empty;

    /// <summary>
    /// メッセージの本文
    /// </summary>
    public string Message { get; set; } = string.Empty;
}
