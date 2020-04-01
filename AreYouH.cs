#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class AreYouH 
{
    static AreYouH()
    {
        if (EditorApplication.timeSinceStartup > 10) return;
        Debug.Log("Are you H??");
        var isH = EditorUtility.DisplayDialog("H??", "あなたはえっちですか??", "えっちです!", "えっちじゃないです");
        if (isH)
        {
            Debug.Log("えっち!!");
            EditorUtility.DisplayDialog("H??", "えっち!", "(///ω///)");
        }
        else
        {
            Debug.Log("|ω･`)");
            EditorApplication.Exit(0);
        }
    }
}
#endif
