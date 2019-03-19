using System;
using DarkRift.Server;

namespace OutliersGameServerPlugin{
    public class OutiliersGamePlugin : Plugin {
        public override bool ThreadSafe => false;
        public override Version Version => new Version(0,0,1);
        public OutliersGameServerPlugin(PluginLoadData pluginLoadData) : base(pluginLoadData){

            ClientManager.ClientConnected += OnClientConnected;
            ClientManager.ClientDisconnected += OnClientDisconnected;

        }

        private void OnClientConnected(object sender, ClientConnectedEventArgs e){
            WriteEvent("hello friend, " + e.Client.ID, DarkRift.LogType.Info);
        }

        private void OnClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            WriteEvent("goodbye friend, " + e.Client.ID, DarkRift.LogType.Info);
        }

    }
}
