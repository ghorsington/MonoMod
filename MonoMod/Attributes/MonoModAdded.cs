﻿using System;

namespace MonoMod {
    [MonoModIgnore]
    /// <summary>
    /// MonoMod "added" attribute.
    /// Will be applied by MonoMod automatically on patched types / members.
    /// </summary>
    public class MonoModAdded : Attribute {
    }
}

