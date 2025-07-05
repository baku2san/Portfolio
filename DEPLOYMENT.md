# GitHub Pages デプロイメント設定ガイド

## はじめに

このドキュメントでは、Portfolio を GitHub Pages にデプロイする際の設定について説明します。

## 設定手順

### 1. リポジトリの準備

1. GitHub でリポジトリを作成または既存リポジトリを使用
2. プロジェクトをプッシュ

### 2. GitHub Pages の有効化

1. リポジトリの **Settings** > **Pages** に移動
2. **Source** を **GitHub Actions** に設定

### 3. Base Href の設定

GitHub Pages でサブディレクトリでホストする場合（例：`https://username.github.io/repository-name`）、
`wwwroot/index.html` の base href を調整する必要があります。

#### サブディレクトリでのホスティングの場合

```html
<!-- リポジトリ名が 'my-portfolio' の場合 -->
<base href="/my-portfolio/" />
```

#### カスタムドメインまたはルートでのホスティングの場合

```html
<!-- そのまま使用 -->
<base href="/" />
```

### 4. ワークフローファイルの配置

`.github/workflows/deploy.yml` ファイルがプロジェクトルートまたはリポジトリルートに配置されていることを確認してください。

### 5. デプロイの実行

`main` ブランチにプッシュすると、自動的にデプロイが開始されます。

## トラブルシューティング

### よくある問題と解決方法

1. **404 エラーが発生する**
   - base href の設定を確認
   - GitHub Pages の設定を確認

2. **リソースが読み込まれない**
   - 相対パスの設定を確認
   - .nojekyll ファイルが存在することを確認

3. **SPA ルーティングが動作しない**
   - 404.html ファイルが index.html のコピーとして存在することを確認

## 参考リンク

- [GitHub Pages Documentation](https://docs.github.com/pages)
- [Blazor WebAssembly Hosting](https://docs.microsoft.com/aspnet/core/blazor/host-and-deploy/webassembly)
