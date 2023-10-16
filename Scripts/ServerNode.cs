using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStore.Scripts
{
    public class ServerNode
    {
        public void RunServer()
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.FileName = "Server/node.exe";
            string argument = "Data/NodeServer/index.js";
            p.StartInfo.Arguments = @argument;
            p.Start();
        }
    }
}
