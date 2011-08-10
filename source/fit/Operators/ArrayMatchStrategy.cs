﻿// Copyright © 2010 Syterra Software Inc.
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License version 2.
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

using fitSharp.Fit.Model;

namespace fit.Operators {
    public class ArrayMatchStrategy: NamedMatchStrategy {
        public ArrayMatchStrategy(CellProcessor processor, Parse theHeaderRow): base(processor, theHeaderRow) {}
        public override bool IsOrdered {get { return true; }}
        public override bool SurplusAllowed {get {return false;}}
    }
}
