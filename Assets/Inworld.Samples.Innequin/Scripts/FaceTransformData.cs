﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace Inworld.Sample.Innequin
{
    [Serializable]
    public class FaceTransform
    {
        public string name;
        public int animIndex;
        public float imgHeight;
        public Texture eyeBlow;
        public Texture eye;
        public Texture eyeClosed;
        public Texture nose;
        public Texture mouthDefault;
        public List<Texture> mouth;
    }
    [CreateAssetMenu(fileName = "Face Transform Data", menuName = "Inworld/FaceTransform", order = 1)]
    public class FaceTransformData : ScriptableObject
    {
        public List<FaceTransform> data;

        public FaceTransform this[string facialName] => data.FirstOrDefault(f => f.name == facialName);

    }
}
