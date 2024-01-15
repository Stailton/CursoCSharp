internal static class ExtensaoStringHelpers
{
    public static string ParseHome(this string path)
    {
        string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
            Environment.OSVersion.Platform == PlatformID.Other)
            ? Environment.GetEnvironmentVariable("HOME")
            : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
        return path.Replace("~", home);
    }
}