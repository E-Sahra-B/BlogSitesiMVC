﻿using Entity.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IMessage2Dal : IGenericDal<Message2>
    {
        List<Message2> GetListWithMessageByWriter(int id);
    }
}