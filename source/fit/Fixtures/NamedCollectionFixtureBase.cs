// Copyright � 2011 Syterra Software Inc.
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License version 2.
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

using fit;
using System.Collections;
using System.Collections.Generic;
using fitlibrary.exception;

namespace fitlibrary {

	public abstract class NamedCollectionFixtureBase: CollectionFixtureBase {
	    protected NamedCollectionFixtureBase(IEnumerable<object> theArray): base(theArray) {}

	    protected NamedCollectionFixtureBase(IEnumerable theCollection): base(theCollection) {}

	    protected NamedCollectionFixtureBase(IEnumerator theEnumerator): base(theEnumerator) {}

        public override void DoRows(Parse theRows) {
            if (theRows == null) throw new TableStructureException("Header row missing.");
            myHeaderRow = theRows;
            CompareRows(theRows);
        }

        protected Parse myHeaderRow;
    }

}
