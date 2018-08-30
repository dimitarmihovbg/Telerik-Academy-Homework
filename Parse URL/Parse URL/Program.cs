using System;

class ParseURL
{
    static void Main()
    {
        string uRL = Console.ReadLine();      
        int indexOfProtocol = uRL.IndexOf("://");
        string protocol = uRL.Substring(0, indexOfProtocol);
        int indexOfServer = uRL.IndexOf("/", indexOfProtocol + 3);
        string server = uRL.Substring(indexOfProtocol + 3, indexOfServer - indexOfProtocol - 3);
        string resource = uRL.Substring(indexOfServer);
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}