using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public abstract class Client
    {
        abstract public int GetData();
    }

    public class RealClient : Client
    {
        public RealClient()
        {
            Console.WriteLine("RealClient: Initialized");
        }

        public override int GetData()
        {
            Console.WriteLine("RealClient's Data: 1234");

            return 1234;
        }
    }

    public class ProxyClient : Client
    {
        List<RealClient> client = null;

        public ProxyClient()
        {
            Console.WriteLine("ProxyClient: Initialized");
            client = new List<RealClient>();
            client.Add(new RealClient());
        }

        public override int GetData()
        {
            return client[0].GetData();
        }
    }
}
