using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Viroo.Interaction;

namespace VirooLab.Examples
{
    public class CallActionOnStart : MonoBehaviour
    {
        [SerializeField]
        private List<ObjectAction> actions = default;

        private void Start()
        {
            foreach (var action in actions)
            {
                action.LocalExecute(string.Empty);
            }
        }
    }
}