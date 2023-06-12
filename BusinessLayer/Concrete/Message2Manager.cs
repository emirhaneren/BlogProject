﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMesage2Service
    {
        IMessage2Dal _message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public void AddT(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 GetById(int id)
        {
            return _message2Dal.GetById(id);
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _message2Dal.GetListWithMessageByWriter(id);
        }

        public List<Message2> GetList()
        {
            return _message2Dal.GetListAll();
        }

        public void UpdateT(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
