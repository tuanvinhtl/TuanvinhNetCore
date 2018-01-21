using System;
using System.Collections.Generic;
using System.Text;

namespace TuanvinhCoreApp.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}
