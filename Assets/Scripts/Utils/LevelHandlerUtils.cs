using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace RunAndJump {

	public class LevelHandlerUtils : MonoBehaviour {

		private static Level _level;

		public static IEnumerator LoadLevel(string sceneName) {
			SceneManager.LoadScene(sceneName);
			yield return 0;
			_level = GameObject.FindObjectOfType<Level>();
		}

		public static void DestroyLevel() {
			if(_level != null) {
				Destroy(_level.gameObject);
			}
		}
	}
}
