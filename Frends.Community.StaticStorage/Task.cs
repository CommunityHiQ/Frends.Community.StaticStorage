using Newtonsoft.Json.Linq;
using System.Collections.Generic;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Frends.Community.StaticStorage
{
    public class Task
    {
        internal readonly static Dictionary<string, object> _storage = new Dictionary<string, object>();

        /// <summary>
        /// Adds a key-value-pair to the storage
        /// </summary>
        /// <param name="key">Key to identify added value</param>
        /// <param name="value">Value to add</param>
        /// <param name="overwrite">Should existing key-value be overwritten?</param>
        public static bool Add(string key, object value, bool overwrite = false)
        {
            if (overwrite)
                _storage[key] = value;
            else
                _storage.Add(key, value);

            return true;
        }

        /// <summary>
        /// Returns value from storage
        /// </summary>
        /// <param name="key">Key to the value to return to</param>
        /// <returns>object</returns>
        public static object Get(string key)
        {
            return _storage[key];
        }

        /// <summary>
        /// Removes key-value-pair from storage
        /// </summary>
        /// <param name="key">Key to remove</param>
        public static bool Remove(string key)
        {
            _storage.Remove(key);
            return true;
        }

        /// <summary>
        /// Clears all storage keys and values
        /// </summary>
        public static bool Clear()
        {
            _storage.Clear();
            return true;
        }

        /// <summary>
        /// Checks if key exists in storage
        /// </summary>
        /// <param name="key">Key to check</param>
        /// <returns>True if key exists, otherwise false</returns>
        public static bool ContainsKey(string key)
        {
            return _storage.ContainsKey(key);
        }

        /// <summary>
        /// Returns storage as JToken
        /// </summary>
        /// <returns>JToken</returns>
        public static JToken ToJToken()
        {
            return JToken.FromObject(_storage);
        }
    }
}
