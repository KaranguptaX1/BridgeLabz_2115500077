using System;
namespace DatabaseModule
{
    public class DatabaseConnection
    {
        public bool IsConnected { get; private set; }

        public void Connect()
        {
            if (IsConnected)
                throw new InvalidOperationException("Database is already connected.");

            Console.WriteLine("Database connected.");
            IsConnected = true;
        }

        public void Disconnect()
        {
            if (!IsConnected)
                throw new InvalidOperationException("Database is already disconnected.");

            Console.WriteLine("Database disconnected.");
            IsConnected = false;
        }
    }
}