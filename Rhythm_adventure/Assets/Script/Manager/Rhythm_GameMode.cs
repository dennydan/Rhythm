using UnityEngine;

namespace RhythmAssets
{
    public class Rhythm_GameMode : MonoBehaviour
    {
        public int Score = 0;

        // Start is called before the first frame update

        private AudioSource Music_Main;
        private void Awake()
        {
            Music_Main = transform.GetComponent<AudioSource>();
           
        }
         
        void Start()
        {
            Music_Main.Play();
        }
        public void SaveGame(GameData gameData)
        {
            
        }
    }
}
