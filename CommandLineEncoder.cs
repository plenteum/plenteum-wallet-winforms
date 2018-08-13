/* This was created by macropas at - https://stackoverflow.com/a/10489920/8737306
   and modified for the target use case. Thanks! */

using System;

namespace PlenteumWallet
{
    class CLIEncoder
    {
        public static string Encode(string[] args)
        {
            if (args == null)
            {
                return null;
            }

            string result = "";

            if (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
            {
                foreach (string arg in args)
                {
                    result += (result.Length > 0 ? " " : "");

                    /* Surround the argument in single quotes to prevent !
                       getting expanded by bash */
                    result += "'";

                    /* Make sure to replace the \ with \\ before other changes,
                       so we don't escape other later escaped characters twice */
                    result += arg.Replace(@"\", @"\\")
                                 .Replace(@"'", @"'\''");

                    result += "'";
                }
            }

            else //Windows family
            {
                bool enclosedInApo, wasApo;
                string subResult;
                foreach (string arg in args)
                {
                    enclosedInApo = arg.LastIndexOfAny(
                        new char[] { ' ', '\t', '|', '@', '^', '<', '>', '&'}) >= 0;
                    wasApo = enclosedInApo;
                    subResult = "";
                    for (int i = arg.Length - 1; i >= 0; i--)
                    {
                        switch (arg[i])
                        {
                            case '"':
                                subResult = @"\""" + subResult;
                                wasApo = true;
                                break;
                            case '\\':
                                subResult = (wasApo ? @"\\" : @"\") + subResult;
                                break;
                            default:
                                subResult = arg[i] + subResult;
                                wasApo = false;
                                break;
                        }
                    }
                    result += (result.Length > 0 ? " " : "") 
                        + (enclosedInApo ? "\"" + subResult + "\"" : subResult);
                }
            }

            return result;
        }
    }
}
