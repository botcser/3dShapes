
using UnityEngine;

namespace Assets.Scripts
{
    public class ArrowsMovement : MonoBehaviour
    {
        [SerializeField] private CubeMovement _cube;

        public void Update()
        {
            if (Input.GetKey("up"))
            {
                _cube.MakeMove(0, 0.2f);
            }
            else if (Input.GetKey("left"))
            {
                _cube.MakeMove(-0.2f, 0);
            }
            else if (Input.GetKey("down"))
            {
                _cube.MakeMove(0, -0.2f);
            }
            else if (Input.GetKey("right"))
            {
                _cube.MakeMove(0.2f, 0);
            }
        }
    }
}
