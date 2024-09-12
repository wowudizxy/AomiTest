using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BagTest
{
    [CreateAssetMenu(fileName = "BagItem", menuName = "ScriptableObjects/BagItem")]
    public class BagItemSo : ScriptableObject
    {
        public int id;
        public Sprite icon;
    }
}
