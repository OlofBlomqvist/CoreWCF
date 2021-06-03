﻿using System;
using StandardClient;
using StandardCommon;

namespace DesktopClient
{
    class Program
    {
        private static readonly string s_hostname = "localhost";

        static void Main()
        {
            var settings = new Settings().SetDetaults(s_hostname);

            void log(string value) => Console.WriteLine(value);
            ClientLogic.CallUsingWcf(settings, log);

            string rawSoapResponse = ClientLogic.CallUsingWebRequest(settings.basicHttpAddress);
            Console.WriteLine($"Http SOAP Response:\n{rawSoapResponse}");

            Console.WriteLine("Hit enter to exit");
            Console.ReadLine();
        }
    }
}
