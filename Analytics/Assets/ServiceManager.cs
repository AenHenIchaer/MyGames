using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameServices
{
    public class ServiceManager : MonoBehaviour
    {
        public static ServiceManager instance = null;
        public static AdService Ads { get; private set; }

        private List<IService> _serviceManagers = new List<IService>();

        // Use this for initialization
        void Start()
        {
            if (instance == null)
                instance = this;
            else if (instance != null)
                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
            InitializeServices();
        }

        private void InitializeServices()
        {
            Ads = GetComponent<AdService>();
            _serviceManagers.Add(Ads);

            foreach(IService service in _serviceManagers)
            {
                service.Initialize();
            }
        }
    }
}
