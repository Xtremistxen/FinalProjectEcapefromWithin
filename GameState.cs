using System;
using System.Collections.Generic;

namespace EscapefromWithin
{
    [Serializable]
    public class GameState // Using a GameState similair to Unity will keep track of users progress location, objects
    {
        // Track where the player is, helps load!
        public string CurrentLocation { get; set; } = "Outside";

        // tracks if the user has the key to access door
        public bool HasFrontDoorKey { get; set; } = false;

        // Tracks what seal the player has already collected
        public bool SealBrazier { get; set; } = false;
        public bool SealPotion { get; set; } = false;
        public bool SealPainting { get; set; } = false;
        public bool SealElements { get; set; } = false;

        
    }
}

