using System;
using DarkRift.Server;

namespace OutliersGameServerPlugin{
    public class OutiliersGamePlugin : Plugin {

        public OutiliersGamePlugin(PluginLoadData pluginLoadData) : base(pluginLoadData){
            ClientManager.ClientConnected += OnClientConnected;
            ClientManager.ClientDisconnected += OnClientDisconnected;
        }

        public override bool ThreadSafe => false;
        public override Version Version => new Version(0, 0, 1);
        

        private void OnClientConnected(object sender, ClientConnectedEventArgs e)
        {
            WriteEvent("hello friend, " + e.Client.ID, DarkRift.LogType.Info);
            e.Client.MessageReceived += OnClientMessageReceived;
        }

        private void OnClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            WriteEvent("goodbye friend, " + e.Client.ID, DarkRift.LogType.Info);
        }

        private void OnClientMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            switch (e.Tag)
            {
                case (ushort)Scripts.Networking.tags.Tag.SET_NAME:





                    break;

            }


        }


    }
}
