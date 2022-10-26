/* ================================================================
   ---------------------------------------------------
   Project   :    Quick Code
   Publisher :    Renowned Games
   Author    :    Tamerlan Shakirov
   ---------------------------------------------------
   Copyright 2022 Renowned Games All rights reserved.
   ================================================================ */

using UnityEditor;
using UnityEngine;

namespace RenownedGames.QuickCodeEditor
{
    static class DocsMenu
    {
        [MenuItem("Renowned Games/Quick Code/Documentation", false, 702)]
        public static void OpenAPI()
        {
            Help.BrowseURL("https://renownedgames.gitbook.io/quick-code/");
        }
    }
}