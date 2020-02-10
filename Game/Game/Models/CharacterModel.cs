﻿using Game.Services;

namespace Game.Models
{
    /// <summary>
    /// Character for the Game
    /// </summary>
    public class CharacterModel : BaseModel<CharacterModel>
    {

        /// <summary>
        /// Default CharacterModel
        /// Establish the Default Image Path
        /// </summary>
        public CharacterModel() {
            ImageURI = CharacterService.DefaultImageURI;
        }

        /// <summary>
        /// Constructor to create a character based on what is passed in
        /// </summary>
        /// <param name="data"></param>
        public CharacterModel(CharacterModel data)
        {
            Update(data);
        }

        /// <summary>
        /// Update the Record
        /// </summary>
        /// <param name="newData">The new data</param>
        public override void Update(CharacterModel newData)
        {
            if (newData == null)
            {
                return;
            }

            // Update all the fields in the Data, except for the Id and guid
            Name = newData.Name;
            Description = newData.Description;

        }

        // Helper to combine the attributes into a single line, to make it easier to display the character as a string
        public string FormatOutput()
        {
            var myReturn = Name + " , " +
                            Description;

            return myReturn.Trim();
        }
    }
}