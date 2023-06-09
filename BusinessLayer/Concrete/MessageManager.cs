﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void AddT(Message t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(Message t)
        {
            throw new NotImplementedException();
        }

        public Message GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            return _messageDal.GetListAll();
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDal.GetListAll(x => x.Receiver == p);
        }

        public void UpdateT(Message t)
        {
            throw new NotImplementedException();
        }

    }
}
