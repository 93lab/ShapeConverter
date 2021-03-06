﻿//
// Author:
//   Michael Göricke
//
// Copyright (c) 2020
//
// This file is part of ShapeConverter.
//
// ShapeConverter is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program. If not, see<http://www.gnu.org/licenses/>.

using ShapeConverter.BusinessLogic.Generators;

namespace ShapeConverter.Shell.CommonViews
{
    /// <summary>
    /// One geometry type item
    /// </summary>
    public class GeometryTypeItem
    {
        /// <summary>
        /// The text to display
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The geometry type
        /// </summary>
        public GeometryGeneratorType GeometryGeneratorType { get; set; }
    }
}
