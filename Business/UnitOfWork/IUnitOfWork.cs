using Business.Abstract;
using System;

namespace Business.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAboutService About { get; }
        IBlogService Blog { get; }
        ICategoryService Category { get; }
        ICommentService Comment { get; }
        IContactService Contact { get; }
        IMessageService Message { get; }
        IMessage2Service Message2 { get; }
        INewsLetterService Newsletter { get; }
        INotificationService Notification { get; }
        IWriterService Writer { get; }
        int SaveChanges();
    }
}
