using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private CubeDistance _cubeDistance;

        private AsyncOperation _action;

        public void Update()
        {
            if (_action == null && _cubeDistance.Distance < 1)
            {
                StartCoroutine(LoadScene2());
            }
        }

        private IEnumerator LoadScene2()
        {
            _action = SceneManager.LoadSceneAsync("Scene2");

            while (!_action.isDone)
            {
                yield return 0;
            }
        }
    }
}
