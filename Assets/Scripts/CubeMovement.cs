using UnityEngine;

namespace Assets.Scripts
{
    public class CubeMovement : MonoBehaviour
    {
        [SerializeField] private RectTransform _rectTransform;
    
        public void MakeMove(float x, float z)
        {
            _rectTransform.anchoredPosition3D = new Vector3(_rectTransform.anchoredPosition3D.x + x, _rectTransform.anchoredPosition3D.y, _rectTransform.anchoredPosition3D.z + z);
        }
    }
}
