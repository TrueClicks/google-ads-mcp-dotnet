# Google Ads MCP (.NET) — by TrueClicks

> **Note:** This is an *unofficial* integration. It connects GPTs to the Google Ads API using [GAQL.app](https://gaql.app) as a backend.

---

## What Is This?

Google Ads MCP by TrueClicks enables GPTs (like Claude) to securely access and query your Google Ads account data via [GAQL.app](https://gaql.app), a friendly interface for the Google Ads Query Language (GAQL).

---

## Setup Guide

### 1. Get Your GPT Token

1. Go to [https://gaql.app](https://gaql.app)
2. Log in using your Google account to authorize Google Ads access.
3. Click the **Copy GPT Token** button in the top-right corner.

### 2. Configure Your GPT (Claude)

1. Open **Claude**
2. Press `CTRL + ,` to open settings.
3. In the left sidebar, click **Developer**
4. Click **Edit config**
5. Paste the following JSON (replace the path to **GoogleAdsMCP.exe** and the **token value**):

   ```json
   {
     "mcpServers": {
       "gads": {
         "command": "cmd",
         "args": [
           "/c",
           "C:/REPLACE_PATH_TO_/GoogleAdsMCP.exe",
           "--token=REPLACE_YOUR_GPT_TOKEN_HERE"
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
