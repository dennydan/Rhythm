using UnityEngine;

namespace RhythmAssets
{
    public class Rhythm_GameMode : MonoBehaviour
    {

        public int Chap = 0;
        public int Level = 0;
        public int Score = 0;
        public float damageLevel = 0.1f;
        public bool isGameOver = false;
        public LevelData[,] datas_GM = new LevelData[5,5];
        // Start is called before the first frame update

        public AudioSource Music_Main;
        private void Awake()
        {
            GameData data = SaveSystem.LoadData(this);
            datas_GM = data.levelDatas;
            Score = datas_GM[Chap, Level].Score;
            Debug.Log(Score);
            Music_Main = transform.GetComponent<AudioSource>();
           
        }

        public void SaveData_GM()
        {
            
        }
         
        void Start()
        {
            Music_Main.Play();
        }
    }
}
