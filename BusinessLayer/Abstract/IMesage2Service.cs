using EntitiyLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMesage2Service : IGenericService<Message2>
    {
        List<Message2> GetInboxListByWriter(int id);
    }
}
