using Shark.Gameplay.Common;
using UnityEngine;

namespace Shark.Gameplay.Enviroment.Subjects
{
    public class StoneObjectSubject : WorldObjectSubject
    {
        public override void Collect()
        {
            Debug.Log("This is ROCK!");
        }
    }
}