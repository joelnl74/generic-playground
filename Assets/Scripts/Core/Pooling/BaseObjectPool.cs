using System.Collections.Generic;
using UnityEngine;

namespace Core.Pooling
{
    public class BaseObjectPool<T> where T : MonoBehaviour
    {
        public UnityEngine.Pool.ObjectPool<T> pool { get; private set; }

        [SerializeField] private RectTransform _container;

        private T _instance;
        private List<T> _allInstances = new List<T>();        

        /// <summary>
        /// Configure the object pool and create base pool amount.
        /// </summary>
        /// <param name="instance">Type of instance to create.</param>
        /// <param name="container">Parent container to Instantiate in.</param>
        /// <param name="amount">Amount to pre pool.</param>
        public void Configure(T instance, RectTransform container, int amount = 0)
        {
            _instance = instance;
            _container = container;

            pool = new UnityEngine.Pool.ObjectPool<T>(OnCreate, OnGet, OnRelease);

            for (int i = 0; i < amount; i++)
            {
                var item = pool.Get();
            }

            ReleaseAll();
        }

        /// <summary>
        /// Put all objects back into the pool.
        /// </summary>
        public void ReleaseAll()
        {
            for (var i = 0; i < _allInstances.Count; i++)
            {
                var item = _allInstances[i];

                if (item.gameObject.activeSelf)
                {
                    Release(item);
                }
            }
        }

        /// <summary>
        /// Get instance from object pool.
        /// </summary>
        /// <returns></returns>
        public T Get()
            => pool.Get();

        /// <summary>
        /// Release instance from object pool.
        /// </summary>
        /// <param name="releaseObject"></param>
        public void Release(T releaseObject)
            => pool.Release(releaseObject);

        private T OnCreate()
        {
            var poolAbleObject = Object.Instantiate(_instance, _container);
            poolAbleObject.gameObject.SetActive(false);

            _allInstances.Add(poolAbleObject);

            return poolAbleObject;
        }

        private void OnGet(T model)
            => model.gameObject.SetActive(true);

        private void OnRelease(T model)
            => model.gameObject.SetActive(false);
    }
}
