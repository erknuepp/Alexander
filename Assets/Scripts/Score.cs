using Assets.Scripts;

using TMPro;

using UnityEngine;

public class Score : MonoBehaviour
{
    TextMeshPro tmp;
    // Start is called before the first frame update
    void Start()
    {
        tmp = gameObject.GetComponent<TextMeshPro>();        
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = ScoreKeeper.Total.ToString();
    }

    private void OnApplicationQuit()
    {
        if(ScoreKeeper.Total > ScoreKeeper.High)
        {
            DataLayer.CreateAndWriteFile(ScoreKeeper.Total.ToString());
        }
    }
}
