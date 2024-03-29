﻿using UnityEngine;

namespace RPG.Core
{
    // this class in order to avoid messy singleton patterns
    public class PersistentObjectSpawner : MonoBehaviour
    {
        // config params
        [SerializeField] GameObject persistentObjectPrefab;

        static bool hasSpawned = false;

        private void Awake()
        {
            if (hasSpawned) return;

            SpawnPersistentObjects();

            hasSpawned = true;
        }

        private void SpawnPersistentObjects()
        {
            GameObject persistentObject = Instantiate(persistentObjectPrefab);
            DontDestroyOnLoad(persistentObject);
        }
    }
}
