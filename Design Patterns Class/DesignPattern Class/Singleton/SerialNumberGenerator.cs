using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace Singleton
{
    public class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;
        public static object synchronizatioRoot = new object();
        private int _count = 12345;

        public static SerialNumberGenerator Instance
        {
            get { if (instance == null)

                {
                    lock (synchronizatioRoot)

                    {

                        if (instance == null)

                        {
                            instance = new SerialNumberGenerator(); }

                    }

                } return instance; }
        }


        private SerialNumberGenerator() { }

        public virtual int NextSerial
        {
            get { return ++_count}

        }





    }
}
