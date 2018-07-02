using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000003 RID: 3
public static class Imports
{
	// Token: 0x06000005 RID: 5
	[DllImport("kernel32.dll")]
	public static extern IntPtr GetConsoleWindow();

	// Token: 0x06000006 RID: 6
	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	// Token: 0x06000007 RID: 7
	[DllImport("client.dll")]
	public static extern void load(byte[] array);

	// Token: 0x06000008 RID: 8
	[DllImport("client.dll")]
	public static extern void prepare(byte[] array);

	// Token: 0x06000009 RID: 9
	[DllImport("client.dll")]
	public static extern void start(byte[] pfad, byte[] game, byte[] output);

	// Token: 0x0600000A RID: 10
	[DllImport("client.dll")]
	public static extern void boot(string username, string pass);

	// Token: 0x0600000B RID: 11 RVA: 0x00002247 File Offset: 0x00000647
	public static void nuthin()
	{
		globals.path.ToCharArray();
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002254 File Offset: 0x00000654
	public static void prepare_guid()
	{
		byte[] array = new byte[255];
		byte[] array2 = new byte[255];
		Imports.load(array);
		Imports.prepare(array2);
		globals.guid = globals.Terminatestring(Encoding.ASCII.GetString(array));
		globals.path = globals.Terminatestring(Encoding.ASCII.GetString(array2));
	}

	// Token: 0x04000012 RID: 18
	private const int SW_HIDE = 0;

	// Token: 0x04000013 RID: 19
	private const int SW_SHOW = 5;
}
