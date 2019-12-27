//
// Author:
//   Michael G�ricke
//
// Copyright (c) 2019
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

namespace EpsSharp.Eps.Content
{
    /// <summary>
    /// The lexer token
    /// </summary>
    public enum LexerToken
    {
        Comment,
        DscComment,
        Integer,
        Real,
        String,
        HexString,
        AsciiBase85String,
        Name,
        Operator,
        ImmediateOperator,
        BeginArray,
        EndArray,
        BeginDictionary,
        EndDictionary,
        Eof,
        BeginProcedure,
        EndProcedure,
    }
}
