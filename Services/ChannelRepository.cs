namespace MyWebAPI.Services;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using Repositories;

public class ChannelRepository : IChannelRepository
{
    readonly StreamingContext ctx;
    public ChannelRepository(StreamingContext context)
        => ctx = context;

    public async Task<Channel> Add(Channel channel)
    {
        await ctx.AddAsync(channel);
        await ctx.SaveChangesAsync();
        return channel;
    }

    public async Task<Channel> Delete(Guid guid)
    {
        await ctx.Remove();
    }

    public async Task<Channel?> GetById(Guid guid)
        => await ctx.Channels.FindAsync(guid);

    public async Task<IEnumerable<Channel>> GetChannels(int pageIndex, int pageSize)
        => await ctx.Channels
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();


}