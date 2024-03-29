﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using System;

namespace Business.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposedValue;
        private readonly Context context;
        public UnitOfWork()
        {
            if(context == null)
                context = new Context();
        }
        IAboutService about;
        IBlogService blog;
        ICategoryService category;
        ICommentService comment;
        IContactService contact;
        IMessage2Service message2;
        INewsLetterService newsletter;
        INotificationService notification;
        IWriterService writer;
        IAdminService admin;
        IUserService user;

        public IAboutService About => about ?? (about = new AboutManager(new EfAboutRepository(context)));
        //public IAboutService About => about ?? (about = new AboutManager(new MongoAboutRepository()));
        public IBlogService Blog => blog ?? (blog = new BlogManager(new EfBlogRepository(context)));
        public ICategoryService Category => category ?? (category = new CategoryManager(new EfCategoryRepository(context)));
        public ICommentService Comment => comment ?? (comment = new CommentManager(new EfCommentRepository(context)));
        public IContactService Contact => contact ?? (contact = new ContactManager(new EfContactRepository(context)));
        public IMessage2Service Message2 => message2 ?? (message2 = new Message2Manager(new EfMessage2Repository(context)));
        public INewsLetterService Newsletter => newsletter ?? (newsletter = new NewsLetterManager(new EfNewsLetterRepository(context)));
        public INotificationService Notification => notification ?? (notification = new NotificationManager(new EfNotificationRepository(context)));
        public IWriterService Writer => writer ?? (writer = new WriterManager(new EfWriterRepository(context)));
        public IAdminService Admin => admin ?? (admin = new AdminManager(new EfAdminRepository(context)));
        public IUserService User => user ?? (user = new UserManager(new EfUserRepository(context)));

        public int SaveChanges()
        {
            //return context.SaveChanges();
            using (var dbTransaction= context.Database.BeginTransaction())
            {
                    int result = context.SaveChanges();
                    dbTransaction.Commit();
                    return result;
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}