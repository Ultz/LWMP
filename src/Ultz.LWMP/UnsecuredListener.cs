﻿using System.Net.Sockets;
using System.Threading.Tasks;

namespace Ultz.LWMP
{
    public class UnsecuredListener : IListener
    {
        public UnsecuredListener(TcpListener listener)
        {
            Listener = listener;
        }

        public TcpListener Listener { get; }

        public void Start()
        {
            Listener.Start();
        }

        public void Stop()
        {
            Listener.Stop();
        }

        public async Task<IClient> AcceptClientAsync()
        {
            return new UnsecuredClient(await Listener.AcceptTcpClientAsync());
        }

        public void Dispose()
        {
        }
    }
}