
# Google Ads MCP (.NET) — by TrueClicks


 This is an *unofficial* Google Ads MCP integration — and as of now, **no official version exists**. It supports both Windows and macOS and it connects GPTs to the Google Ads API using [GAQL.app](https://gaql.app) as a backend.



---

## What Is This?

Google Ads MCP by TrueClicks enables your GPT (like Claude) to securely access and query your Google Ads account data via [GAQL.app](https://gaql.app), a friendly interface for the Google Ads Query Language (GAQL).

---

## Setup Guide

### 1. Download the Executable

Download the latest version of the **GoogleAdsMCP executable** from the **Releases** section of this repository:

- For **Windows**: Choose between `x86` or `x64`
- For **macOS**: Use the `arm64` version

Place the binary in a convenient location on your system (e.g., `C:/App/GoogleAdsMCP/`).

### 2. Get Your GPT Token

1. Go to [https://gaql.app](https://gaql.app)
2. Log in using your Google account to authorize Google Ads access.
3. Click the **Copy GPT Token** button in the top-right corner.

### 3. Configure Your GPT (Claude)

1. Open **Claude**
2. Press `CTRL + ,` to open settings.
3. In the left sidebar, click **Developer**
4. Click **Edit config**
5. Paste the following JSON into your configuration file:

   > **Important:** Replace:
   > - `YOUR_GPT_TOKEN_HERE` with the token copied from GAQL.app  
   > - The executable path (`C:/App/GoogleAdsMCP/GoogleAdsMCP.exe`) with the actual location of the MCP executable on your machine

   ```json
   {
     "mcpServers": {
       "gads": {
         "command": "cmd",
         "args": [
           "/c",
           "C:/App/GoogleAdsMCP/GoogleAdsMCP.exe",
           "--token=YOUR_GPT_TOKEN_HERE"
         ]
       }
     }
   }
   ```

6. Exit Claude completely: **Hamburger menu > File > Exit**
7. Restart Claude

You’re now ready to use GPT to query your Google Ads accounts.

---

## Example Prompts

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

For issues or questions, please contact the TrueClicks team.
