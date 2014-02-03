using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbNanites.Core.Scheme
{
    /// <summary>
    /// DbNanites meta datatype which has to be mapped to the database.
    /// </summary>
	public enum Datatype
    {
        /// <summary>
        /// Unknown, used for errornous or undetermined values.
        /// </summary>
        Unknown,

        /// <summary>
        /// A basic integer value, whole numbers.
        /// </summary>
        Integer,

        /// <summary>
        /// A fixed decimals numeric value.
        /// </summary>
        Numeric,

        /// <summary>
        /// A floating point numeric value.
        /// </summary>
        Float,

        /// <summary>
        /// A variable length text field.
        /// </summary>
        VarChar,

        /// <summary>
        /// A fixed length text field.
        /// </summary>
        Char,

        /// <summary>
        /// A field able to save a large string.
        /// </summary>
        Text,

        /// <summary>
        /// Save a date.
        /// </summary>
        Date,

        /// <summary>
        /// Save date and time.
        /// </summary>
        DateTime,

        /// <summary>
        /// Saves a timestamp.
        /// </summary>
        Timestamp,

        /// <summary>
        /// Saves a boolean value.
        /// Mapped to INTEGER(1) on some RDBMS.
        /// </summary>
        Bool,

        /// <summary>
        /// Stores XML.
        /// Mapped to TEXT on some RDBMS.
        /// </summary>
        Xml,
    }
}
