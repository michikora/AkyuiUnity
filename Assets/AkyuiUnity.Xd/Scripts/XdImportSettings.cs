﻿using AkyuiUnity.Editor.ScriptableObject;
using UnityEngine;

namespace AkyuiUnity.Xd
{
    [CreateAssetMenu(menuName = "Akyui/XdImportSettings", fileName = "XdImportSettings")]
    public class XdImportSettings : AkyuiImportSettings
    {
        public string AkyuiOutputPath => akyuiOutputPath;
        [SerializeField] private string akyuiOutputPath = "";
    }
}