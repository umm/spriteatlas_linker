using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.U2D;

namespace UnityModule
{
    [PublicAPI]
    public class SpriteAtlasLinker : MonoBehaviour
    {
        [SerializeField] private List<SpriteAtlas> spriteAtlasList;
        public List<SpriteAtlas> SpriteAtlasList => spriteAtlasList;
    }
}