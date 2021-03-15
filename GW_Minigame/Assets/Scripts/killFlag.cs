using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killFlag : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnDestroy() {
        Score.scoreScript.score += 1;
    }
}
