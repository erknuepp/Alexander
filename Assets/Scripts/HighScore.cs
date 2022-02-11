using TMPro;

using UnityEngine;

public class HighScore : MonoBehaviour
{
    TextMeshPro tmp;
    // Start is called before the first frame update
    void Start()
    {
        tmp = gameObject.GetComponent<TextMeshPro>();
        tmp.text = Assets.Scripts.DataLayer.ReadFile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        //DataLayer.CreateAndWriteFile(ScoreKeeper.Total.ToString());
    }
}
