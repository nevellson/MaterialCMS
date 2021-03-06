﻿using MaterialCMS.DbConfiguration;
using MaterialCMS.Entities;
using NHibernate;

namespace MaterialCMS.Events
{
    public abstract class OnAddingArgs
    {
        public abstract SystemEntity ItemBase { get; }
        public ISession Session { get; protected set; }
    }

    public class OnAddingArgs<T> : OnAddingArgs where T : SystemEntity
    {
        public OnAddingArgs(EventInfo<T> info, ISession session)
        {
            Item = info.Object;
            Session = session;
        }

        public T Item { get; private set; }

        public override SystemEntity ItemBase
        {
            get { return Item; }
        }
    }
}