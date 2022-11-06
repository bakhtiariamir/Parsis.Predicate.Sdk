using Microsoft.Extensions.Caching.Memory;
using Parsis.Predicate.Sdk.Contract;

namespace Parsis.Predicate.Sdk.Info;
public abstract class CacheCacheObjectInfo<TObjectInfo, TObject> : ICacheObjectInfo<TObjectInfo, TObject> where TObjectInfo : IObjectInfo<TObject>, new() where TObject : class
{
    private readonly IMemoryCache _memoryCache;
    private readonly MemoryCacheEntryOptions _cacheCacheEntryOptions;

    protected abstract string ObjectInfoType
    {
        get;
    }
    protected CacheCacheObjectInfo(IMemoryCache memoryCache, MemoryCacheEntryOptions cacheCacheEntryOptions)
    {
        _memoryCache = memoryCache;
        _cacheCacheEntryOptions = cacheCacheEntryOptions;
    }


    protected virtual TObjectInfo GetObjectInfo()
    {
        var key = $"{typeof(TObject)}_{ObjectInfoType}";
        var data = _memoryCache.Get(key);
        return data != null ? (TObjectInfo)data : new TObjectInfo();
    }

    protected virtual void SaveObjectInfo(TObjectInfo objectInfo) => _memoryCache.Set($"{typeof(TObject)}_{ObjectInfoType}", objectInfo, options: _cacheCacheEntryOptions);


}
