using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace PlenteumWallet
{
    class ConnectionManager
    {
        public static int rpcID = 0;
        public static string _rpcRand = new Random().Next(10000000, 999999999).ToString();

        private static JObject _request(string method, Dictionary<string,object> args)
        {
            var builtURL = Properties.Settings.Default.RPCprotocol + "://" + Properties.Settings.Default.RPCdestination + ":" + Properties.Settings.Default.RPCport + Properties.Settings.Default.RPCtrailing;
            var payload = new Dictionary<string, object>()
            {
                { "jsonrpc", "2.0" },
                { "password", _rpcRand},
                { "method", method },
                { "params", args },
                { "id", rpcID.ToString() }
            };

            string payloadJSON = JsonConvert.SerializeObject(payload, Formatting.Indented);
            rpcID++;

            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            var cli = new PlenteumClient();
            cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            string response = cli.UploadString(builtURL, payloadJSON);

            var jobj = JObject.Parse(response);
            if (jobj.ContainsKey("error"))
            {
                throw new Exception("service RPC failed with error: " + Convert.ToInt32(jobj["error"]["code"]).ToString() + "  " + jobj["error"]["message"]);
            }

            return (JObject)jobj["result"];
        }

        public static string _requestRPC(string method, string args)
        {
            var args_dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(args);
            var builtURL = Properties.Settings.Default.RPCprotocol + "://" + Properties.Settings.Default.RPCdestination + ":" + Properties.Settings.Default.RPCport + Properties.Settings.Default.RPCtrailing;
            var payload = new Dictionary<string, object>()
            {
                { "jsonrpc", "2.0" },
                { "password", _rpcRand},
                { "method", method },
                { "params", args_dict },
                { "id", rpcID.ToString() }
            };

            string payloadJSON = JsonConvert.SerializeObject(payload, Formatting.Indented);
            rpcID++;

            var cli = new WebClient();
            cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            string response = cli.UploadString(builtURL, payloadJSON);

            return response;
        }

        public static Tuple<bool,string,JObject> Request(string method, Dictionary<string, object> args = null)
        {
            if (args == null) args = new Dictionary<string, object>() { };

            try
            {
                var results = _request(method, args);
                return Tuple.Create<bool, string, JObject>(true, "", results);
            }
            catch (Exception e)
            {
                return Tuple.Create<bool,string,JObject>(false, e.Message, null);
            }
        }

        public static Tuple<bool,string, Process> StartDaemon(string wallet, string pass)
        {
            var curDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var serviceexe = System.IO.Path.Combine(curDir, "wallet-service.exe");

            if (IsRunningOnMono())
            {
                serviceexe = System.IO.Path.Combine(curDir, "wallet-service");
            }

            if (!System.IO.File.Exists(wallet))
            {
                return Tuple.Create<bool,string,Process>(false, "Wallet file cannot be found! Must exit!", null);
            }

            var conflictingProcesses = Process.GetProcessesByName("wallet-service").ToArray();
            int numConflictingProcesses = conflictingProcesses.Length;

            for (int i = 0; i < numConflictingProcesses; i++)
            {
                /* Need to kill all service and Plenteumd processes so
                   they don't lock the DB */
                conflictingProcesses[i].Kill();
            }



            /* Delete service.log if it exists so we can ensure when reading
               the file later upon a crash, that we are reporting the proper
               crash reason and not some previous crash */
            System.IO.File.Delete("wallet-service.log");

            Process p = new Process();
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = serviceexe;

            var daemonProcess = Process.GetProcessesByName("Plenteumd").ToArray();
            if (!daemonProcess.Any())
            {
                //There's no local daemon process running, so start service with a remote node
                //gui.plenteum.com -round-robin DNS  
                p.StartInfo.Arguments = CLIEncoder.Encode(new string[] { "-w", wallet, "-p", pass, "--rpc-password", _rpcRand, "--daemon-address", "two.public.plenteum.com", "--daemon-port", "44016" });
            }
            else
            {
                //there's a local daemon process running already, so start the wallet service linked to that
                p.StartInfo.Arguments = CLIEncoder.Encode(new string[] { "-w", wallet, "-p", pass, "--rpc-password", _rpcRand, "--daemon-address", "127.0.0.1", "--daemon-port", "44016" });
            }

            int maxConnectionAttempts = 5;

            /* It takes a small amount of time to kill the other processes
               if needed, so lets try and connect a few times before failing. */
            for (int i = 0; i < maxConnectionAttempts; i++)
            {
                p.Start();
                System.Threading.Thread.Sleep(1500);

                if (!p.HasExited)
                {
                    return Tuple.Create<bool, string, Process>(true, "", p);
                }
            }

            return Tuple.Create<bool, string, Process>(false, "Unable to keep daemon up!", null);
        }

        public static Tuple<bool,JObject> Get_live_stats()
        {
            string pool = "http://ple.virtopia.ca:8117/live_stats";
            string content = "";

            try
            {
                var cli = new DecompressClient();
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";
                content = cli.DownloadString(pool);
            }
            catch (Exception) { }

            //if (content == "")
            //{
            //    try
            //    {
            //        var cli = new DecompressClient();
            //        cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            //        content = cli.DownloadString(pool_us);
            //    }
            //    catch (Exception) { }
            //}

            if (content == "")
            {
                return Tuple.Create<bool, JObject>(false, null);
            }
            else
            {
                var jobj = JObject.Parse(content);
                return Tuple.Create<bool, JObject>(true, jobj);
            }
        }

        public static bool IsRunningOnMono()
        {
            return Type.GetType("Mono.Runtime") != null;
        }
    }

    public static class JsonConversionExtensions
    {
        public static IDictionary<string, object> ToDictionary(this JObject json)
        {
            var propertyValuePairs = json.ToObject<Dictionary<string, object>>();
            ProcessJObjectProperties(propertyValuePairs);
            ProcessJArrayProperties(propertyValuePairs);
            return propertyValuePairs;
        }

        private static void ProcessJObjectProperties(IDictionary<string, object> propertyValuePairs)
        {
            var objectPropertyNames = (from property in propertyValuePairs
                                       let propertyName = property.Key
                                       let value = property.Value
                                       where value is JObject
                                       select propertyName).ToList();

            objectPropertyNames.ForEach(propertyName => propertyValuePairs[propertyName] = ToDictionary((JObject)propertyValuePairs[propertyName]));
        }

        private static void ProcessJArrayProperties(IDictionary<string, object> propertyValuePairs)
        {
            var arrayPropertyNames = (from property in propertyValuePairs
                                      let propertyName = property.Key
                                      let value = property.Value
                                      where value is JArray
                                      select propertyName).ToList();

            arrayPropertyNames.ForEach(propertyName => propertyValuePairs[propertyName] = ToArray((JArray)propertyValuePairs[propertyName]));
        }

        public static object[] ToArray(this JArray array)
        {
            return array.ToObject<object[]>().Select(ProcessArrayEntry).ToArray();
        }

        private static object ProcessArrayEntry(object value)
        {
            if (value is JObject)
            {
                return ToDictionary((JObject)value);
            }
            if (value is JArray)
            {
                return ToArray((JArray)value);
            }
            return value;
        }
    }

    class DecompressClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            HttpWebRequest request = base.GetWebRequest(address) as HttpWebRequest;
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            return request;
        }
    }
    class PlenteumClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            HttpWebRequest request = base.GetWebRequest(address) as HttpWebRequest;
            request.Timeout = 60000;
            return request;
        }
    }
}
