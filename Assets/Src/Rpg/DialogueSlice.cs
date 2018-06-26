using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSlice {

    int characterLeft;
    int characterRight;
    bool slide;
    string name;
    string text;
    bool pauseForDecision;
    float lettersPerSecond;

    public DialogueSlice(int characterLeft, int characterRight, bool slide, bool pauseForDecision, float lettersPerSecond, string name, string text)
    {
        this.characterLeft = characterLeft;
        this.characterRight = characterRight;
        this.slide = slide;
        this.name = name;
        this.text = text;
        this.pauseForDecision = pauseForDecision;
        this.lettersPerSecond = lettersPerSecond;
    }
}
