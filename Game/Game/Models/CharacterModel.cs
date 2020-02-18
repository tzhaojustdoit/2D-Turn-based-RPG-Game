﻿using Game.Services;
using SQLite;
namespace Game.Models
{
    /// <summary>
    /// Character for the Game
    /// </summary>
    public class CharacterModel : BaseModel<CharacterModel>
    {
        // Value of attack attribute of the Character
        public int Attack { get; set; } = 0;

        // Value of defence attribute of the Character
        public int Defense { get; set; } = 0;

        // Value of health attribute of the Character
        public int MaxHealth { get; set; } = 0;

        //Value of current health attribute of the Character
        public int CurrentHealth { get; set; } = 0;

        // Value of Speed of the Character
        public int Speed { get; set; } = 0;

        // Level of the Character
        public int Level { get; set; } = 1;

        // Total Experience of Character
        public int Experience { get; set; } = 0;

        // Check if the Character is alive in the game
        public bool Alive { get; set; } = true;


        // Item id for head location
        public string HeadId { get; set; }
        // Item for head
        [Ignore]
        public ItemModel Head { get; set; }


        // Item id for necklace
        public string NecklaceId { get; set; }

        // Item for necklace
        [Ignore]
        public ItemModel Necklace { get; set; }

        // Item id for primary hand
        public string PrimaryHandId { get; set; }
        // Item for primary hand
        [Ignore]
        public ItemModel PrimaryHand { get; set; }

        // Item id for off hand
        public string OffHandId { get; set; }

        // Item for off hand
        [Ignore]
        public ItemModel OffHand { get; set; }

        // Item id for Right Finger
        public string RightFingerId { get; set; }


        // Item for Right Finger
        [Ignore]
        public ItemModel RightFinger { get; set; }

        // Item id for Left Finger
        public string LeftFingerId { get; set; }

        // Item for Left Finger
        [Ignore]
        public ItemModel LeftFinger { get; set; }

        // Item id for feet
        public string FeetId { get; set; }

        // Item for feet
        [Ignore]
        public ItemModel Feet { get; set; }

        // The Enum of Character Class. Every Character can only have one Class 
        [Ignore]
        public CharacterClassEnum CharacterClass { get; set; } = CharacterClassEnum.Unknown;

        /// <summary>
        /// Default CharacterModel
        /// Establish the Default Image Path
        /// </summary>
        public CharacterModel() {
            Name = "";
            var randomUriDescription = CharacterService.GetRandomURIDescription();
            ImageURI = randomUriDescription.Item1;
            Description = randomUriDescription.Item2;
            Attack = 5;
            Defense = 5;
            Speed = 5;
            MaxHealth = 5;
            CurrentHealth = MaxHealth;
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
            CharacterClass = newData.CharacterClass;
            Attack = newData.Attack;
            Defense = newData.Defense;
            Speed = newData.Speed;
            MaxHealth = newData.MaxHealth;
            CurrentHealth = newData.MaxHealth;
            Level = newData.Level;
            Experience = newData.Experience;

            Head = newData.Head;
            HeadId = Head.Id;

            Necklace = newData.Necklace;
            NecklaceId = Necklace.Id;

            PrimaryHand = newData.PrimaryHand;
            NecklaceId = Necklace.Id;

            OffHand = newData.OffHand;
            OffHandId = OffHand.Id;

            RightFinger = newData.RightFinger;
            RightFingerId = RightFinger.Id;

            LeftFinger = newData.LeftFinger;
            LeftFingerId = LeftFinger.Id;

            Feet = newData.Feet;
            FeetId = Feet.Id;
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