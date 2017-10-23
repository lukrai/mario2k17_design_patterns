// singleton pattern
using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    class DatabaseConnect
    {
        private String connectionString;
        private String databaseName;
        private long userID;
        private long userScore;
        private static DatabaseConnect singletonInstance;
        private DatabaseConnect() { }
        private static object threadLock = new object();
        public static DatabaseConnect returnInstance()
        {
            lock (threadLock)
            {
                if (singletonInstance == null)
                {
                    singletonInstance = new DatabaseConnect();
                }
            }
            return singletonInstance;
        }

        public void updateScore()
        {
            Console.WriteLine("Score Updated");
        }
    }
}
