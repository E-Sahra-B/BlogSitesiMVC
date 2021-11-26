using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        private readonly IMessage2Dal _messageDal;
        public Message2Manager(IMessage2Dal messageDal)
        {
            _messageDal = messageDal;
        }
        public Message2 GetByID(int id)
        {
            return _messageDal.GetByID(id);
        }
        public List<Message2> GetList()
        {
            return _messageDal.GetListAll();
        }
        public List<Message2> GetInboxListByWriter(int id)
        {
            //return _messageDal.GetListAll(x => x.ReceiverID == id);
            return _messageDal.GetListWithMessageByWriter(id);
        }
        public void TAdd(Message2 t)
        {
            _messageDal.Insert(t);
        }
        public void TDelete(Message2 t)
        {
            _messageDal.Delete(t);
        }
        public void TUpdate(Message2 t)
        {
            _messageDal.Update(t);
        }
    }
}
