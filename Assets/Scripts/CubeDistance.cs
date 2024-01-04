using System;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class CubeDistance : MonoBehaviour
    {
        [SerializeField] private RectTransform _object1;
        [SerializeField] private RectTransform _object2;
        [SerializeField] private Text _distanceLabel;
        
        public float Distance => Vector3.Distance(_object1.transform.position, _object2.transform.position) - 1;

        private float _oldDistance;
        
        public void Update()
        {
            var _distance = Vector3.Distance(_object1.transform.position, _object2.transform.position) - 1;

            if (Math.Abs(_oldDistance - Distance) > 0.02)
            {
                _oldDistance = _distance;
                _distanceLabel.text = _distance < 0 ? "0" : _distance.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}
