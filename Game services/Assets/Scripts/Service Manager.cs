using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameServices
{
    public class ServiceManager : MonoBehaviour
    {
        public static ServiceManager instance = null;
        public static AdsService Ads { get; private set; }
        private List<IService> _serviceManagers = new List<IService>();
        // Start is called before the first frame update
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
            Ads = GetComponent<AdsService>();
            _serviceManagers.Add(Ads);
            foreach (IService service in _serviceManagers)
            {
                service.Initialize();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}