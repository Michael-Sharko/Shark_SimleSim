using Shark.Gameplay.Common;
using UnityEngine;

namespace Shark.Gameplay.Enviroment.Subjects
{
    public class TreeObjectSubject : WorldObjectSubject
    {
        public override void Collect()
        {
            Debug.Log("This is ROCK!");
        }
    }
}