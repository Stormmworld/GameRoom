﻿using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.DTO.Objects
{
    public class SelectableAbility
    {
        public Guid AbilityId { get; set; }
        public string Name { get; set; }
        public List<TargetType> CanTarget { get; set; }
        public bool RequiresTarget { get; set; }
        public TargetScope TargetScope { get; set; }
    }
}
