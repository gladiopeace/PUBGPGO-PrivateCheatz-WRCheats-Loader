using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;

// Token: 0x02000002 RID: 2
public static class globals
{
	// Token: 0x06000001 RID: 1 RVA: 0x0000C03C File Offset: 0x0000323C
	public static string Terminatestring(string input)
	{
		int length = input.IndexOf("\0");
		return input.Substring(0, length);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000C060 File Offset: 0x00003260
	public static string geturl(string url)
	{
		WebRequest webRequest = WebRequest.Create(url);
		webRequest.Credentials = CredentialCache.DefaultCredentials;
		WebResponse response = webRequest.GetResponse();
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		string text = streamReader.ReadToEnd();
		streamReader.Close();
		response.Close();
		if (text.Length > 350)
		{
			return "FAIL: Request failed";
		}
		if (text.Length < 2)
		{
			return "FAIL: Request failed";
		}
		if (text.Substring(0, 4) != "FAIL" && text.Substring(0, 2) != "OK")
		{
			return "FAIL: Request failed";
		}
		return text;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000C0F0 File Offset: 0x000032F0
	public static string getMD5(string filename)
	{
		if (!File.Exists(filename))
		{
			return "0";
		}
		string result;
		using (MD5 md = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(filename))
			{
				result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", string.Empty).ToLower();
			}
		}
		return result;
	}

	// Token: 0x04000001 RID: 1
	public static string url = "http://shaytan.net/auth/fake.html";

	// Token: 0x04000002 RID: 2
	public static string guid = "";

	// Token: 0x04000003 RID: 3
	public static string name = "";

	// Token: 0x04000004 RID: 4
	public static string pass = "";

	// Token: 0x04000005 RID: 5
	public static string lastresponse = "";

	// Token: 0x04000006 RID: 6
	public static string path = "";

	// Token: 0x04000007 RID: 7
	public static string filemd5 = "";

	// Token: 0x04000008 RID: 8
	public static bool fullterminate = false;

	// Token: 0x04000009 RID: 9
	public static int selected = 0;

	// Token: 0x0400000A RID: 10
	public static int gamecount = 0;

	// Token: 0x0400000B RID: 11
	public static string downloadlink = "";

	// Token: 0x0400000C RID: 12
	public static string[] gameid = new string[10];

	// Token: 0x0400000D RID: 13
	public static string[] gamename = new string[10];

	// Token: 0x0400000E RID: 14
	public static string[] gameversion = new string[10];

	// Token: 0x0400000F RID: 15
	public static string[] gamestatus = new string[10];

	// Token: 0x04000010 RID: 16
	public static string[] gameproc = new string[10];

	// Token: 0x04000011 RID: 17
	public static byte[] status = new byte[100];
}
