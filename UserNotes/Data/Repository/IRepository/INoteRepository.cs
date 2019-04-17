using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserNotes.Models;

namespace UserNotes.Data.Repository.IRepository
{
    public interface INoteRepository
    {
        bool AddNote(Note note);
        bool UpdateNote(Note note);
        bool DeleteNote(int noteId);
        IEnumerable<Note> GetAllNote();
        Note GetNoteById(int noteId);
    }
}