using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct TalkData
{
    public string name;
    public string[] contexts;
}
public class ScriptManager : MonoBehaviour
{

    public GameObject targetObject;
    public Text script, npcName;
    public GameObject textBoard, Portrait, PortraitOutline;
    public bool isVisible;

    string eventName;
    TalkData[] talkDatas;
    private static Dictionary<string, TalkData[]> DialogueDictionary = new Dictionary<string, TalkData[]>();
    [SerializeField] private TextAsset csvFile = null;
    string csvText;
    string[] rows;



    private void Awake()
    {
        if (csvFile != null)
        {
            Parsing();
        }
    }

    public void Search(GameObject targetObj)
    {
        PlayerController.canMoving = false;
        script.text = "�̰���" + targetObj.name + "�̴�";
        isVisible = true;
        textBoard.SetActive(true);
        PortraitOutline.SetActive(true);
    }

    public void CloseScript()
    {

        isVisible = false;
        PortraitOutline?.SetActive(false);
        textBoard.SetActive(false);
        PlayerController.canMoving = true;
    }

    public void Parsing()
    {
        csvText = csvFile.text.Substring(0, csvFile.text.Length - 1);
        rows = csvText.Split(new char[] { '\n' });
        for (int i = 0; i < rows.Length; i++)
        {
            string[] rowValues = rows[i].Split(new char[] { ',' });

            if (rowValues[0].Trim() == "" || rowValues[0].Trim() == "end") continue;

            List<TalkData> talkDatas = new List<TalkData>();
            string eventName = rowValues[0];
            while (rowValues[0].Trim() != "end")
            {
                List<string> contexts = new List<string>();

                TalkData talkData;
                talkData.name = rowValues[1];

                do
                {
                    contexts.Add(rowValues[2].ToString());
                    if (++i < rows.Length)
                    {
                        rowValues = rows[i].Split(new char[] { ',' });
                    }
                    else break;
                }
                while (rowValues[1] == "" && rowValues[0] != "end");
                talkData.contexts = contexts.ToArray();
                talkDatas.Add(talkData);
            }
            DialogueDictionary.Add(eventName, talkDatas.ToArray());
        }
    }
    public static TalkData[] GetDialogue(string eventname)
    {
        return DialogueDictionary[eventname];
    }
}
