namespace MyWebAPI.Services;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using Repositories;

public class ChannelRepository : IChannelRepository
{
    public Task<Channel> Add(Channel channel)
    {
        throw new NotImplementedException();
    }

    public Task<Channel> Delete(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Task<Channel?> GetById(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Channel>> GetChannels(int pageIndex, int pageSize)
    {
        throw new NotImplementedException();
    }


}