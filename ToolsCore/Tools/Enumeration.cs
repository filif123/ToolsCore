﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ToolsCore.Tools
{
    /// <summary>
    ///     Base class for extended enumeration types. This class is abstract.
    /// </summary>
    public abstract class Enumeration<T> : IComparable, IComparable<Enumeration<T>> where T : Enumeration<T>
    {
        private readonly bool useKey;

        /// <summary>
        ///     Creates new instance of <see cref="Enumeration{T}" /> with specified ID and name.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="name">Name of the element.</param>
        protected Enumeration(int id, string name)
        {
            ID = id;
            Name = name;
            Description = "";
            useKey = false;
        }

        /// <summary>
        ///     Creates new instance of <see cref="Enumeration{T}" /> with specified ID, name and description.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="name">Name of the element.</param>
        /// <param name="description">description of the element.</param>
        protected Enumeration(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
            useKey = false;
        }

        /// <summary>
        ///     Creates new instance of <see cref="Enumeration{T}" /> with specified key and name.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="name">Name of the element.</param>
        protected Enumeration(string key, string name)
        {
            Key = key;
            Name = name;
            Description = "";
            useKey = true;
        }

        /// <summary>
        ///     Creates new instance of <see cref="Enumeration{T}" /> with specified key, name and description.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="name">Name of the element.</param>
        /// <param name="description">description of the element.</param>
        protected Enumeration(string key, string name, string description)
        {
            Key = key;
            Name = name;
            Description = description;
            useKey = true;
        }

        /// <summary>
        ///     Identifikator prvku ako poradove cislo.
        /// </summary>
        public int ID { get; }

        /// <summary>
        ///     Identifikator prvku ako kluc v tvare retazca.
        /// </summary>
        public string Key { get; }

        /// <summary>
        ///     Viditelny nazov prvku.
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     Poznamka k prvku.
        /// </summary>
        public string Description { get; }

        /// <summary>
        ///     Compares the current instance with another object of the same type and returns an integer that indicates
        ///     whether the current instance precedes, follows, or occurs in the same position in the sort order as the other
        ///     object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance. </param>
        /// <returns>
        ///     A value that indicates the relative order of the objects being compared. The return value has these meanings:
        ///     Value Meaning Less than zero This instance precedes <paramref name="obj" /> in the sort order. Zero This instance
        ///     occurs in the same position in the sort order as <paramref name="obj" />. Greater than zero This instance follows
        ///     <paramref name="obj" /> in the sort order.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///     <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        public int CompareTo(object obj)
        {
            if (obj is Enumeration<T> en)
                return CompareTo(en);

            throw new ArgumentException(@"Argument is not the same type as this instance.", nameof(obj));
        }

        /// <summary>
        ///     Compares the current instance with another object of the same type and returns an integer that indicates
        ///     whether the current instance precedes, follows, or occurs in the same position in the sort order as the other
        ///     object.
        /// </summary>
        /// <param name="other">An object to compare with this instance. </param>
        /// <returns>
        ///     A value that indicates the relative order of the objects being compared. The return value has these meanings:
        ///     Value Meaning Less than zero This instance precedes <paramref name="other" /> in the sort order.  Zero This
        ///     instance occurs in the same position in the sort order as <paramref name="other" />. Greater than zero This
        ///     instance follows <paramref name="other" /> in the sort order.
        /// </returns>
        public int CompareTo(Enumeration<T> other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (other is null) return 1;
            return ID.CompareTo(other.ID);
        }

        /// <summary>
        ///     Vrati vsetky prvky enumeracie (public static fields).
        /// </summary>
        /// <typeparam name="T">Enumeration type.</typeparam>
        /// <returns>Zoznam prvkov zadaneho enumeracneho typu.</returns>
        public static List<T> GetValues()
        {
            return typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null))
                .Cast<T>().ToList();
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is not Enumeration<T> otherValue) return false;

            var typeMatches = GetType() == obj.GetType();
            var valueMatches = useKey ? Key == otherValue.Key : ID == otherValue.ID;

            return typeMatches && valueMatches;
        }


        /// <summary>
        ///     Compares two enumeration types.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        protected bool Equals(Enumeration<T> other) => useKey ? Key == other.Key : ID == other.ID;

        /// <summary>Serves as the default hash function.</summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode() => useKey ? Key.GetHashCode() : ID;

        /// <summary>
        ///     Compares two enumeration types.
        /// </summary>
        /// <param name="e1">First enumeration item.</param>
        /// <param name="e2">Second enumeration item.</param>
        /// <returns></returns>
        public static bool operator ==(Enumeration<T> e1, Enumeration<T> e2) => Equals(e1, e2);

        /// <summary>
        ///     Compares two enumeration types.
        /// </summary>
        /// <param name="e1">First enumeration item.</param>
        /// <param name="e2">Second enumeration item.</param>
        /// <returns></returns>
        public static bool operator !=(Enumeration<T> e1, Enumeration<T> e2) => !(e1 == e2);

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() => Name;

        /// <summary>
        ///     Pokusi sa konvertovat retazec na prvok enumeracie podla mena prvku.
        /// </summary>
        /// <param name="name">vstupny retazec</param>
        /// <returns>prvok enumeracie</returns>
        public static T Parse(string name)
        {
            foreach (var val in GetValues())
                if (val.Name == name)
                    return val;

            return null;
        }

        /// <summary>
        ///     Pokusi sa konvertovat retazec na prvok enumeracie podla mena prvku.<br></br>
        ///     V pripade uspechu vrati <see langword="true" /> a v <paramref name="result" /> bude ulzena konvertovany prvok.
        ///     V pripade ak nebol prvok uspesne konvertovany, vrati <see langword="false" />.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryParse(string name, out T result) 
        {
            result = Parse(name);
            return result != null;
        }
    }
}