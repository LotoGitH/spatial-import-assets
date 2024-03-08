using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpatialSys.UnitySDK;

namespace MyCode
{
    public class FlagCtrl : MonoBehaviour
    {
        public ParticleSystem _ParticleSystem;

        public AudioSource _AudioSource;

        public BoxCollider _BoxCollider;
        // Start is called before the first frame update
        void Start()
        {
            SpatialBridge.coreGUIService.SetCoreGUIEnabled(SpatialCoreGUITypeFlags.Chat, false);
        }

        // Update is called once per frame
        public void RestartState()
        {
            _BoxCollider.enabled = true;
            _AudioSource.Play();
            GetComponent<Animator>().SetTrigger("Touched");
        }

        public void HideFlag()
        {
            _BoxCollider.enabled = false;
            _ParticleSystem.Play();
            _AudioSource.Play();
        }
    }
}
