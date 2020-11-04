using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SYX
{
    public class HungrySingleton
    {
        private static readonly HungrySingleton instance = new HungrySingleton();

        public static HungrySingleton GetInstance()
        {
            return instance;
        }

        private HungrySingleton()
        {
        }
    }
}
