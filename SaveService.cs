using System;
using System.IO; // This is required for file reading and writing
using System.Text.Json; // The Json requirment
using System.Windows.Forms;

namespace EscapefromWithin
{
    public static class SaveService // This will keep track of the Save/load state progress of the user
    {
        // This will build a path where the save file will live
        private static string SavePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "savegame.json");

        public static void Save(GameState state) // Saves the current game state to a file
        {
        
            try
            {   // Converts the GameState Objects to a readable JSON file and write a JSON tect to save file
                string json = JsonSerializer.Serialize(state, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(SavePath, json);
            }
            catch (UnauthorizedAccessException) // Exceptions will check for errors in files, and catch and other unexpected errors and if a program has to permisson to write files
            {
                MessageBox.Show("Save failed: No permission to write save file.", "Save Error");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Save Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Save Error");
            }
        }

        // Loads a save file OR starts a new game if none exist
        public static GameState LoadOrNew()
        {
            // if no saves exist then it returns a new game
            try
            {
                if (!File.Exists(SavePath))
                    return new GameState();

                string json = File.ReadAllText(SavePath); // Reads a save file
                GameState? loaded = JsonSerializer.Deserialize<GameState>(json); // converts a JSON into a GameState Object

                return loaded ?? new GameState();
            }
            catch (Exception ex) // If anything goes wrong starts fresh
            {
                MessageBox.Show("Load failed. Starting new game.\n\n" + ex.Message, "Load Error");
                return new GameState();
            }
        }
    }
}

