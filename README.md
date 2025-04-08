
# Google Ads MCP (.NET) — by TrueClicks

Google Ads MCP by TrueClicks enables your GPT (like Claude) to securely access and query your Google Ads account data via [GAQL.app](https://gaql.app).

This is an *unofficial* Google Ads MCP integration — and as of now, **no official version exists**. It supports both Windows and macOS and it connects GPTs to the Google Ads API using [GAQL.app](https://gaql.app) as a backend.

---

## ✅ Why Use This MCP?

Unlike other open-source Multi-Client Processors (MCPs) for Google Ads, this .NET-based MCP offers **the easiest setup experience available**:

- 🟢 **No Google Cloud Project setup required**
- 🟢 No OAuth credentials
- 🟢 No Developer Tokens
- 🟢 No Client IDs
- 🟢 No authentication hassles

Instead, it uses free **[GAQL.app](https://gaql.app)**, which securely handles authentication and query execution behind the scenes.

This makes it ideal for users who want to get up and running **within minutes**.

---

## 🛠️ Setup Guide

### 1. Download the Executable

Download the latest version of the **GoogleAdsMCP executable** from the **Releases** section of this repository:

1. Click the **"Releases"** section in Github (usually found on the right), or go directly here:  
   [https://github.com/TrueClicks/google-ads-mcp-dotnet/releases](https://github.com/TrueClicks/google-ads-mcp-dotnet/releases)

2. Download the `.zip` file from the **Assets** section of the latest release and extract.
   - For **Windows** download the `-win-` version
   - For **macOS** download the `-osx-` version

Place the binary in a convenient location on your system (e.g., `C:/GoogleAdsMCP/`).

### 2. Get Your GPT Token

1. Go to [https://gaql.app](https://gaql.app)
2. Log in using your Google account to authorize Google Ads access.
3. Click the **Copy GPT Token** button in the top-right corner.

### 3. Configure Your GPT (Claude)

The application is configured via a JSON file named ```claude_desktop_config.json```.

1. Open **Claude** desktop application
2. Press `CTRL + ,` (Control key and comma) to open settings
3. In the left sidebar, click **Developer**
4. Click **Edit config** and open ``claude_desktop_config.json`` for editing
5. Paste the following JSON into your configuration file:

   ```json
   {
     "mcpServers": {
       "gads": {
         "command": "C:/GoogleAdsMCP/GoogleAdsMCP.exe",
         "args": [
           "--token=YOUR_GPT_TOKEN_HERE"
         ]
       }
     }
   }
   ```

   > **📌 Important:** Replace:
   > 1. `YOUR_GPT_TOKEN_HERE` with the token copied from GAQL.app  
   > 2. `C:/GoogleAdsMCP/GoogleAdsMCP.exe` path with the actual location of the downloaded MCP executable on your machine. The file path in this JSON must use **forward slashes (`/`)**, even on Windows systems.

6. Exit Claude completely: **Hamburger menu > File > Exit**
7. Restart Claude

You’re now ready to use GPT to query your Google Ads accounts.

---

## 🚀 Example Prompts

- `List my Google Ads accounts`
- `What is the cost for account XYZ in the past 30 days?`
- `What are the top 5 setting recommendations for my campaigns?`

---

## About GAQL.app

[GAQL.app](https://gaql.app) is a tool built by TrueClicks to make querying Google Ads accounts with GAQL easier and more accessible. It is:

- Free to use
- Built for reporting, data exploration, and Google Ads script writing
- Now enables secure access for custom GPTs

---

## 🧩 Comparison with Other Google Ads MCPs

| Feature                               | Google Ads MCP (.NET) | Other MCPs (Python/Node/etc.) |
|---------------------------------------|------------------------|-------------------------------|
| Google Cloud project setup needed?    | 🟢 No                  | 🔧 Yes                        |
| OAuth Client ID required?             | 🟢 No                  | 🔧 Yes                        |
| Developer Token needed?               | 🟢 No                  | 🔧 Yes                        |
| Requires Google Ads API familiarity?  | 🟢 No                  | ⚠️ Yes                        |
| Setup complexity                      | 🎉 Very low            | 😵 Moderate to high           |
| Backend service                       | ☁️ Hosted via GAQL.app | 🛠️ Direct API integration     |

---


For issues or questions, please contact ales@trueclicks.com.
