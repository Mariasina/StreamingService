namespace MyWebAPI.Repositories;
using Models;

public interface IChannelRepository {
    Task<IEnumerable<Channel>> GetChannels(int pageIndex, int pageSize);
    Task<Channel?> GetById(Guid guid);
    Task<Channel> Add(Channel channel);
    Task<Channel> Delete(Guid guid);


}