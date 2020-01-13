﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Pathoschild.Stardew.Common;
using StardewModdingAPI;
using StardewValley;
using StardewValley.Locations;
using StardewValley.Menus;
using StardewValley.Objects;

namespace DeliveryService.Framework
{public class DeliveryChest
    {
        /// <summary>The location or building which contains the chest.</summary>
        public GameLocation Location { get; }
        public Vector2 TileLocation { get; }
        public DeliveryOptions DeliveryOptions { get; }

        /// <summary>The chest's tile position within its location or building.</summary>
        public Chest Chest { get; }

        public DeliveryChest(Chest chest, GameLocation location)
        {
            this.Chest = chest;
            this.Location = location;
            this.TileLocation = chest.tileLocation;
            this.DeliveryOptions = new DeliveryOptions();
        }
        public DeliveryChest(Chest chest) : this(chest, LocationHelper.FindLocation(chest)) { }
        public bool Exists()
        {
            return (Chest != null && Location != null && LocationHelper.FindAtLocation(Location, Chest));
        }
        public bool IsFridge()
        {
            return (this.Location is FarmHouse house && Game1.player.HouseUpgradeLevel > 0 && house.fridge.Value == this.Chest);
        }
    }
}