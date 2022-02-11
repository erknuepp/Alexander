using TMPro;

using UnityEngine;

public class HighScore : MonoBehaviour
{
    TextMeshPro tmp;
    // Start is called before the first frame update
    void Start()
    {
        tmp = gameObject.GetComponent<TextMeshPro>();
        tmp.text = "100000";
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
