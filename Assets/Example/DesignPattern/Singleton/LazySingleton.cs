using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace SYX
{
    /// <summary>
    /// 单例模式
    /// 概述：保证一个类只有一个实例，并提供一个全局访问点
    /// 两种模式：1、饿汉模式：在类初始化的时候就创建好对象，适用于对象不是很占内存的场景
    /// 2、懒汉模式：在使用的时候创建对象，适用于对象比较占内存的场景
    /// </summary>
    public class LazySingleton
    {
        // 通过静态内部类实现懒汉模式
        private static class LazyHolder
        {
            public static readonly LazySingleton Instance = new LazySingleton();
        }

        // 为了防止外部主动创建类，故而把构造方法设为私有
        private LazySingleton()
        {
        }

        public static LazySingleton GetInstance()
        {
            return LazyHolder.Instance;
        }
    }

    internal class test
    {
        void testFun()
        {
            LazySingleton.GetInstance();
//            LazySingleton testObj = new LazySingleton();

            var input = "";
            var pattern = @"";
            Regex.Matches(input, pattern);
        }
    }
}
