﻿using UnityEngine;

public static class AudioPlayer
{
    public static void Music()
    {
        if (AudioOut.Instance.CurrentMusic != null)
            return;
        AudioOut.Instance.PlayMusic("Audio/Music/Gameplay", 1.0f, 0.0f);
    }
}