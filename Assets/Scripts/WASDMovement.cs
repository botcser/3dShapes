using UnityEngine;

namespace Assets.Scripts
{
    public class WASDMovement : MonoBehaviour
    {
        [SerializeField] private CubeMovement _cube;

        public void Update()
        {
            if (Input.GetKey("w"))
            {
                _cube.MakeMove(0, 0.2f);
            }
            else if (Input.GetKey("a"))
            {
                _cube.MakeMove(-0.2f, 0);
            }
            else if (Input.GetKey("s"))
            {
                _cube.MakeMove(0, -0.2f);
            }
            else if (Input.GetKey("d"))
            {
                _cube.MakeMove(0.2f, 0);
            }
        }
    }
}
