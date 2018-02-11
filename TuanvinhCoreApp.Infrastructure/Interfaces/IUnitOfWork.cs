using System;
using System.Collections.Generic;
using System.Text;

namespace TuanvinhCoreApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// call save change for Db
        /// </summary>
        void Commit();
    }
}
