﻿using UnityEngine;

namespace Assets.Scripts.Utilities
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T _Instance;

        public static T Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = FindObjectOfType<T>();
                }
                return _Instance;
            }
        }
    }
}