using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace MyCode
{
    public class FlagMaster : MonoBehaviour
    {
        private FlagCtrl[] _flags;

        // Start is called before the first frame update
        void Start()
        {
            _flags = GameObject.FindObjectsByType<FlagCtrl>(FindObjectsSortMode.None);
        }

        public void RespawnFlags()
        {
            foreach (FlagCtrl f in _flags)
            {
                f.RestartState();
                
            }
        }
    }
}