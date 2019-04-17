using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserNotes.Models;

namespace UserNotes.Service.IService
{
    public interface INoteService
    {
        Note GetNoteById(int id);
    }
}
