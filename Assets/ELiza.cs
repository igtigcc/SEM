using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] TMP_Text chatlog;
    [SerializeField] TMP_InputField input;
    string content = "Hey";
    void Start()
    {

    }

    void Update()
    {
        chatlog.text = content;
    }
    public void Send()
    {
        content += "\nyou: " + input.text;
        Response(input.text);
        input.text = "";
    }
    void Response(string msg)
    {
        string response = "";
        if (msg.Contains("lewis hamilton"))
        {
            response = "is the best f1 driver of all time!";

        }
        if (msg.Contains("i like "))
        {
            if (msg.Contains("who is the best f1 driver?"))
                response = "lewis hamilton is the best f1 driver of all time!";

        }
        else if (msg.Contains("max verstappen"))
        {
            response = "is good but not as good as lewis!";
        }

        Match match = Regex.Match(msg, "^i feel ");
        if (match.Success)
        {
            msg = msg.Remove(0, match.Length);
            response = $"Why do you feel {msg}?";
        }


        content += "\nEliza: " + response;
    }
}
