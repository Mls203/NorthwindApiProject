using Core.Utilities.IoC;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Core.CrossCuttingConcern.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        private readonly IMemoryCache _memoryCache;

        private readonly HashSet<string> _cacheKeys = new();

        public MemoryCacheManager()
        {
            _memoryCache = ServiceTool.ServiceProvider
                .GetRequiredService<IMemoryCache>();
        }

        public void Add(string key, object value, int duration)
        {
            _memoryCache.Set(
                key,
                value,
                TimeSpan.FromMinutes(duration));

            _cacheKeys.Add(key);
        }

        public T Get<T>(string key)
        {
            return _memoryCache.Get<T>(key);
        }

        public object Get(string key)
        {
            return _memoryCache.Get(key);
        }

        public bool IsAdd(string key)
        {
            return _memoryCache.TryGetValue(key, out _);
        }

        public void Remove(string key)
        {
            _memoryCache.Remove(key);
            _cacheKeys.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {
            var regex = new Regex(
                pattern,
                RegexOptions.Singleline |
                RegexOptions.Compiled |
                RegexOptions.IgnoreCase);

            var keysToRemove = _cacheKeys
                .Where(key => regex.IsMatch(key))
                .ToList();

            foreach (var key in keysToRemove)
            {
                _memoryCache.Remove(key);
                _cacheKeys.Remove(key);
            }
        }
    }
}
