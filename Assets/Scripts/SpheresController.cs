using UnityEngine;

namespace Assets.Scripts
{
    public class SpheresController : MonoBehaviour
    {
        [SerializeField] private GameObject _spheresGrid;
        [SerializeField] private CubeDistance _cubeDistance;

        public void Update()
        {
            if (_cubeDistance.Distance < 2)
            {
                _spheresGrid.SetActive(true);
            }
            else if (_spheresGrid.activeSelf)
            {
                _spheresGrid.SetActive(false);
            }
        }
    }
}
